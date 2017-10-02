namespace SumUpSdkSample.WinForms.Win10
{
    partial class MainForm
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
            this.PmntMtdCardReaderRadio = new System.Windows.Forms.RadioButton();
            this.PmntMtdCashRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ReferenceText = new System.Windows.Forms.TextBox();
            this.PmntMtdConnectionCombo = new System.Windows.Forms.ComboBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.PaymentMethodGroup = new System.Windows.Forms.GroupBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancelPaymentButton = new System.Windows.Forms.Button();
            this.ArduinoTest = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PaymentMethodGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.statusStrip.Location = new System.Drawing.Point(0, 455);
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
            // PmntMtdCardReaderRadio
            // 
            this.PmntMtdCardReaderRadio.AutoSize = true;
            this.PmntMtdCardReaderRadio.Checked = true;
            this.PmntMtdCardReaderRadio.Location = new System.Drawing.Point(20, 24);
            this.PmntMtdCardReaderRadio.Name = "PmntMtdCardReaderRadio";
            this.PmntMtdCardReaderRadio.Size = new System.Drawing.Size(80, 17);
            this.PmntMtdCardReaderRadio.TabIndex = 10;
            this.PmntMtdCardReaderRadio.TabStop = true;
            this.PmntMtdCardReaderRadio.Text = "Card reader";
            this.PmntMtdCardReaderRadio.UseVisualStyleBackColor = true;
            this.PmntMtdCardReaderRadio.CheckedChanged += new System.EventHandler(this.PaymentMethod_Changed);
            // 
            // PmntMtdCashRadio
            // 
            this.PmntMtdCashRadio.AutoSize = true;
            this.PmntMtdCashRadio.Location = new System.Drawing.Point(20, 47);
            this.PmntMtdCashRadio.Name = "PmntMtdCashRadio";
            this.PmntMtdCashRadio.Size = new System.Drawing.Size(49, 17);
            this.PmntMtdCashRadio.TabIndex = 10;
            this.PmntMtdCashRadio.TabStop = true;
            this.PmntMtdCashRadio.Text = "Cash";
            this.PmntMtdCashRadio.UseVisualStyleBackColor = true;
            this.PmntMtdCashRadio.CheckedChanged += new System.EventHandler(this.PaymentMethod_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "2. Amount (in cents):";
            // 
            // AmountText
            // 
            this.AmountText.Location = new System.Drawing.Point(22, 241);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(101, 20);
            this.AmountText.TabIndex = 12;
            this.AmountText.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "3. (Optional) Reference";
            // 
            // ReferenceText
            // 
            this.ReferenceText.Location = new System.Drawing.Point(129, 241);
            this.ReferenceText.Name = "ReferenceText";
            this.ReferenceText.Size = new System.Drawing.Size(124, 20);
            this.ReferenceText.TabIndex = 13;
            // 
            // PmntMtdConnectionCombo
            // 
            this.PmntMtdConnectionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PmntMtdConnectionCombo.Items.AddRange(new object[] {
            "Bluetooth LE /GATT",
            "Audio",
            "USB"});
            this.PmntMtdConnectionCombo.Location = new System.Drawing.Point(106, 23);
            this.PmntMtdConnectionCombo.Name = "PmntMtdConnectionCombo";
            this.PmntMtdConnectionCombo.Size = new System.Drawing.Size(129, 21);
            this.PmntMtdConnectionCombo.TabIndex = 11;
            this.PmntMtdConnectionCombo.SelectionChangeCommitted += new System.EventHandler(this.PmntMtdConnection_SelectionChangeCommitted);
            // 
            // PaymentMethodGroup
            // 
            this.PaymentMethodGroup.Controls.Add(this.PmntMtdCardReaderRadio);
            this.PaymentMethodGroup.Controls.Add(this.PmntMtdConnectionCombo);
            this.PaymentMethodGroup.Controls.Add(this.PmntMtdCashRadio);
            this.PaymentMethodGroup.Location = new System.Drawing.Point(12, 136);
            this.PaymentMethodGroup.Name = "PaymentMethodGroup";
            this.PaymentMethodGroup.Size = new System.Drawing.Size(241, 75);
            this.PaymentMethodGroup.TabIndex = 22;
            this.PaymentMethodGroup.TabStop = false;
            this.PaymentMethodGroup.Text = "1. Payment method:";
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayButton.Location = new System.Drawing.Point(12, 275);
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
            this.logTextBox.Size = new System.Drawing.Size(347, 305);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SumUpSdkSample.WinForms.Win10.Properties.Resources.index;
            this.pictureBox1.Location = new System.Drawing.Point(506, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
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
            // ArduinoTest
            // 
            this.ArduinoTest.Location = new System.Drawing.Point(15, 316);
            this.ArduinoTest.Name = "ArduinoTest";
            this.ArduinoTest.Size = new System.Drawing.Size(75, 23);
            this.ArduinoTest.TabIndex = 28;
            this.ArduinoTest.Text = "ArduinoTest";
            this.ArduinoTest.UseVisualStyleBackColor = true;
            this.ArduinoTest.Click += new System.EventHandler(this.ArduinoTest_click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 477);
            this.Controls.Add(this.ArduinoTest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.PaymentMethodGroup);
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
            this.Name = "MainForm";
            this.Text = "SumUp SDK Sample - Windows Forms / Windows 10";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PaymentMethodGroup.ResumeLayout(false);
            this.PaymentMethodGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.RadioButton PmntMtdCardReaderRadio;
        private System.Windows.Forms.RadioButton PmntMtdCashRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ReferenceText;
        private System.Windows.Forms.ComboBox PmntMtdConnectionCombo;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.GroupBox PaymentMethodGroup;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CancelPaymentButton;
        private System.Windows.Forms.Button ArduinoTest;
    }
}

