namespace SAM4application
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
            this.label2 = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.CancelPaymentButton = new System.Windows.Forms.Button();
            this.ArduinoTestButton = new System.Windows.Forms.Button();
            this.printTestButton = new System.Windows.Forms.Button();
            this.ledTestCheckBox = new System.Windows.Forms.CheckBox();
            this.PumpTapTestCheckbox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.label18 = new System.Windows.Forms.Label();
            this.drinkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.arduinoConnectCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ledStateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.interfaceStateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.testTapMsButton = new System.Windows.Forms.Button();
            this.switchInterface = new System.Windows.Forms.Button();
            this.interfacePanel = new System.Windows.Forms.Panel();
            this.manualOverrideLabel = new System.Windows.Forms.Label();
            this.priceAmount = new System.Windows.Forms.NumericUpDown();
            this.CloseProgramButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.fakePayment = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ReceiptNoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LedBreathSpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LedBreathMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LedBreathMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.tapMillisecondsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PaymentOnOffCheckbox = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.PrintingCheckBox = new System.Windows.Forms.CheckBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.interfaceImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ledStateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceStateNumericUpDown)).BeginInit();
            this.interfacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptNoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedBreathSpeedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedBreathMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedBreathMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapMillisecondsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.White;
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInButton.Location = new System.Drawing.Point(223, 175);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(45, 43);
            this.logInButton.TabIndex = 8;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "€ cents";
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.White;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PayButton.Location = new System.Drawing.Point(4, 76);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(60, 60);
            this.PayButton.TabIndex = 14;
            this.PayButton.Text = "Payment Test";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.DoPaymentButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(280, 13);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(270, 533);
            this.logTextBox.TabIndex = 24;
            this.logTextBox.WordWrap = false;
            // 
            // CancelPaymentButton
            // 
            this.CancelPaymentButton.BackColor = System.Drawing.Color.White;
            this.CancelPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CancelPaymentButton.Location = new System.Drawing.Point(64, 98);
            this.CancelPaymentButton.Name = "CancelPaymentButton";
            this.CancelPaymentButton.Size = new System.Drawing.Size(60, 38);
            this.CancelPaymentButton.TabIndex = 27;
            this.CancelPaymentButton.Text = "Cancel payment";
            this.CancelPaymentButton.UseVisualStyleBackColor = false;
            this.CancelPaymentButton.Click += new System.EventHandler(this.CancelPaymentButton_Click);
            // 
            // ArduinoTestButton
            // 
            this.ArduinoTestButton.BackColor = System.Drawing.Color.White;
            this.ArduinoTestButton.Location = new System.Drawing.Point(4, 304);
            this.ArduinoTestButton.Name = "ArduinoTestButton";
            this.ArduinoTestButton.Size = new System.Drawing.Size(60, 60);
            this.ArduinoTestButton.TabIndex = 28;
            this.ArduinoTestButton.Text = "ArduinoTest";
            this.ArduinoTestButton.UseVisualStyleBackColor = false;
            this.ArduinoTestButton.Click += new System.EventHandler(this.ArduinoTest_click);
            // 
            // printTestButton
            // 
            this.printTestButton.BackColor = System.Drawing.Color.White;
            this.printTestButton.Location = new System.Drawing.Point(4, 225);
            this.printTestButton.Name = "printTestButton";
            this.printTestButton.Size = new System.Drawing.Size(60, 60);
            this.printTestButton.TabIndex = 28;
            this.printTestButton.Text = "PrintTest";
            this.printTestButton.UseVisualStyleBackColor = false;
            this.printTestButton.Click += new System.EventHandler(this.PrintTest_click);
            // 
            // ledTestCheckBox
            // 
            this.ledTestCheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ledTestCheckBox.Location = new System.Drawing.Point(64, 327);
            this.ledTestCheckBox.Name = "ledTestCheckBox";
            this.ledTestCheckBox.Size = new System.Drawing.Size(71, 37);
            this.ledTestCheckBox.TabIndex = 30;
            this.ledTestCheckBox.Text = "LED Test";
            this.ledTestCheckBox.UseVisualStyleBackColor = false;
            this.ledTestCheckBox.Click += new System.EventHandler(this.ledTestCheckBox_click);
            // 
            // PumpTapTestCheckbox
            // 
            this.PumpTapTestCheckbox.BackColor = System.Drawing.Color.DarkOrange;
            this.PumpTapTestCheckbox.Location = new System.Drawing.Point(6, 152);
            this.PumpTapTestCheckbox.Name = "PumpTapTestCheckbox";
            this.PumpTapTestCheckbox.Size = new System.Drawing.Size(91, 50);
            this.PumpTapTestCheckbox.TabIndex = 30;
            this.PumpTapTestCheckbox.Text = "Pump On/Off";
            this.PumpTapTestCheckbox.UseVisualStyleBackColor = false;
            this.PumpTapTestCheckbox.Click += new System.EventHandler(this.PumpTapTestCheckbox_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "€ min";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(112, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "receipt no";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(176, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "LED brightness max";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(187, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "LED fade speed";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(212, 307);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Arduino Port";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.BackColor = System.Drawing.Color.White;
            this.SaveSettingsButton.Location = new System.Drawing.Point(69, 3);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(60, 60);
            this.SaveSettingsButton.TabIndex = 33;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = false;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(174, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "€ max";
            // 
            // drinkButton
            // 
            this.drinkButton.BackColor = System.Drawing.Color.White;
            this.drinkButton.Location = new System.Drawing.Point(4, 3);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(60, 60);
            this.drinkButton.TabIndex = 35;
            this.drinkButton.Text = "Request Drink Button";
            this.drinkButton.UseVisualStyleBackColor = false;
            this.drinkButton.Click += new System.EventHandler(this.FakeSodaButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "2019 by Arvid&&Marie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "Based on SumUp SampleApp and \r\nCmdMessenge ArduinoController";
            // 
            // arduinoConnectCheckBox
            // 
            this.arduinoConnectCheckBox.AutoSize = true;
            this.arduinoConnectCheckBox.Checked = true;
            this.arduinoConnectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.arduinoConnectCheckBox.Location = new System.Drawing.Point(64, 305);
            this.arduinoConnectCheckBox.Name = "arduinoConnectCheckBox";
            this.arduinoConnectCheckBox.Size = new System.Drawing.Size(104, 17);
            this.arduinoConnectCheckBox.TabIndex = 30;
            this.arduinoConnectCheckBox.Text = "Arduino Enabled";
            this.arduinoConnectCheckBox.UseVisualStyleBackColor = true;
            this.arduinoConnectCheckBox.Click += new System.EventHandler(this.arduinoConnectCheckBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "LED brightness min";
            // 
            // ledStateNumericUpDown
            // 
            this.ledStateNumericUpDown.Location = new System.Drawing.Point(5, 363);
            this.ledStateNumericUpDown.Name = "ledStateNumericUpDown";
            this.ledStateNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.ledStateNumericUpDown.TabIndex = 37;
            this.ledStateNumericUpDown.ValueChanged += new System.EventHandler(this.ledStateNumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "ledState";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "interfaceState";
            // 
            // interfaceStateNumericUpDown
            // 
            this.interfaceStateNumericUpDown.Location = new System.Drawing.Point(6, 403);
            this.interfaceStateNumericUpDown.Name = "interfaceStateNumericUpDown";
            this.interfaceStateNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.interfaceStateNumericUpDown.TabIndex = 39;
            this.interfaceStateNumericUpDown.ValueChanged += new System.EventHandler(this.interfaceStateNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.Location = new System.Drawing.Point(217, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ms to tap";
            // 
            // testTapMsButton
            // 
            this.testTapMsButton.BackColor = System.Drawing.Color.White;
            this.testTapMsButton.Location = new System.Drawing.Point(94, 147);
            this.testTapMsButton.Name = "testTapMsButton";
            this.testTapMsButton.Size = new System.Drawing.Size(60, 60);
            this.testTapMsButton.TabIndex = 41;
            this.testTapMsButton.Text = "Test Tap Time";
            this.testTapMsButton.UseVisualStyleBackColor = false;
            this.testTapMsButton.Click += new System.EventHandler(this.testTapMsButton_Click);
            // 
            // switchInterface
            // 
            this.switchInterface.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.switchInterface.FlatAppearance.BorderSize = 0;
            this.switchInterface.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.switchInterface.ForeColor = System.Drawing.Color.Transparent;
            this.switchInterface.Location = new System.Drawing.Point(0, 0);
            this.switchInterface.Name = "switchInterface";
            this.switchInterface.Size = new System.Drawing.Size(98, 75);
            this.switchInterface.TabIndex = 42;
            this.switchInterface.Text = "Switch Manual Override";
            this.switchInterface.UseMnemonic = false;
            this.switchInterface.UseVisualStyleBackColor = true;
            this.switchInterface.Click += new System.EventHandler(this.SwitchInterface_Click);
            // 
            // interfacePanel
            // 
            this.interfacePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.interfacePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interfacePanel.Controls.Add(this.manualOverrideLabel);
            this.interfacePanel.Controls.Add(this.priceAmount);
            this.interfacePanel.Controls.Add(this.CloseProgramButton);
            this.interfacePanel.Controls.Add(this.statusLabel);
            this.interfacePanel.Controls.Add(this.progressBar);
            this.interfacePanel.Controls.Add(this.drinkButton);
            this.interfacePanel.Controls.Add(this.label3);
            this.interfacePanel.Controls.Add(this.testTapMsButton);
            this.interfacePanel.Controls.Add(this.label4);
            this.interfacePanel.Controls.Add(this.label7);
            this.interfacePanel.Controls.Add(this.ArduinoTestButton);
            this.interfacePanel.Controls.Add(this.logInButton);
            this.interfacePanel.Controls.Add(this.interfaceStateNumericUpDown);
            this.interfacePanel.Controls.Add(this.CancelPaymentButton);
            this.interfacePanel.Controls.Add(this.label6);
            this.interfacePanel.Controls.Add(this.fakePayment);
            this.interfacePanel.Controls.Add(this.PayButton);
            this.interfacePanel.Controls.Add(this.ledStateNumericUpDown);
            this.interfacePanel.Controls.Add(this.label2);
            this.interfacePanel.Controls.Add(this.SaveSettingsButton);
            this.interfacePanel.Controls.Add(this.textBox2);
            this.interfacePanel.Controls.Add(this.label9);
            this.interfacePanel.Controls.Add(this.label8);
            this.interfacePanel.Controls.Add(this.ReceiptNoNumericUpDown);
            this.interfacePanel.Controls.Add(this.label15);
            this.interfacePanel.Controls.Add(this.LedBreathSpeedNumericUpDown);
            this.interfacePanel.Controls.Add(this.label5);
            this.interfacePanel.Controls.Add(this.LedBreathMinNumericUpDown);
            this.interfacePanel.Controls.Add(this.label16);
            this.interfacePanel.Controls.Add(this.LedBreathMaxNumericUpDown);
            this.interfacePanel.Controls.Add(this.label17);
            this.interfacePanel.Controls.Add(this.numericUpDown4);
            this.interfacePanel.Controls.Add(this.tapMillisecondsNumericUpDown);
            this.interfacePanel.Controls.Add(this.label13);
            this.interfacePanel.Controls.Add(this.numericUpDown3);
            this.interfacePanel.Controls.Add(this.label18);
            this.interfacePanel.Controls.Add(this.numericUpDown1);
            this.interfacePanel.Controls.Add(this.label14);
            this.interfacePanel.Controls.Add(this.arduinoConnectCheckBox);
            this.interfacePanel.Controls.Add(this.printTestButton);
            this.interfacePanel.Controls.Add(this.PaymentOnOffCheckbox);
            this.interfacePanel.Controls.Add(this.PumpTapTestCheckbox);
            this.interfacePanel.Controls.Add(this.checkBox6);
            this.interfacePanel.Controls.Add(this.PrintingCheckBox);
            this.interfacePanel.Controls.Add(this.ledTestCheckBox);
            this.interfacePanel.Controls.Add(this.logTextBox);
            this.interfacePanel.Location = new System.Drawing.Point(12, 82);
            this.interfacePanel.Name = "interfacePanel";
            this.interfacePanel.Size = new System.Drawing.Size(577, 551);
            this.interfacePanel.TabIndex = 43;
            // 
            // manualOverrideLabel
            // 
            this.manualOverrideLabel.AutoSize = true;
            this.manualOverrideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualOverrideLabel.ForeColor = System.Drawing.Color.Red;
            this.manualOverrideLabel.Location = new System.Drawing.Point(79, 385);
            this.manualOverrideLabel.Name = "manualOverrideLabel";
            this.manualOverrideLabel.Size = new System.Drawing.Size(201, 17);
            this.manualOverrideLabel.TabIndex = 46;
            this.manualOverrideLabel.Text = "SAM3 MANUAL OVERRIDE";
            // 
            // priceAmount
            // 
            this.priceAmount.Location = new System.Drawing.Point(64, 80);
            this.priceAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.priceAmount.Name = "priceAmount";
            this.priceAmount.Size = new System.Drawing.Size(43, 20);
            this.priceAmount.TabIndex = 45;
            this.priceAmount.ThousandsSeparator = true;
            this.priceAmount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.priceAmount.ValueChanged += new System.EventHandler(this.PriceAmount_ValueChanged);
            // 
            // CloseProgramButton
            // 
            this.CloseProgramButton.BackColor = System.Drawing.Color.White;
            this.CloseProgramButton.Location = new System.Drawing.Point(211, 224);
            this.CloseProgramButton.Name = "CloseProgramButton";
            this.CloseProgramButton.Size = new System.Drawing.Size(60, 60);
            this.CloseProgramButton.TabIndex = 44;
            this.CloseProgramButton.Text = "Close Program";
            this.CloseProgramButton.UseVisualStyleBackColor = false;
            this.CloseProgramButton.Click += new System.EventHandler(this.CloseProgramButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(142, 39);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(61, 13);
            this.statusLabel.TabIndex = 43;
            this.statusLabel.Text = "Status Text";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(140, 13);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(131, 23);
            this.progressBar.TabIndex = 42;
            // 
            // fakePayment
            // 
            this.fakePayment.BackColor = System.Drawing.Color.White;
            this.fakePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fakePayment.Location = new System.Drawing.Point(211, 73);
            this.fakePayment.Name = "fakePayment";
            this.fakePayment.Size = new System.Drawing.Size(57, 39);
            this.fakePayment.TabIndex = 14;
            this.fakePayment.Text = "Fake Payment";
            this.fakePayment.UseVisualStyleBackColor = false;
            this.fakePayment.Click += new System.EventHandler(this.FakePayment_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SAM4application.Properties.Settings.Default, "ArduinoPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(170, 304);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = global::SAM4application.Properties.Settings.Default.ArduinoPort;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.GreenYellow;
            this.label9.Location = new System.Drawing.Point(113, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "s wait for receipt";
            // 
            // ReceiptNoNumericUpDown
            // 
            this.ReceiptNoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM4application.Properties.Settings.Default, "ReceiptNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ReceiptNoNumericUpDown.Location = new System.Drawing.Point(69, 264);
            this.ReceiptNoNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.ReceiptNoNumericUpDown.Name = "ReceiptNoNumericUpDown";
            this.ReceiptNoNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.ReceiptNoNumericUpDown.TabIndex = 31;
            this.ReceiptNoNumericUpDown.ThousandsSeparator = true;
            this.ReceiptNoNumericUpDown.Value = global::SAM4application.Properties.Settings.Default.ReceiptNo;
            // 
            // LedBreathSpeedNumericUpDown
            // 
            this.LedBreathSpeedNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM4application.Properties.Settings.Default, "LEDspeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LedBreathSpeedNumericUpDown.DecimalPlaces = 3;
            this.LedBreathSpeedNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.LedBreathSpeedNumericUpDown.Location = new System.Drawing.Point(135, 362);
            this.LedBreathSpeedNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.LedBreathSpeedNumericUpDown.Name = "LedBreathSpeedNumericUpDown";
            this.LedBreathSpeedNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.LedBreathSpeedNumericUpDown.TabIndex = 31;
            this.LedBreathSpeedNumericUpDown.Value = global::SAM4application.Properties.Settings.Default.LEDspeed;
            this.LedBreathSpeedNumericUpDown.ValueChanged += new System.EventHandler(this.LedBreathSpeedNumericUpDown_ValueChanged);
            // 
            // LedBreathMinNumericUpDown
            // 
            this.LedBreathMinNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM4application.Properties.Settings.Default, "ledBrightnessMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LedBreathMinNumericUpDown.Location = new System.Drawing.Point(135, 343);
            this.LedBreathMinNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LedBreathMinNumericUpDown.Name = "LedBreathMinNumericUpDown";
            this.LedBreathMinNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.LedBreathMinNumericUpDown.TabIndex = 31;
            this.LedBreathMinNumericUpDown.Value = global::SAM4application.Properties.Settings.Default.ledBrightnessMin;
            this.LedBreathMinNumericUpDown.ValueChanged += new System.EventHandler(this.LedBreathMinNumericUpDown_ValueChanged);
            // 
            // LedBreathMaxNumericUpDown
            // 
            this.LedBreathMaxNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM4application.Properties.Settings.Default, "LEDbrightnessMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LedBreathMaxNumericUpDown.Location = new System.Drawing.Point(135, 324);
            this.LedBreathMaxNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LedBreathMaxNumericUpDown.Name = "LedBreathMaxNumericUpDown";
            this.LedBreathMaxNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.LedBreathMaxNumericUpDown.TabIndex = 31;
            this.LedBreathMaxNumericUpDown.Value = global::SAM4application.Properties.Settings.Default.LEDbrightnessMax;
            this.LedBreathMaxNumericUpDown.ValueChanged += new System.EventHandler(this.LedBreathMaxNumericUpDown_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.GreenYellow;
            this.numericUpDown4.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM4application.Properties.Settings.Default, "receiptTimeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown4.Location = new System.Drawing.Point(71, 283);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown4.TabIndex = 31;
            this.numericUpDown4.ThousandsSeparator = true;
            this.numericUpDown4.Value = global::SAM4application.Properties.Settings.Default.receiptTimeout;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.tapMillisecondsNumericUpDown_ValueChanged);
            // 
            // tapMillisecondsNumericUpDown
            // 
            this.tapMillisecondsNumericUpDown.BackColor = System.Drawing.Color.GreenYellow;
            this.tapMillisecondsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM4application.Properties.Settings.Default, "tapMilliseconds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tapMillisecondsNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tapMillisecondsNumericUpDown.Location = new System.Drawing.Point(158, 147);
            this.tapMillisecondsNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tapMillisecondsNumericUpDown.Name = "tapMillisecondsNumericUpDown";
            this.tapMillisecondsNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.tapMillisecondsNumericUpDown.TabIndex = 31;
            this.tapMillisecondsNumericUpDown.ThousandsSeparator = true;
            this.tapMillisecondsNumericUpDown.Value = global::SAM4application.Properties.Settings.Default.tapMilliseconds;
            this.tapMillisecondsNumericUpDown.ValueChanged += new System.EventHandler(this.tapMillisecondsNumericUpDown_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM4application.Properties.Settings.Default, "MaxPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(133, 118);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown3.TabIndex = 31;
            this.numericUpDown3.Value = global::SAM4application.Properties.Settings.Default.MaxPrice;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SAM4application.Properties.Settings.Default, "MinPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(133, 92);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.Value = global::SAM4application.Properties.Settings.Default.MinPrice;
            // 
            // PaymentOnOffCheckbox
            // 
            this.PaymentOnOffCheckbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PaymentOnOffCheckbox.Checked = global::SAM4application.Properties.Settings.Default.paymentEnabled;
            this.PaymentOnOffCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SAM4application.Properties.Settings.Default, "paymentEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PaymentOnOffCheckbox.Location = new System.Drawing.Point(211, 110);
            this.PaymentOnOffCheckbox.Name = "PaymentOnOffCheckbox";
            this.PaymentOnOffCheckbox.Size = new System.Drawing.Size(68, 33);
            this.PaymentOnOffCheckbox.TabIndex = 30;
            this.PaymentOnOffCheckbox.Text = "Payment On/Off";
            this.PaymentOnOffCheckbox.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = global::SAM4application.Properties.Settings.Default.PrintingShortVersion;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SAM4application.Properties.Settings.Default, "PrintingShortVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(69, 245);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(124, 17);
            this.checkBox6.TabIndex = 30;
            this.checkBox6.Text = "Printing short version";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // PrintingCheckBox
            // 
            this.PrintingCheckBox.Checked = global::SAM4application.Properties.Settings.Default.PrintingEnabled;
            this.PrintingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PrintingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SAM4application.Properties.Settings.Default, "PrintingEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PrintingCheckBox.Location = new System.Drawing.Point(69, 226);
            this.PrintingCheckBox.Name = "PrintingCheckBox";
            this.PrintingCheckBox.Size = new System.Drawing.Size(93, 17);
            this.PrintingCheckBox.TabIndex = 30;
            this.PrintingCheckBox.Text = "Printing on/off";
            this.PrintingCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceLabel.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(0, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(604, 981);
            this.priceLabel.TabIndex = 44;
            this.priceLabel.Text = "1 EUR ≈ £0.86";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interfaceImage
            // 
            this.interfaceImage.Location = new System.Drawing.Point(0, 0);
            this.interfaceImage.Margin = new System.Windows.Forms.Padding(0);
            this.interfaceImage.Name = "interfaceImage";
            this.interfaceImage.Size = new System.Drawing.Size(600, 1024);
            this.interfaceImage.TabIndex = 45;
            this.interfaceImage.TabStop = false;
            this.interfaceImage.Click += new System.EventHandler(this.InterfaceImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-72, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-66, 557);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "password";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SAM4application.Properties.Settings.Default, "sumupPass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(-69, 570);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 50;
            this.textBox3.Text = global::SAM4application.Properties.Settings.Default.sumupPass;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SAM4application.Properties.Settings.Default, "sumupUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(-62, 534);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 48;
            this.textBox1.Text = global::SAM4application.Properties.Settings.Default.sumupUser;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 981);
            this.Controls.Add(this.switchInterface);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.interfacePanel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interfaceImage);
            this.Controls.Add(this.priceLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(598, 376);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAM4 application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ledStateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceStateNumericUpDown)).EndInit();
            this.interfacePanel.ResumeLayout(false);
            this.interfacePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptNoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedBreathSpeedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedBreathMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedBreathMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapMillisecondsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button CancelPaymentButton;
        private System.Windows.Forms.Button ArduinoTestButton;
        private System.Windows.Forms.Button printTestButton;
        private System.Windows.Forms.CheckBox ledTestCheckBox;
        private System.Windows.Forms.CheckBox PumpTapTestCheckbox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox PrintingCheckBox;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown ReceiptNoNumericUpDown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown LedBreathMaxNumericUpDown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown LedBreathSpeedNumericUpDown;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox arduinoConnectCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown LedBreathMinNumericUpDown;
        private System.Windows.Forms.NumericUpDown ledStateNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown interfaceStateNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown tapMillisecondsNumericUpDown;
        internal System.Windows.Forms.Button drinkButton;
        private System.Windows.Forms.Button testTapMsButton;
        private System.Windows.Forms.Button switchInterface;
        private System.Windows.Forms.Panel interfacePanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.PictureBox interfaceImage;
        private System.Windows.Forms.Button CloseProgramButton;
        private System.Windows.Forms.Button fakePayment;
        private System.Windows.Forms.CheckBox PaymentOnOffCheckbox;
        private System.Windows.Forms.NumericUpDown priceAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label manualOverrideLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

