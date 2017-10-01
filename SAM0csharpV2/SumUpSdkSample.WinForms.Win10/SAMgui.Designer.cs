namespace SumUpSdkSample.WinForms.Win10
{
    partial class SAMgui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.clientSecretextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ReferenceText = new System.Windows.Forms.TextBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.PayButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelPaymentButton = new System.Windows.Forms.Button();
            this.ReceiptButton = new System.Windows.Forms.Button();
            this.AmountButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ArduinoButton = new System.Windows.Forms.Button();
            this.TapButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.helpProvider.SetHelpString(this.label6, "Password of a registered SumUp account");
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.helpProvider.SetShowHelp(this.label6, true);
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.helpProvider.SetHelpString(this.label5, "E-mail of a registered SumUp account");
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.helpProvider.SetShowHelp(this.label5, true);
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-mail";
            // 
            // passwordTextBox
            // 
            this.helpProvider.SetHelpString(this.passwordTextBox, "Password of a registered SumUp account");
            this.passwordTextBox.Location = new System.Drawing.Point(84, 46);
            this.passwordTextBox.Name = "passwordTextBox";
            this.helpProvider.SetShowHelp(this.passwordTextBox, true);
            this.passwordTextBox.Size = new System.Drawing.Size(150, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Text = "extdev";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            this.helpProvider.SetHelpString(this.emailTextBox, "E-mail of a registered SumUp account");
            this.emailTextBox.Location = new System.Drawing.Point(84, 20);
            this.emailTextBox.Name = "emailTextBox";
            this.helpProvider.SetShowHelp(this.emailTextBox, true);
            this.emailTextBox.Size = new System.Drawing.Size(150, 20);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.Text = "arvidandmarie@sumup.com";
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInButton.Location = new System.Drawing.Point(505, 51);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(102, 35);
            this.logInButton.TabIndex = 8;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Payment";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(595, 1);
            this.panel4.TabIndex = 8;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripProgressBar,
            this.statusStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 487);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(619, 22);
            this.statusStrip.TabIndex = 9;
            // 
            // statusStripProgressBar
            // 
            this.statusStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusStripProgressBar.Name = "statusStripProgressBar";
            this.statusStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.statusStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // statusStripStatusLabel
            // 
            this.statusStripStatusLabel.Name = "statusStripStatusLabel";
            this.statusStripStatusLabel.Size = new System.Drawing.Size(502, 17);
            this.statusStripStatusLabel.Spring = true;
            this.statusStripStatusLabel.Text = "Status text";
            this.statusStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientIdTextBox
            // 
            this.helpProvider.SetHelpString(this.clientIdTextBox, "Client ID can be generated from the OAuth section at https://me.sumup.com/develop" +
        "ers");
            this.clientIdTextBox.Location = new System.Drawing.Point(79, 20);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.helpProvider.SetShowHelp(this.clientIdTextBox, true);
            this.clientIdTextBox.Size = new System.Drawing.Size(150, 20);
            this.clientIdTextBox.TabIndex = 4;
            this.clientIdTextBox.Text = "yVDoUpXUZMJj_joXuQP2TEPHXdwX";
            // 
            // clientSecretextBox
            // 
            this.helpProvider.SetHelpString(this.clientSecretextBox, "Client Secret can be generated from the OAuth section at https://me.sumup.com/dev" +
        "elopers");
            this.clientSecretextBox.Location = new System.Drawing.Point(79, 46);
            this.clientSecretextBox.Name = "clientSecretextBox";
            this.helpProvider.SetShowHelp(this.clientSecretextBox, true);
            this.clientSecretextBox.Size = new System.Drawing.Size(150, 20);
            this.clientSecretextBox.TabIndex = 5;
            this.clientSecretextBox.Text = "586d98472b564dd87120f9af9f3d3bca9c960a8078c0c0670c0f2122fa864a98";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.helpProvider.SetHelpString(this.label3, "Client ID can be generated from the OAuth section at https://me.sumup.com/develop" +
        "ers");
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.helpProvider.SetShowHelp(this.label3, true);
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.helpProvider.SetHelpString(this.label4, "Client Secret can be generated from the OAuth section at https://me.sumup.com/dev" +
        "elopers");
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.helpProvider.SetShowHelp(this.label4, true);
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client Secret";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clientIdTextBox);
            this.groupBox1.Controls.Add(this.clientSecretextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Credentials";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Location = new System.Drawing.Point(259, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 74);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Credentials";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "2. Amount (in cents):";
            // 
            // AmountText
            // 
            this.AmountText.Location = new System.Drawing.Point(22, 148);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(101, 20);
            this.AmountText.TabIndex = 12;
            this.AmountText.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "3. (Optional) Reference";
            // 
            // ReferenceText
            // 
            this.ReferenceText.Location = new System.Drawing.Point(129, 148);
            this.ReferenceText.Name = "ReferenceText";
            this.ReferenceText.Size = new System.Drawing.Size(124, 20);
            this.ReferenceText.TabIndex = 13;
            this.ReferenceText.Text = "SAM\'s kefir soda";
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayButton.Location = new System.Drawing.Point(12, 182);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(241, 35);
            this.PayButton.TabIndex = 14;
            this.PayButton.Text = "Make a payment";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.DoPaymentButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(259, 136);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(347, 337);
            this.logTextBox.TabIndex = 24;
            this.logTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(265, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Log";
            // 
            // CancelPaymentButton
            // 
            this.CancelPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelPaymentButton.Location = new System.Drawing.Point(12, 275);
            this.CancelPaymentButton.Name = "CancelPaymentButton";
            this.CancelPaymentButton.Size = new System.Drawing.Size(241, 35);
            this.CancelPaymentButton.TabIndex = 27;
            this.CancelPaymentButton.Text = "Cancel payment";
            this.CancelPaymentButton.UseVisualStyleBackColor = true;
            this.CancelPaymentButton.Click += new System.EventHandler(this.CancelPaymentButton_Click);
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.Location = new System.Drawing.Point(13, 316);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(75, 23);
            this.ReceiptButton.TabIndex = 28;
            this.ReceiptButton.Text = "receipt test";
            this.ReceiptButton.UseVisualStyleBackColor = true;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_click);
            // 
            // AmountButton
            // 
            this.AmountButton.Location = new System.Drawing.Point(15, 344);
            this.AmountButton.Name = "AmountButton";
            this.AmountButton.Size = new System.Drawing.Size(75, 23);
            this.AmountButton.TabIndex = 28;
            this.AmountButton.Text = "set ml";
            this.AmountButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 346);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 13;
            // 
            // ArduinoButton
            // 
            this.ArduinoButton.Location = new System.Drawing.Point(15, 401);
            this.ArduinoButton.Name = "ArduinoButton";
            this.ArduinoButton.Size = new System.Drawing.Size(75, 23);
            this.ArduinoButton.TabIndex = 28;
            this.ArduinoButton.Text = "arduinotest";
            this.ArduinoButton.UseVisualStyleBackColor = true;
            this.ArduinoButton.Click += new System.EventHandler(this.ArduinoButton_Click);
            // 
            // TapButton
            // 
            this.TapButton.Location = new System.Drawing.Point(15, 372);
            this.TapButton.Name = "TapButton";
            this.TapButton.Size = new System.Drawing.Size(75, 23);
            this.TapButton.TabIndex = 28;
            this.TapButton.Text = "tap test";
            this.TapButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(15, 430);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 28;
            this.ResetButton.Text = "reset system";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(115, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "SAM0 system";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(115, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "by Arvid and Marie";
            // 
            // SAMgui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 509);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TapButton);
            this.Controls.Add(this.AmountButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ArduinoButton);
            this.Controls.Add(this.ReceiptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ReferenceText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.CancelPaymentButton);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(635, 385);
            this.Name = "SAMgui";
            this.Text = "SumUp SDK Sample - Windows Forms / Windows 10";
            this.Load += new System.EventHandler(this.Form_load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar statusStripProgressBar;
        private System.Windows.Forms.TextBox clientIdTextBox;
        private System.Windows.Forms.TextBox clientSecretextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ReferenceText;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelPaymentButton;
        private System.Windows.Forms.Button ReceiptButton;
        private System.Windows.Forms.Button AmountButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ArduinoButton;
        private System.Windows.Forms.Button TapButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

