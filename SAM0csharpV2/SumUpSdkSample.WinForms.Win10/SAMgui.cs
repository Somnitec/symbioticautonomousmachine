using SumUp.Sdk;
using SumUp.Sdk.Pay;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumUpSdkSample.WinForms.Win10
{
    public partial class SAMgui : Form, IPaymentProgress
    {
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
        private async Task<PaymentResult> DoSumUpPayment(ulong amountInCents, string reference = null)
        {
            if (_sumUpService == null)
                throw new InvalidOperationException("_sumUpService is not initialized");

            // SumUp.Sdk.PaymentBuilder is used to take in payment info like amount, type of payment (terminal, cash), terminal connection
            PaymentBuilder paymentBuilder = new PaymentBuilder(amountInCents, PaymentMethod.CardReader);

            if (!string.IsNullOrWhiteSpace(reference))
            {
                // PaymentBuilder.TransactionReference is an optional unique reference of the transaction
                paymentBuilder.TransactionReference = reference;
            }

            AppendToLog("-> Setting up reader connection...");
            await paymentBuilder.UseUsbConnectionAsync();
            AppendToLog("   Connection was set up");


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
        public SAMgui()
        {
            InitializeComponent();
            UpdateUI(UIState.NotLoggedIn);


        }



        private async void LogInButton_Click(object sender, EventArgs e)
        {
            UpdateUI(UIState.LoggingIn);

            try
            {
                await CreateSumUpService(clientIdTextBox.Text, clientSecretextBox.Text, emailTextBox.Text, passwordTextBox.Text);
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

            

            string paymentResultText = "Something went wrong!";
            try
            {
                PaymentResult paymentResult = await DoSumUpPayment(amount, ReferenceText.Text);

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
            
            AmountText.Enabled = paymentControlsEnabled;
            ReferenceText.Enabled = paymentControlsEnabled;
            PayButton.Enabled = paymentControlsEnabled;
            PayButton.Visible = uiState != UIState.PaymentInProgress;
            CancelPaymentButton.Enabled = uiState == UIState.PaymentInProgress;
            CancelPaymentButton.Visible = CancelPaymentButton.Enabled;
        }

       


        private OperatingSystem _osVersion;
        private void PmntMtdConnection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_osVersion != null ) return;

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
            string txt = $"{text}\r\n";
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

        private void ReceiptButton_click(object sender, EventArgs e)
        {
            AppendToLog($"pressedbutton receipt!");
        }

        private void ArduinoButton_Click(object sender, EventArgs e)
        {
            AppendToLog($"arduino pressedbutton!");
        }

        private async void Form_load(object sender, EventArgs e)
        {
            try
            {
                await CreateSumUpService(clientIdTextBox.Text, clientSecretextBox.Text, emailTextBox.Text, passwordTextBox.Text);
                UpdateUI(UIState.Idle);

                logTextBox.Text = "Logged in\r\n\r\n\r\n <--- Start a payment on the right";
            }
            catch (Exception ex)
            {
                UpdateUI(UIState.NotLoggedIn, ex.ToString());
            }
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
}
