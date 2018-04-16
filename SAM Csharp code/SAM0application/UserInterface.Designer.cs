namespace SAM0application
{
    partial class UserInterface
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
            this.interfaceText = new System.Windows.Forms.Label();
            this.arrowBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arrowBox)).BeginInit();
            this.SuspendLayout();
            // 
            // interfaceText
            // 
            this.interfaceText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.interfaceText.AutoSize = true;
            this.interfaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.interfaceText.Location = new System.Drawing.Point(62, 0);
            this.interfaceText.Margin = new System.Windows.Forms.Padding(0);
            this.interfaceText.MaximumSize = new System.Drawing.Size(1050, 1969);
            this.interfaceText.MinimumSize = new System.Drawing.Size(1050, 1969);
            this.interfaceText.Name = "interfaceText";
            this.interfaceText.Size = new System.Drawing.Size(1050, 1969);
            this.interfaceText.TabIndex = 0;
            this.interfaceText.Text = "starting";
            this.interfaceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrowBox
            // 
            this.arrowBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.arrowBox.BackColor = System.Drawing.Color.Transparent;
            this.arrowBox.Image = global::SAM0application.Properties.Resources.arrow;
            this.arrowBox.InitialImage = global::SAM0application.Properties.Resources.arrow;
            this.arrowBox.Location = new System.Drawing.Point(512, 462);
            this.arrowBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arrowBox.MaximumSize = new System.Drawing.Size(150, 154);
            this.arrowBox.Name = "arrowBox";
            this.arrowBox.Size = new System.Drawing.Size(150, 154);
            this.arrowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowBox.TabIndex = 1;
            this.arrowBox.TabStop = false;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 1036);
            this.Controls.Add(this.arrowBox);
            this.Controls.Add(this.interfaceText);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            ((System.ComponentModel.ISupportInitialize)(this.arrowBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label interfaceText;
        private System.Windows.Forms.PictureBox arrowBox;
    }
}