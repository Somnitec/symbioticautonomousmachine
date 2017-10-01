using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAM0csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_testArduino_click(object sender, EventArgs e)
        {
            AppendToLog("testing Arduino...");
        }

      
        private void Button_testPrint_click(object sender, EventArgs e)
        {
            AppendToLog("testing Print...");
        }

        private void Button_testTap_click(object sender, EventArgs e)
        {
            AppendToLog("testing Tap...");
        }

        private void Button_testPay_click(object sender, EventArgs e)
        {
            AppendToLog("testing Payment...");
        }

        private void AppendToLog(string text)
        {
            string txt = $"\r\n{text}";
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
    }
}
