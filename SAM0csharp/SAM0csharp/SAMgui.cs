using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandMessenger;
using CommandMessenger.Queue;
using CommandMessenger.Transport.Serial;

namespace SAM0csharp
{
    public partial class SAMgui : Form
    {

        /// guistuff


        public SAMgui()
        {
            InitializeComponent();
            ArduinoSetup();
        }

        private void Button_testArduino_click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            AppendToLog("testing Arduino..."+ randomNumber);
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

        /////Serial stuff

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
        void OnTestArduino(ReceivedCommand arguments)
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

    }
}
