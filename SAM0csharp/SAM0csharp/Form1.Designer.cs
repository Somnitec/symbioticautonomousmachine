namespace SAM0csharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button_testArduino = new System.Windows.Forms.Button();
            this.button_testprint = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.button_testtap = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_testpay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_testArduino
            // 
            this.button_testArduino.Location = new System.Drawing.Point(13, 13);
            this.button_testArduino.Name = "button_testArduino";
            this.button_testArduino.Size = new System.Drawing.Size(75, 23);
            this.button_testArduino.TabIndex = 0;
            this.button_testArduino.Text = "test Arduino";
            this.button_testArduino.UseVisualStyleBackColor = true;
            this.button_testArduino.Click += new System.EventHandler(this.Button_testArduino_click);
            // 
            // button_testprint
            // 
            this.button_testprint.Location = new System.Drawing.Point(13, 43);
            this.button_testprint.Name = "button_testprint";
            this.button_testprint.Size = new System.Drawing.Size(75, 23);
            this.button_testprint.TabIndex = 1;
            this.button_testprint.Text = "test Print";
            this.button_testprint.UseVisualStyleBackColor = true;
            this.button_testprint.Click += new System.EventHandler(this.Button_testPrint_click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(114, 13);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(158, 223);
            this.logTextBox.TabIndex = 2;
            this.logTextBox.Text = "initialized";
            // 
            // button_testtap
            // 
            this.button_testtap.Location = new System.Drawing.Point(13, 72);
            this.button_testtap.Name = "button_testtap";
            this.button_testtap.Size = new System.Drawing.Size(75, 23);
            this.button_testtap.TabIndex = 1;
            this.button_testtap.Text = "test Tap";
            this.button_testtap.UseVisualStyleBackColor = true;
            this.button_testtap.Click += new System.EventHandler(this.Button_testTap_click);
            // 
            // button_testpay
            // 
            this.button_testpay.Location = new System.Drawing.Point(13, 101);
            this.button_testpay.Name = "button_testpay";
            this.button_testpay.Size = new System.Drawing.Size(75, 23);
            this.button_testpay.TabIndex = 1;
            this.button_testpay.Text = "test Pay";
            this.button_testpay.UseVisualStyleBackColor = true;
            this.button_testpay.Click += new System.EventHandler(this.Button_testPay_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.button_testpay);
            this.Controls.Add(this.button_testtap);
            this.Controls.Add(this.button_testprint);
            this.Controls.Add(this.button_testArduino);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_testArduino;
        private System.Windows.Forms.Button button_testprint;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button button_testtap;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button_testpay;
    }
}

