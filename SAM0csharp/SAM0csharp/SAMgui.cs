using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandMessenger;
using CommandMessenger.Queue;
using CommandMessenger.Transport.Serial;
using SumUp.Sdk;
using SumUp.Sdk.Pay;

namespace SAM0csharp
{
    public partial class SAMgui : Form, IPaymentProgress
    {

        /// guistuff


        public SAMgui()
        {
            InitializeComponent();
            ArduinoSetup();
            AppendToLog("setup most things...");
        }

        private async void Form_load(object sender, EventArgs e)
        {
            AppendToLog("sumup attempting to log in...");
            try
            {
                await CreateSumUpService("yVDoUpXUZMJj_joXuQP2TEPHXdwX", "586d98472b564dd87120f9af9f3d3bca9c960a8078c0c0670c0f2122fa864a98", "arvidandmarie@sumup.com", "extdev");

                AppendToLog("sumup logged in...");
                logTextBox.Text = "Logged in\r\n\r\n\r\n <--- Start a payment on the right";
            }
            catch (Exception ex)
            {
                AppendToLog("not logged in");
            }
        }
        private void Button_testArduino_click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            AppendToLog("testing Arduino..." + randomNumber);
            var command = new SendCommand((int)Command.TestArduino, randomNumber);

            cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
        }


        private void Button_testPrint_click(object sender, EventArgs e)
        {
            AppendToLog("testing Print...");
        }

        private void Button_testTap_click(object sender, EventArgs e)
        {
            AppendToLog("testing Tap...");
            var command = new SendCommand((int)Command.TestTap, 2);

            cmdMessenger.QueueCommand(new CollapseCommandStrategy(command));
        }

        private void Button_testPay_click(object sender, EventArgs e)
        {
            AppendToLog("testing Payment...");
        }

        private void AppendToLog(string text)
        {
            string txt = $"\r\n" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + $" - {text}";

            logTextBox.AppendText(txt);

        }

        /// 
        /////Serial stuff
        ///

        enum Command
        {
            Acknowledge,            // Command to acknowledge a received command
            Error,                  // Command to message that an error has occurred
            TestArduino,
            TestTap,
        };
        private SerialTransport serialTransport;
        private CmdMessenger cmdMessenger;
        public void ArduinoSetup()
        {
            serialTransport = new SerialTransport
            {
                CurrentSerialSettings = { PortName = "COM5", BaudRate = 115200, DtrEnable = false } // object initializer
            };

            cmdMessenger = new CmdMessenger(serialTransport, BoardType.Bit16);
            AttachCommandCallBacks();
            cmdMessenger.NewLineReceived += NewLineReceived;
            cmdMessenger.NewLineSent += NewLineSent;
            cmdMessenger.Connect();

        }
        public void Exit()
        {
            // Stop listening
            cmdMessenger.Disconnect();

            // Dispose Command Messenger
            cmdMessenger.Dispose();

            // Dispose Serial Port object
            serialTransport.Dispose();
        }
        private void AttachCommandCallBacks()
        {
            cmdMessenger.Attach(OnUnknownCommand);
            cmdMessenger.Attach((int)Command.Acknowledge, OnAcknowledge);
            cmdMessenger.Attach((int)Command.Error, OnError);
            cmdMessenger.Attach((int)Command.TestArduino, OnTestArduino);
            cmdMessenger.Attach((int)Command.TestTap, OnTestTap);
        }

        // ------------------  CALLBACKS ---------------------
        async void OnTestArduino(ReceivedCommand arguments)
        {
            //int message = arguments.ReadInt16Arg
            String message = arguments.ReadStringArg();
            Console.WriteLine(@"TEST Arduino Received > " + message);
            AppendToLog(@"TEST Arduino Received > " + message);
        }

        void OnTestTap(ReceivedCommand arguments)
        {
            String message = arguments.ReadStringArg();
            Console.WriteLine(@"TEST Tap Received > " + message);
            AppendToLog(@"TEST Tap Received > " + message);
        }


        void OnUnknownCommand(ReceivedCommand arguments)
        {
            Console.WriteLine(@"Command without attached callback received");
            AppendToLog(@"Command without attached callback received");
        }

        // Callback function that prints that the Arduino has acknowledged
        void OnAcknowledge(ReceivedCommand arguments)
        {
            Console.WriteLine(@" Arduino is ready");
            AppendToLog(@" Arduino is ready");
        }

        // Callback function that prints that the Arduino has experienced an error
        void OnError(ReceivedCommand arguments)
        {
            Console.WriteLine(@"Arduino has experienced an error");
            AppendToLog(@"Arduino has experienced an error");
        }

        // Log received line to console
        private void NewLineReceived(object sender, CommandEventArgs e)
        {
            Console.WriteLine(@"Received > " + e.Command.CommandString());
            //AppendToLog(@"Received > " + e.Command.CommandString());
        }

        // Log sent line to console
        private void NewLineSent(object sender, CommandEventArgs e)
        {
            Console.WriteLine(@"Sent > " + e.Command.CommandString());
            //AppendToLog(@"Sent > " + e.Command.CommandString());
        }

        ///
        ////////SUMUP stuff
        ///
        private SumUpService _sumUpService;
        private Tuple<Payment, CancellationTokenSource> _currentPayment;

        private async Task CreateSumUpService(string clientId, string clientSecret, string email, string password)
        {
            OAuthCredentials credentials = new OAuthCredentials(clientId, clientSecret, email, password);
            _sumUpService = await SumUpService.CreateInstanceAsync(credentials);
        }

        private async Task<PaymentResult> DoSumUpPayment(ulong amountInCents, PaymentMethod method, string reference = null)
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

                await paymentBuilder.UseUsbConnectionAsync();

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
    }
}
