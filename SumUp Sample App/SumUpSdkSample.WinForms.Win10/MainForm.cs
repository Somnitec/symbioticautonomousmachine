﻿using SumUp.Sdk;
using SumUp.Sdk.Pay;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandMessenger;
using CommandMessenger.Queue;
using CommandMessenger.Transport.Serial;


namespace SumUpSdkSample.WinForms.Win10
{
    public partial class MainForm : Form, IPaymentProgress
    {

       /// <summary>
       /// SUMUP STUFFS
       /// </summary>

        private SumUpService _sumUpService;
        private Tuple<Payment, CancellationTokenSource> _currentPayment;

        // ======= Authenticate with SumUp system and create SDK instance =======		
        private async Task CreateSumUpService(string clientId, string clientSecret, string email, string password)
        {
            // Create SumUp.Sdk.OAuthCredentials which holds:
            //   - Email /Password of existing SumUp Account
            //   - Client ID/Secret from https://me.sumup.com/developers for the account above
            OAuthCredentials credentials = new OAuthCredentials(clientId, clientSecret, email, password);


            // Do SumUp.Sdk.SumUpService initialization and login with credentials from above
            // The SumUpService object is used to initiate a payment and can be stored for multiple use
            _sumUpService = await SumUpService.CreateInstanceAsync(credentials);
        }

		
        // ======= Construct and make the payment =======		
        private async Task<PaymentResult> DoSumUpPayment(ulong amountInCents, PaymentMethod method, ConnectionMethod connection, string reference = null)
        {
            if (_sumUpService == null)
                throw new InvalidOperationException("_sumUpService is not initialized");

            // SumUp.Sdk.PaymentBuilder is used to take in payment info like amount, type of payment (terminal, cash), terminal connection
            PaymentBuilder paymentBuilder = new PaymentBuilder(amountInCents, method);
            
            if (!string.IsNullOrWhiteSpace(reference))
            {
                // PaymentBuilder.TransactionReference is an optional unique reference of the transaction
                paymentBuilder.TransactionReference = reference;
            }

            if (method == PaymentMethod.CardReader)
            {
                AppendToLog("-> Setting up reader connection...");

                // If the payment is done with terminal, we need to specify connection to the device.
                // When calling the corresponding method, the SumUp SDK will automatically search for a connected device.
                switch (connection)
                {
                    case ConnectionMethod.Audio:
                        await paymentBuilder.UseAudioConnectionAsync();
                        break;
                    case ConnectionMethod.Bluetooth:
                        await paymentBuilder.UseBluetoothGattConnectionAsync();
                        break;
                    case ConnectionMethod.Usb:
                        await paymentBuilder.UseUsbConnectionAsync();
                        break;
                }

                AppendToLog("   Connection was set up");
            }

            // Build the actual SumUp.Sdk.Payment object for passing to the SumUpService class
            Payment payment = paymentBuilder.Build();

            _currentPayment = new Tuple<Payment, CancellationTokenSource>(payment, new CancellationTokenSource());
            
            // Optionally subscribe for payment progress notifications where:
            //   - Payment.ReaderNotificationReceived notifies for actions that cardholder needs to take on the terminal (Enter PIN, etc.)
            //   - Payment.StatusChanged notifies for payent progression (waiting for card, processing, etc.)
            payment.ReaderNotificationReceived += Payment_ReaderNotificationReceived;
            payment.StatusChanged += Payment_StatusChanged;
            
            // SumUpService.PayAsync will do the actual payment. Await its result for final transaction status.
            // Mandatory parameter is a class implementing interface SumUp.Sdk.Pay.IPaymentProgress which has one method - NeedSignature
            return await _sumUpService.PayAsync(payment, this, _currentPayment.Item2.Token);
        }

        // Called during SumUpService.PayAsync to notify that card requires signature verification.
        // In case you do not want signature-verified cards, you can throw exception which will cancel the payment.
        public void NeedSignature(Payment sender, IPaymentAction action)
        {
            AppendToLog("=== SIGNATURE NOT IMPLEMENTED ===");
            AppendToLog("Signature was requested for the transaction but is not implemented. Will cancel\r\n");

            throw new NotImplementedException();
        }

        private void Payment_ReaderNotificationReceived(object sender, ReaderNotificationReceivedEventArgs e)
        {
            AppendToLog($"=== Reader Notification: {e.Notification.ToString()} ===");
        }

        private void Payment_StatusChanged(object sender, PaymentStatusChangedEventArgs e)
        {
            AppendToLog($"=== Payment Status Changed: {e.Status} / {e.StatusMessage} ===");
        }

        #region UI Wiring
        public MainForm()
        {
            InitializeComponent();
            PmntMtdConnectionCombo.SelectedIndex = 2;
            UpdateUI(UIState.NotLoggedIn);
            ArduinoSetup(this);
            //CreateSumUpService("yVDoUpXUZMJj_joXuQP2TEPHXdwX", "586d98472b564dd87120f9af9f3d3bca9c960a8078c0c0670c0f2122fa864a98", "arvidandmarie@sumup.com", "extdev");
            Console.WriteLine(@"mainform() finished");


        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            logInButton.PerformClick();
            Console.WriteLine(@"mainform loaded");
        }

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            UpdateUI(UIState.LoggingIn);

            try
            {
                await CreateSumUpService("yVDoUpXUZMJj_joXuQP2TEPHXdwX", "586d98472b564dd87120f9af9f3d3bca9c960a8078c0c0670c0f2122fa864a98", "arvidandmarie@sumup.com", "extdev");
                UpdateUI(UIState.Idle);

                logTextBox.Text = "Logged in\r\n\r\n\r\n <--- Start a payment on the right";
            }
            catch (Exception ex)
            {
                UpdateUI(UIState.NotLoggedIn, ex.ToString());
            }
        }

        private async void DoPaymentButton_Click(object sender, EventArgs e)
        {
            if (_sumUpService == null) return;
            
            if (!ulong.TryParse(AmountText.Text, out ulong amount))
            {
                UpdateUI(UIState.Idle, "Enter valid amount (i.e. \"100\" = 1.00)");
                return;
            }

            UpdateUI(UIState.PaymentInProgress);

            PaymentMethod method = PmntMtdCardReaderRadio.Checked ? PaymentMethod.CardReader : PaymentMethod.Cash;

            ConnectionMethod connection = ConnectionMethod.Usb;
            switch (PmntMtdConnectionCombo.SelectedIndex)
            {
                case 0:
                    connection = ConnectionMethod.Bluetooth;
                    break;
                case 1:
                    connection = ConnectionMethod.Audio;
                    break;
            }
            
            string paymentResultText = "Something went wrong!";
            try
            {
                PaymentResult paymentResult = await DoSumUpPayment(amount, method, connection, ReferenceText.Text);

                paymentResultText = string.Format(
                    "=== PAYMENT RESULT ===\r\n    Status: {0}\r\n    Transaction code: {1}\r\n    Transaction reference: {2}\r\n    Message: {3}\r\n    Message explanation: {4}",
                    paymentResult.Status,
                    paymentResult.TransactionCode,
                    paymentResult.TransactionReference,
                    paymentResult.Message,
                    paymentResult.MessageExplanation);
            }
            catch (Exception ex)
            {
                paymentResultText = ex.ToString();
            }
            finally
            {
                _currentPayment = null;
                UpdateUI(UIState.Idle, paymentResultText);
            }
        }

        private void CancelPaymentButton_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPayment.Item2.Cancel();
            }
            catch (Exception ex)
            {
                AppendToLog($"Could not cancel: {ex.ToString()}");
            }
            finally
            {
                CancelPaymentButton.Enabled = false;
            }
        }

        private void UpdateUI(UIState uiState, string statusText = null)
        {
            bool loginControlsEnabled = false;
            bool paymentControlsEnabled = false;
            string statusStripText = string.Empty;
            ProgressBarStyle statusStripProgress = ProgressBarStyle.Blocks;

            switch (uiState)
            {
                case UIState.NotLoggedIn:
                    statusStripText = "Fill in credentials and press \"Log in\"";
                    loginControlsEnabled = true;
                    break;
                case UIState.LoggingIn:
                    statusStripText = "Authenticating with SumUp...";
                    statusStripProgress = ProgressBarStyle.Marquee;
                    logTextBox.Text = string.Empty;
                    break;
                case UIState.PaymentInProgress:
                    statusStripText = "Payment in progress...";
                    statusStripProgress = ProgressBarStyle.Marquee;
                    logTextBox.Text = string.Empty;
                    break;
                case UIState.Idle:
                    statusStripText = "Logged in. Try a payment :)";
                    paymentControlsEnabled = true;
                    break;
                default:
                    break;
            }

            if (!string.IsNullOrEmpty(statusText))
            {
                AppendToLog(statusText);
            }

            statusStripProgressBar.Style = statusStripProgress;

            statusStripStatusLabel.Text = statusStripText;

            clientIdTextBox.ReadOnly = !loginControlsEnabled;
            clientSecretextBox.ReadOnly = !loginControlsEnabled;
            emailTextBox.ReadOnly = !loginControlsEnabled;
            passwordTextBox.ReadOnly = !loginControlsEnabled;
            logInButton.Enabled = loginControlsEnabled;

            PaymentMethodGroup.Enabled = paymentControlsEnabled;
            AmountText.Enabled = paymentControlsEnabled;
            ReferenceText.Enabled = paymentControlsEnabled;
            PayButton.Enabled = paymentControlsEnabled;
            PayButton.Visible = uiState != UIState.PaymentInProgress;
            CancelPaymentButton.Enabled = uiState == UIState.PaymentInProgress;
            CancelPaymentButton.Visible = CancelPaymentButton.Enabled;
        }

        private void PaymentMethod_Changed(object sender, EventArgs e)
        {
            PmntMtdConnectionCombo.Enabled = PmntMtdCardReaderRadio.Enabled && PmntMtdCardReaderRadio.Checked;
        }


        private OperatingSystem _osVersion;
        private void PmntMtdConnection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_osVersion != null || PmntMtdConnectionCombo.SelectedIndex != 0) return;

            _osVersion = System.Environment.OSVersion;

            if (_osVersion.Version.Major == 10
                && _osVersion.Version.Minor == 0
                && _osVersion.Version.Build == 15063)
            {
                string warningText = "It seems that you are running Windows 10 Creators Update.";
                warningText += "Note, that this version has severe issue with Bluetooth LE devices when used on Classic Desktop apps.\r\n\r\n";
                warningText += "If the call to PaymentBuilder.UseBluetoothGattConnectionAsync() never returns, then Creator Update may be the reason.";
                string warningCaption = "SumUp SDK compatibility warning";
                MessageBox.Show(warningText, warningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AppendToLog(string text)
        {
            string txt = $"\r\n" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + $" - {text}";
            if (this.InvokeRequired)
            {
                this.BeginInvoke((Action)(() =>
                {
                    logTextBox.AppendText(txt);
                }));
            }
            else
            {
                logTextBox.AppendText(txt);
            }
        }
        #endregion

        /// arduinostuffs
        ///  private SerialTransport   _serialTransport;
        ///  
        private SerialTransport _serialTransport;
        private CmdMessenger _cmdMessenger;
        private MainForm _controllerForm;

        // Setup function
        public void ArduinoSetup(MainForm controllerForm)
        {
            // storing the controller form for later reference
            _controllerForm = controllerForm;

            // Create Serial Port object
            // Note that for some boards (e.g. Sparkfun Pro Micro) DtrEnable may need to be true.
            _serialTransport = new SerialTransport
            {
                CurrentSerialSettings = { PortName = "COM5", BaudRate = 115200, DtrEnable = false } // object initializer
            };

            // Initialize the command messenger with the Serial Port transport layer
            // Set if it is communicating with a 16- or 32-bit Arduino board
            _cmdMessenger = new CmdMessenger(_serialTransport, BoardType.Bit16);

            // Tell CmdMessenger to "Invoke" commands on the thread running the WinForms UI
            _cmdMessenger.ControlToInvokeOn = _controllerForm;

            // Attach the callbacks to the Command Messenger
            AttachCommandCallBacks();

            // Attach to NewLinesReceived for logging purposes
            _cmdMessenger.NewLineReceived += NewLineReceived;

            // Attach to NewLineSent for logging purposes
            _cmdMessenger.NewLineSent += NewLineSent;

            // Start listening
            _cmdMessenger.Connect();
            
        }

        // Exit function
        public void Exit()
        {
            // Stop listening
            _cmdMessenger.Disconnect();

            // Dispose Command Messenger
            _cmdMessenger.Dispose();

            // Dispose Serial Port object
            _serialTransport.Dispose();
        }

        /// Attach command call backs. 
        private void AttachCommandCallBacks()
        {
            _cmdMessenger.Attach(OnUnknownCommand);
            _cmdMessenger.Attach((int)Command.Acknowledge, OnAcknowledge);
            _cmdMessenger.Attach((int)Command.Error, OnError);
            _cmdMessenger.Attach((int)Command.TestArduino, OnTestArduino);
            _cmdMessenger.Attach((int)Command.TestTap, OnTestTap);
        }

        // ------------------  CALLBACKS ---------------------
        void OnTestArduino(ReceivedCommand arguments)
        {
            //int message = arguments.ReadInt16Arg();
            String message = arguments.ReadStringArg();
            //Console.WriteLine(@"TEST Arduino Received > " + message);
            AppendToLog(@"TEST Arduino Received > " + message);
        }

        void OnTestTap(ReceivedCommand arguments)
        {
            //int message = arguments.ReadInt16Arg();
            String message = arguments.ReadStringArg();
            //Console.WriteLine(@"TEST Tap Received > " + message);
            AppendToLog(@"TEST Tap Received > " + message);

        }
        // Called when a received command has no attached function.
        // In a WinForm application, console output gets routed to the output panel of your IDE


        void OnUnknownCommand(ReceivedCommand arguments)
        {
            Console.WriteLine(@"Command without attached callback received");
        }

        // Callback function that prints that the Arduino has acknowledged
        void OnAcknowledge(ReceivedCommand arguments)
        {
            Console.WriteLine(@" Arduino is ready");
        }

        // Callback function that prints that the Arduino has experienced an error
        void OnError(ReceivedCommand arguments)
        {
            Console.WriteLine(@"Arduino has experienced an error");
        }

        // Log received line to console
        private void NewLineReceived(object sender, CommandEventArgs e)
        {
            Console.WriteLine(@"Received > " + e.Command.CommandString());
        }

        // Log sent line to console
        private void NewLineSent(object sender, CommandEventArgs e)
        {
            Console.WriteLine(@"Sent > " + e.Command.CommandString());
        }

        private void ArduinoTest_click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int value = rand.Next(0, 100);
            var command = new SendCommand((int)Command.TestArduino, value);
            _cmdMessenger.SendCommand(new SendCommand((int)Command.TestArduino, value));
            AppendToLog(@"TEST Arduino Send > " + value);
        }
    }

    internal enum UIState
    {
        NotLoggedIn,
        LoggingIn,
        Idle,
        PaymentInProgress
    }

    internal enum ConnectionMethod
    {
        Audio,
        Bluetooth,
        Usb
    }

    enum Command
    {
        Acknowledge,            // Command to acknowledge a received command
        Error,                  // Command to message that an error has occurred
        TestArduino,
        TestTap,
    };

}