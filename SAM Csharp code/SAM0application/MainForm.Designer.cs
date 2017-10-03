namespace SAM0application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logInButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelPaymentButton = new System.Windows.Forms.Button();
            this.ArduinoTestButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.printTestButton = new System.Windows.Forms.Button();
            this.TapTestButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ledTestCheckBox = new System.Windows.Forms.CheckBox();
            this.PumpTapTestCheckbox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.label18 = new System.Windows.Forms.Label();
            this.FakeSodaButton = new System.Windows.Forms.Button();
            this.FakeGrainButton = new System.Windows.Forms.Button();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInButton.Location = new System.Drawing.Point(879, 12);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(45, 43);
            this.logInButton.TabIndex = 8;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(913, 1);
            this.panel4.TabIndex = 8;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripProgressBar,
            this.statusStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 355);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(937, 22);
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
            this.statusStripStatusLabel.Size = new System.Drawing.Size(820, 17);
            this.statusStripStatusLabel.Spring = true;
            this.statusStripStatusLabel.Text = "Status text";
            this.statusStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "€ cents";
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PayButton.Location = new System.Drawing.Point(20, 148);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(100, 23);
            this.PayButton.TabIndex = 14;
            this.PayButton.Text = "Payment Test";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.DoPaymentButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(343, 136);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(581, 216);
            this.logTextBox.TabIndex = 24;
            this.logTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(340, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Log";
            // 
            // CancelPaymentButton
            // 
            this.CancelPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CancelPaymentButton.Location = new System.Drawing.Point(20, 149);
            this.CancelPaymentButton.Name = "CancelPaymentButton";
            this.CancelPaymentButton.Size = new System.Drawing.Size(99, 23);
            this.CancelPaymentButton.TabIndex = 27;
            this.CancelPaymentButton.Text = "Cancel payment";
            this.CancelPaymentButton.UseVisualStyleBackColor = true;
            this.CancelPaymentButton.Click += new System.EventHandler(this.CancelPaymentButton_Click);
            // 
            // ArduinoTestButton
            // 
            this.ArduinoTestButton.Location = new System.Drawing.Point(20, 125);
            this.ArduinoTestButton.Name = "ArduinoTestButton";
            this.ArduinoTestButton.Size = new System.Drawing.Size(99, 23);
            this.ArduinoTestButton.TabIndex = 28;
            this.ArduinoTestButton.Text = "ArduinoTest";
            this.ArduinoTestButton.UseVisualStyleBackColor = true;
            this.ArduinoTestButton.Click += new System.EventHandler(this.ArduinoTest_click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tests";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Settings";
            // 
            // printTestButton
            // 
            this.printTestButton.Location = new System.Drawing.Point(20, 171);
            this.printTestButton.Name = "printTestButton";
            this.printTestButton.Size = new System.Drawing.Size(99, 23);
            this.printTestButton.TabIndex = 28;
            this.printTestButton.Text = "PrintTest";
            this.printTestButton.UseVisualStyleBackColor = true;
            this.printTestButton.Click += new System.EventHandler(this.PrintTest_click);
            // 
            // TapTestButton
            // 
            this.TapTestButton.Location = new System.Drawing.Point(20, 194);
            this.TapTestButton.Name = "TapTestButton";
            this.TapTestButton.Size = new System.Drawing.Size(99, 23);
            this.TapTestButton.TabIndex = 28;
            this.TapTestButton.Text = "TapTest";
            this.TapTestButton.UseVisualStyleBackColor = true;
            this.TapTestButton.Click += new System.EventHandler(this.TapTest_click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(159, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "mL";
            // 
            // ledTestCheckBox
            // 
            this.ledTestCheckBox.AutoSize = true;
            this.ledTestCheckBox.Location = new System.Drawing.Point(22, 219);
            this.ledTestCheckBox.Name = "ledTestCheckBox";
            this.ledTestCheckBox.Size = new System.Drawing.Size(71, 17);
            this.ledTestCheckBox.TabIndex = 30;
            this.ledTestCheckBox.Text = "LED Test";
            this.ledTestCheckBox.UseVisualStyleBackColor = true;
            this.ledTestCheckBox.Click += new System.EventHandler(this.ledTestCheckBox_click);
            // 
            // PumpTapTestCheckbox
            // 
            this.PumpTapTestCheckbox.AutoSize = true;
            this.PumpTapTestCheckbox.Location = new System.Drawing.Point(22, 242);
            this.PumpTapTestCheckbox.Name = "PumpTapTestCheckbox";
            this.PumpTapTestCheckbox.Size = new System.Drawing.Size(99, 17);
            this.PumpTapTestCheckbox.TabIndex = 30;
            this.PumpTapTestCheckbox.Text = "Pump Tap Test";
            this.PumpTapTestCheckbox.UseVisualStyleBackColor = true;
            this.PumpTapTestCheckbox.Click += new System.EventHandler(this.PumpTapTestCheckbox_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "mL to tap";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "€ min";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "receipt no";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(239, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "LED brightness";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(239, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "LED fade speed";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(241, 329);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Arduino Port";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(263, 107);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(60, 23);
            this.SaveSettingsButton.TabIndex = 33;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(240, 190);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "€ max";
            // 
            // FakeSodaButton
            // 
            this.FakeSodaButton.Location = new System.Drawing.Point(13, 12);
            this.FakeSodaButton.Name = "FakeSodaButton";
            this.FakeSodaButton.Size = new System.Drawing.Size(58, 59);
            this.FakeSodaButton.TabIndex = 35;
            this.FakeSodaButton.Text = "Fake\r\nSoda\r\nButton";
            this.FakeSodaButton.UseVisualStyleBackColor = true;
            this.FakeSodaButton.Click += new System.EventHandler(this.FakeSodaButton_Click);
            // 
            // FakeGrainButton
            // 
            this.FakeGrainButton.Location = new System.Drawing.Point(79, 12);
            this.FakeGrainButton.Name = "FakeGrainButton";
            this.FakeGrainButton.Size = new System.Drawing.Size(58, 59);
            this.FakeGrainButton.TabIndex = 35;
            this.FakeGrainButton.Text = "Fake\r\nGrain\nButton";
            this.FakeGrainButton.UseVisualStyleBackColor = true;
            this.FakeGrainButton.Click += new System.EventHandler(this.FakeGrainButton_Click);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM0application.Properties.Settings.Default, "TestTapAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown7.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown7.Location = new System.Drawing.Point(117, 196);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown7.TabIndex = 34;
            this.numericUpDown7.Value = global::SAM0application.Properties.Settings.Default.TestTapAmount;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SAM0application.Properties.Settings.Default, "ArduinoPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(199, 326);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = global::SAM0application.Properties.Settings.Default.ArduinoPort;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM0application.Properties.Settings.Default, "ReceiptNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown4.Location = new System.Drawing.Point(199, 256);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown4.TabIndex = 31;
            this.numericUpDown4.ThousandsSeparator = true;
            this.numericUpDown4.Value = global::SAM0application.Properties.Settings.Default.ReceiptNo;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM0application.Properties.Settings.Default, "LEDspeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown6.Location = new System.Drawing.Point(199, 302);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown6.TabIndex = 31;
            this.numericUpDown6.Value = global::SAM0application.Properties.Settings.Default.LEDspeed;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM0application.Properties.Settings.Default, "LEDbrightness", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown5.Location = new System.Drawing.Point(199, 281);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown5.TabIndex = 31;
            this.numericUpDown5.Value = global::SAM0application.Properties.Settings.Default.LEDbrightness;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM0application.Properties.Settings.Default, "TapAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(199, 138);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown2.TabIndex = 31;
            this.numericUpDown2.Value = global::SAM0application.Properties.Settings.Default.TapAmount;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM0application.Properties.Settings.Default, "MaxPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(199, 188);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown3.TabIndex = 31;
            this.numericUpDown3.Value = global::SAM0application.Properties.Settings.Default.MaxPrice;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM0application.Properties.Settings.Default, "MinPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(199, 162);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.Value = global::SAM0application.Properties.Settings.Default.MinPrice;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = global::SAM0application.Properties.Settings.Default.PrintingShortVersion;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SAM0application.Properties.Settings.Default, "PrintingShortVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox6.Location = new System.Drawing.Point(199, 233);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(124, 17);
            this.checkBox6.TabIndex = 30;
            this.checkBox6.Text = "Printing short version";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = global::SAM0application.Properties.Settings.Default.PrintingEnabled;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SAM0application.Properties.Settings.Default, "PrintingEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox5.Location = new System.Drawing.Point(199, 214);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(93, 17);
            this.checkBox5.TabIndex = 30;
            this.checkBox5.Text = "Printing on/off";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // AmountText
            // 
            this.AmountText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SAM0application.Properties.Settings.Default, "PaymentTestAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AmountText.Location = new System.Drawing.Point(118, 150);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(27, 20);
            this.AmountText.TabIndex = 12;
            this.AmountText.Text = global::SAM0application.Properties.Settings.Default.PaymentTestAmount;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "SAM0 2017 by Arvid&&Marie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Based un SumUp SampleApp and CmdMessenge ArduinoController";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 377);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FakeGrainButton);
            this.Controls.Add(this.FakeSodaButton);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.PumpTapTestCheckbox);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.ledTestCheckBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TapTestButton);
            this.Controls.Add(this.printTestButton);
            this.Controls.Add(this.ArduinoTestButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.CancelPaymentButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(635, 385);
            this.Name = "MainForm";
            this.Text = "SAM0 application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar statusStripProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelPaymentButton;
        private System.Windows.Forms.Button ArduinoTestButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button printTestButton;
        private System.Windows.Forms.Button TapTestButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ledTestCheckBox;
        private System.Windows.Forms.CheckBox PumpTapTestCheckbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button FakeSodaButton;
        private System.Windows.Forms.Button FakeGrainButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

