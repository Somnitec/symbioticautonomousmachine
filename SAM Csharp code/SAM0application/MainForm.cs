using SumUp.Sdk;
using SumUp.Sdk.Pay;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandMessenger;
using CommandMessenger.Queue;
using CommandMessenger.Transport.Serial;
using System.Drawing.Printing;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Security;


namespace SAM4application
{
    public partial class MainForm : Form, IPaymentProgress
    {

        /// <summary>
        /// SUMUP STUFFS
        /// </summary>
        private Random rand = new Random();
        private SumUpService _sumUpService;
        private Tuple<Payment, CancellationTokenSource> _currentPayment;
        private bool realPaymentHappening = false;
        private int price = 111;
        int SAMstate = (int)SAMstates.idle;

        UserInterface userInterface = new UserInterface();

        //password storage stuff, method by https://weblogs.asp.net/jongalloway/encrypting-passwords-in-a-net-app-config-file
        static byte[] entropy = System.Text.Encoding.Unicode.GetBytes("This is the future");

        public static string EncryptString(System.Security.SecureString input)
        {
            byte[] encryptedData = System.Security.Cryptography.ProtectedData.Protect(
                System.Text.Encoding.Unicode.GetBytes(ToInsecureString(input)),
                entropy,
                System.Security.Cryptography.DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        public static SecureString DecryptString(string encryptedData)
        {
            try
            {
                byte[] decryptedData = System.Security.Cryptography.ProtectedData.Unprotect(
                    Convert.FromBase64String(encryptedData),
                    entropy,
                    System.Security.Cryptography.DataProtectionScope.CurrentUser);
                return ToSecureString(System.Text.Encoding.Unicode.GetString(decryptedData));
            }
            catch
            {
                return new SecureString();
            }
        }

        public static SecureString ToSecureString(string input)
        {
            SecureString secure = new SecureString();
            foreach (char c in input)
            {
                secure.AppendChar(c);
            }
            secure.MakeReadOnly();
            return secure;
        }

        public static string ToInsecureString(SecureString input)
        {
            string returnValue = string.Empty;
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
            return returnValue;
        }


        public bool IsAvailable { get; set; }

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

            //throw new NotImplementedException();
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
            NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;
            UpdateUI(UIState.NotLoggedIn);
            ArduinoSetup(this);
            //CreateSumUpService("yVDoUpXUZMJj_joXuQP2TEPHXdwX", "586d98472b564dd87120f9af9f3d3bca9c960a8078c0c0670c0f2122fa864a98", "arvidandmarie@sumup.com", "extdev");
            Console.WriteLine(@"mainform() finished");


        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

            Console.WriteLine(IsAvailable);
            logInButton.PerformClick();
            Console.WriteLine(@"mainform loaded");
            ArduinoSetup();

            userInterface.Show();
            userInterface.FormBorderStyle = FormBorderStyle.None;
            userInterface.WindowState = FormWindowState.Maximized;
            userInterface.Activate();

            Cursor.Hide();

            //encrypt password easily like this
            Console.WriteLine(EncryptString(ToSecureString("password")));
            Console.WriteLine(ToInsecureString(DecryptString(  EncryptString(ToSecureString("password"))    )));
            
        }

        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            IsAvailable = e.IsAvailable;
        }

        private void ArduinoSetup()
        {
            //for some reason the first command does not get picked up
            var command = new SendCommand((int)Command.Acknowledge);
            _cmdMessenger.SendCommand(new SendCommand((int)Command.Acknowledge));

            command = new SendCommand((int)Command.Acknowledge);
            _cmdMessenger.SendCommand(new SendCommand((int)Command.Acknowledge));


            //the led settings
            command = new SendCommand((int)Command.SetLedBreathMax, LedBreathMaxNumericUpDown.Value.ToString());
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));

            command = new SendCommand((int)Command.SetLedBreathMin, LedBreathMinNumericUpDown.Value.ToString());
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));

            float value = float.Parse(LedBreathSpeedNumericUpDown.Value.ToString());
            command = new SendCommand((int)Command.SetLedBreathSpeed, value);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
            AppendToLog($"led settings set if there is three lines below here ");

            SAMstate = (int)SAMstates.idle;
            command = new SendCommand((int)Command.SetLedState, SAMstate);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
            userInterface._changeInterface = (int)SAMstate;
        }

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            UpdateUI(UIState.LoggingIn);

            try
            {
                //devmode (fake paayments)
                /*
                await CreateSumUpService("yVDoUpXUZMJj_joXuQP2TEPHXdwX", "586d98472b564dd87120f9af9f3d3bca9c960a8078c0c0670c0f2122fa864a98",
                ToInsecureString(DecryptString("AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAbPvYWR5YlUiVYL6f0m5CxAAAAAACAAAAAAAQZgAAAAEAACAAAADfHdR7AXIoy61QYYZgS/vUxtsMylaJCrz7zjhfzPZSewAAAAAOgAAAAAIAACAAAACzdb7Z09j6/lcACCsfLKecuukIf2BtcZhJXeOVS3Np/zAAAACQNqDp7BM/+CrfP1wwUjhf1MNOKZt9G73OdJ+2iJNyjSA1M27WeKutZzHPonLlkKpAAAAAnGi4r7tWgT/6w/85THgT1hIYhfdZ2mBMr1FE9OCa9/VrGRSJ27uAth9R0UnFIW4FZzop2appggHFnhc4lCimyw==")),//user
                    ToInsecureString(DecryptString("AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAbPvYWR5YlUiVYL6f0m5CxAAAAAACAAAAAAAQZgAAAAEAACAAAADrz0sHMLzW88jn+YB4ehhxe5izenGL9IS2PSQck1BClgAAAAAOgAAAAAIAACAAAAARZjKTXKIG1qs11gwtSqLh70oMEng2usIx0uR0Qf3zdxAAAACoHPhj3jSwIek8xIDR7kejQAAAANOWaFbr1M58mcigk3488mSbjgQAZyyuaf5fyaKr0BouWt6RbVErtTBpLxEvDWAoXsenBafZRKr7xJcfg2pfz1c=")));//password
                    */
                //real payments
                await CreateSumUpService("2RgkKPeVbg89OvmDTlWt-QFYPycl", "5a23e86c3012f12f91df35f4cb876e167cecac6e78f29926c9a084fc25e3243c",
                    ToInsecureString(DecryptString("AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAbPvYWR5YlUiVYL6f0m5CxAAAAAACAAAAAAAQZgAAAAEAACAAAABxPGQ6Pv1tUtDb3cnlrsaaADQkSsPP56uKVmHFCgYqWwAAAAAOgAAAAAIAACAAAACbFgpJSyp+aGjsWIiZuDQlqoYx2DglM6wvC+AhL3YrMDAAAADS5CwMUjJeBL50wdXgpyfxqVGZzGHZJ5mcbRgZ+mvOs9B3YtahV4b9p3JBGrkt6uFAAAAAA2/dznMs9zah0OpIv90RhUCtLlOaajpsBVvmbOC0SckfJ/DBkaWECYXmeHBh7eejE1bFHEEhyxv+vxL5edE98w==")), //user
                    ToInsecureString(DecryptString("AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAbPvYWR5YlUiVYL6f0m5CxAAAAAACAAAAAAAQZgAAAAEAACAAAAD4drCESJd3sTf2jyMP4daSlhbPt9vzJOcb69bxMLujDwAAAAAOgAAAAAIAACAAAADQYzqelqZaDbAxSxp7EGP1ixwOSgWI7m/cZ+55ZpRLuSAAAABDBp5t8/AzC/8FLIrPY46+fyyLd3Rmn9UzSuaiP4dtk0AAAAAqorYe1rLdCHuPlyi8CcgYANYVHwPFS8rXQ2kBrk2TGYPGmppNvlp7YU5Bhrm9JHwkpw9kYkwzwgihKiT7+smJ")));//password

                UpdateUI(UIState.Idle);

                AppendToLog("Logged in");
            }
            catch (Exception ex)
            {

                UpdateUI(UIState.NotLoggedIn, ex.ToString());
                AppendToLog("not Logged in");
                logInButton.PerformClick();
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

            PaymentMethod method = PaymentMethod.CardReader;

            ConnectionMethod connection = ConnectionMethod.Usb;

            string paymentResultText = "Something went wrong!";
            string paymentResultShort = "Something went wrong";
            try
            {
                Properties.Settings.Default.ReceiptNo++;
                ReceiptNoNumericUpDown.Update();
                Properties.Settings.Default.Save();
                PaymentResult paymentResult = await DoSumUpPayment(amount, method, connection, "SAM's Komboucha Soda No " + Properties.Settings.Default.ReceiptNo + " at " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()); //, "SAM's Kefir Soda at " + DateTime.Now.ToShortTimeString() //can do, but will need to be unique every time
                paymentResultShort = string.Format("{0}", paymentResult.Status);

                paymentResultText = string.Format(
                    "=== PAYMENT RESULT ===\r\n    Status: {0}\r\n    Transaction code: {1}\r\n    Transaction reference: {2}\r\n    Message: {3}\r\n    Message explanation: {4}",
                    paymentResult.Status,
                    paymentResult.TransactionCode,
                    paymentResult.TransactionReference,
                    paymentResult.Message,
                    paymentResult.MessageExplanation);

                //if (realPaymentHappening)
                //{
                //    AppendToLog(@"Payment succeeded, now tapping");
                //    realPaymentHappening = false;
                //    var command = new SendCommand((int)Command.TapAmount, Properties.Settings.Default.TapAmount);
                //    _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
                //}

                //else AppendToLog(@"TestPayment succeeded not tapping");
            }
            catch (Exception ex)
            {
                paymentResultText = ex.ToString();
                //if (realPaymentHappening)
                //{
                //    AppendToLog(@"Payment failed, reset");
                //    var command = new SendCommand((int)Command.Reset);
                //    _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
                //}

                //else AppendToLog(@"TestPayment failed, was just a test");
            }
            finally
            {

                _currentPayment = null;
                UpdateUI(UIState.Idle, paymentResultText);

                if (realPaymentHappening)
                {
                    //AppendToLog(paymentResultShort);
                    if (paymentResultShort.Equals("Successful"))
                    {
                        AppendToLog("payment was successfull, printing receipt!");
                        PrintReceipt();
                        AppendToLog(@"finished printing, now tapping");

                        // var command = new SendCommand((int)Command.TapAmount, Properties.Settings.Default.TapAmount);
                        var command = new SendCommand((int)Command.PumpTapMilliseconds, (int)Properties.Settings.Default.tapMilliseconds);

                        _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));

                        SAMstate = (int)SAMstates.waitingForTapping;
                        command = new SendCommand((int)Command.SetLedState, SAMstate);
                        _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
                        userInterface._changeInterface = (int)SAMstate;
                    }
                    else
                    {
                        AppendToLog("payment was not successfull, resetting");

                        SAMstate = (int)SAMstates.error;
                        var command = new SendCommand((int)Command.SetLedState, SAMstate);
                        _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
                        userInterface._changeInterface = (int)SAMstate;
                        Reset();
                    }

                    realPaymentHappening = false;
                }
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
                    //logTextBox.Text = string.Empty;
                    break;
                case UIState.PaymentInProgress:
                    statusStripText = "Payment in progress...";
                    statusStripProgress = ProgressBarStyle.Marquee;
                    //logTextBox.Text = string.Empty;
                    break;
                case UIState.Idle:
                    statusStripText = "Logged in.";
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


            logInButton.Enabled = loginControlsEnabled;

            AmountText.Enabled = paymentControlsEnabled;
            PayButton.Enabled = paymentControlsEnabled;
            PayButton.Visible = uiState != UIState.PaymentInProgress;
            CancelPaymentButton.Enabled = uiState == UIState.PaymentInProgress;
            CancelPaymentButton.Visible = CancelPaymentButton.Enabled;
        }




        private OperatingSystem _osVersion;
        private void PmntMtdConnection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_osVersion != null) return;

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
                CurrentSerialSettings = { PortName = Properties.Settings.Default.ArduinoPort, BaudRate = 115200, DtrEnable = true } // object initializer
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
            _cmdMessenger.Attach((int)Command.SodaButtonPressed, OnSodaButtonPressed);
            _cmdMessenger.Attach((int)Command.GrainButtonPressed, OnGrainButtonPressed);
            _cmdMessenger.Attach((int)Command.Reset, OnReset);
            _cmdMessenger.Attach((int)Command.TapSucceeded, OnTapSucceeded);
            _cmdMessenger.Attach((int)Command.PumpTap, OnPumpTap);



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
            AppendToLog(@"TEST Tap for mL > " + message);

        }

        void OnPumpTap(ReceivedCommand arguments)
        {
            //int message = arguments.ReadInt16Arg();
            String message = arguments.ReadStringArg();
            //Console.WriteLine(@"TEST Tap Received > " + message);
            AppendToLog(@"Tap turned to > " + message);

        }

        public void startClick(){
            FakeSodaButton.PerformClick();
            }

       public static void     pumpClick()
        {

        }

        public void OnSodaButtonPressed(ReceivedCommand arguments)
        {

            
        }

        private void makePayment()
        {

            price = rand.Next((int)(Properties.Settings.Default.MinPrice * 100.0m), (int)(Properties.Settings.Default.MaxPrice * 100.0m));
            Properties.Settings.Default.ReceiptNo++;
            ReceiptNoNumericUpDown.Update();
            userInterface._setPrice = price;
            AppendToLog(@"Starting payment for €" + price / 100f+" and receipt no "+ Properties.Settings.Default.ReceiptNo);
            AmountText.Text = price.ToString();
            realPaymentHappening = true;
            PayButton.PerformClick();
        }

        void OnGrainButtonPressed(ReceivedCommand arguments)
        {

            AppendToLog(@"Grain button pressed");//now only blinks itself
            //var command = new SendCommand((int)Command.SetLedState,2);
            //_cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
            // command = new SendCommand((int)Command.SetLedState,0);
            //_cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
            
            /*
            if (!realPaymentHappening)
            {
                var command = new SendCommand((int)Command.Reset);
                _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
            }
            else AppendToLog(@"not resetting, because payment is in progress!");
            */

        }

        void OnTapSucceeded(ReceivedCommand arguments)
        {
            AppendToLog(@"Tap succeeded");
            Reset();
        }

        void OnReset(ReceivedCommand arguments)
        {
            Reset();
        }

        void Reset()
        {
            //CancelPaymentButton.PerformClick();
            realPaymentHappening = false;
            AppendToLog(@"Resetted");
            
            SAMstate = (int)SAMstates.idle;
            var command = new SendCommand((int)Command.SetLedState, SAMstate);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
            userInterface._changeInterface = (int)SAMstate;
        }
        // Called when a received command has no attached function.
        // In a WinForm application, console output gets routed to the output panel of your IDE


        void OnUnknownCommand(ReceivedCommand arguments)
        {
            Console.WriteLine(@"Command without attached callback received");
            String message = arguments.ReadStringArg();
            //Console.WriteLine(@"TEST Tap Received > " + message);
            AppendToLog(@"Command without attached callback received > " + message);
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

            int value = rand.Next(0, 100);
            var command = new SendCommand((int)Command.TestArduino, value);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
            AppendToLog(@"Arduino value send > " + value);
        }

        private void PrintTest_click(object sender, EventArgs e)
        {
            
            AppendToLog(@"test printing receipt "+ Properties.Settings.Default.ReceiptNo);

            PrintReceipt();
        }

  

        private void PrintReceipt()
        {
            if (PrintingCheckBox.Checked) {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintReceiptOnPrintPage;
                printDocument.Print();
            }
            
        }

        private void PrintReceiptOnPrintPage(object sender, PrintPageEventArgs e)
        {
            int rightpoint = 330;
            int leftpoint = 250;
            int centerpoint = 250;

            int fontsize = 9;
            int linedistance = (int)(2.1 * fontsize);
            Font MainFont = new Font("roboto", fontsize);
            Font ItalicFont = new Font("roboto", (int)(fontsize * 0.6),FontStyle.Italic);
            Font BigFont = new Font("roboto", fontsize, FontStyle.Bold);
            Pen linePen = new Pen(Brushes.Black, 1);
            Pen noPen = new Pen(Brushes.White, 1);
            StringFormat formatCenter = new StringFormat();
            formatCenter.Alignment = StringAlignment.Center;
            StringFormat formatRight = new StringFormat();
            formatRight.Alignment = StringAlignment.Far;

            e.Graphics.RotateTransform(-180.0f);
            e.Graphics.TranslateTransform(-rightpoint, -450);

            e.Graphics.DrawLine(linePen, 0, (int)(linedistance * -1), 500, (int)(linedistance * -1));

            e.Graphics.DrawString("SAM", BigFont, Brushes.Black, centerpoint, linedistance * 1, formatCenter);
            e.Graphics.DrawString("Symbiotic Autonomous Machine", BigFont, Brushes.Black, centerpoint, linedistance * 2, formatCenter);

            e.Graphics.DrawLine(linePen, 0, (int)(linedistance * 3.5), 500, (int)(linedistance * 3.5));

            var rect = new RectangleF(0 + leftpoint, linedistance * 4, rightpoint, linedistance);
            e.Graphics.DrawString("receipt No " + Properties.Settings.Default.ReceiptNo+"    "+ DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), ItalicFont, Brushes.Black, rect);
    
            float realPrice = price / 100f;
            float taxPrice = realPrice * 0.06f;
            float exclPrice = realPrice - taxPrice;
            AppendToLog(@"printing receipt " + exclPrice.ToString("€0.## + ") + taxPrice.ToString("€0.## =") + realPrice.ToString("€0.##"));
            rect = new RectangleF(0+leftpoint, linedistance * 6, rightpoint, linedistance);
            e.Graphics.DrawString(exclPrice.ToString("€0.##")+ "     Cup SAM's kombucha", MainFont, Brushes.Black, rect);
            //e.Graphics.DrawString(exclPrice.ToString("€0.##"), MainFont, Brushes.Black, rect, formatRight);
            rect = new RectangleF(0 + leftpoint, linedistance * 7, rightpoint, linedistance);
            e.Graphics.DrawString(taxPrice.ToString("€0.##")+"     VAT 9% (NL)", MainFont, Brushes.Black, rect);
            //e.Graphics.DrawString(taxPrice.ToString("€0.##"), MainFont, Brushes.Black, rect, formatRight);
            rect = new RectangleF(0 + leftpoint, linedistance * 9, rightpoint, linedistance);
            e.Graphics.DrawString(realPrice.ToString("€0.##")+"     Total", MainFont, Brushes.Black, rect);
            //e.Graphics.DrawString(realPrice.ToString("€0.##"), MainFont, Brushes.Black, rect, formatRight);

            e.Graphics.DrawLine(linePen, 0, (int)(linedistance * 11), 500, (int)(linedistance * 11));

            String firstLine = "";
            String secondLine = "";
            switch (rand.Next(4))
            {
                case 0:
                    firstLine = "Thanks for keeping me alive";
                    secondLine = "and functioning!";
                    break;
                case 1:
                    firstLine = "Towards a collaborative future";
                    secondLine = "for man and machine.";
                    break;
                case 2:
                    firstLine = "One small sip for man.";
                    secondLine = "One giant sip for machinekind";
                    break;
                case 3:
                    firstLine = "Taking life";
                    secondLine = "sip by sip.";
                    break;
                case 4:
                    firstLine = "Cheers to contributing ";
                    secondLine = "towards my freedom.";
                    break;
            }
            e.Graphics.DrawString(firstLine, BigFont, Brushes.Black, centerpoint, linedistance * 15, formatCenter);
            e.Graphics.DrawString(secondLine, BigFont, Brushes.Black, centerpoint, linedistance * 16, formatCenter);



            e.Graphics.DrawString("Rate your soda out of 5", MainFont, Brushes.Black, centerpoint, linedistance * 12, formatCenter);
            e.Graphics.DrawString("on twitter @nonhumanSAM", MainFont, Brushes.Black, centerpoint, linedistance * 13, formatCenter);
            e.Graphics.DrawString(firstLine, BigFont, Brushes.Black, centerpoint, linedistance * 15, formatCenter);
            e.Graphics.DrawString(secondLine, BigFont, Brushes.Black, centerpoint, linedistance * 16, formatCenter);
            //e.Graphics.DrawString("web: sam.nonhuman.club", ItalicFont, Brushes.Black, centerpoint, linedistance * 18, formatCenter);
            //e.Graphics.DrawString("email: sam@nonhuman.club", ItalicFont, Brushes.Black, centerpoint, (int)(linedistance * 18.5), formatCenter);
            e.Graphics.DrawString("towards a collaborative future", ItalicFont, Brushes.Black, centerpoint, (int)(linedistance * 19.5), formatCenter);
            e.Graphics.DrawString("for man and machine", ItalicFont, Brushes.Black, centerpoint, linedistance * 20, formatCenter);

            e.Graphics.DrawString("a project by", MainFont, Brushes.Black, centerpoint, (int)(linedistance * 21.5), formatCenter);
            e.Graphics.DrawString("www.arvidandmarie.com", MainFont, Brushes.Black, centerpoint, (int)(linedistance * 22.5), formatCenter);

        }
        private void TapTest_click(object sender, EventArgs e)
        {
            var command = new SendCommand((int)Command.TestTap, (int)Properties.Settings.Default.TestTapAmount);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
            AppendToLog(@"testing tap with " + (int)Properties.Settings.Default.TestTapAmount + "mL");
        }



        private void SaveSettingsButton_click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            AppendToLog(@"Saving settings!");
        }

        private void ledTestCheckBox_click(object sender, EventArgs e)
        {
            var command = new SendCommand((int)Command.TestLeds, ledTestCheckBox.Checked);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
        }

        private void PumpTapTestCheckbox_Click(object sender, EventArgs e)
        {
            var command = new SendCommand((int)Command.PumpTap, PumpTapTestCheckbox.Checked);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
        }

        private void FakeSodaButton_Click(object sender, EventArgs e)
        {
            AppendToLog(@"Soda button pressed");
            SAMstate = (int)SAMstates.waitingForPayment;
            var command = new SendCommand((int)Command.SetLedState, SAMstate);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
            userInterface._changeInterface = (int)SAMstate;
            makePayment();
        }

        private void FakeGrainButton_Click(object sender, EventArgs e)
        {
            var command = new SendCommand((int)Command.GrainButtonPressed);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
        }

        private void arduinoConnectCheckBox_Click(object sender, EventArgs e)
        {

            if (arduinoConnectCheckBox.Checked == true)
            {
                _cmdMessenger.Connect();

                AppendToLog(@"connecting Arduino");
            }
            else
            {
                _cmdMessenger.Disconnect();
                AppendToLog(@"disconnecting Arduino");
            }
        }



        private void LedBreathMaxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var command = new SendCommand((int)Command.SetLedBreathMax, LedBreathMaxNumericUpDown.Value.ToString());
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
        }

        private void LedBreathMinNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var command = new SendCommand((int)Command.SetLedBreathMin, LedBreathMinNumericUpDown.Value.ToString());
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
        }

        private void LedBreathSpeedNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            float value = float.Parse(LedBreathSpeedNumericUpDown.Value.ToString());
            var command = new SendCommand((int)Command.SetLedBreathSpeed, value);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
        }

        private void ledStateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
            var command = new SendCommand((int)Command.SetLedState, ledStateNumericUpDown.Value.ToString());
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
        }

        private void interfaceStateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
            userInterface._changeInterface = (int)interfaceStateNumericUpDown.Value;
        }

        private void tapMillisecondsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void testTapMsButton_Click(object sender, EventArgs e)
        {
            var command = new SendCommand((int)Command.PumpTapMilliseconds, (int)Properties.Settings.Default.tapMilliseconds);
            AppendToLog(@"tapping now for ms-> "+ (int)Properties.Settings.Default.tapMilliseconds);
            _cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));

        }

        private void InternetButton_Click(object sender, EventArgs e)
        {
            AppendToLog(@"internet " + IsAvailable);
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
        Reset,
        TestArduino,
        TestTap,
        TestLeds,
        PumpTap,
        SodaButtonPressed,
        GrainButtonPressed,
        TapAmount,
        TapSucceeded,
        SetLedState,
        SetLedBreathSpeed,
        SetLedBreathMax,
        SetLedBreathMin,
        PumpTapMilliseconds,
    };

    internal enum SAMstates
    {
        idle,
        waitingForPayment,
        waitingForTapping,
        error,
        testing,
    };


}
