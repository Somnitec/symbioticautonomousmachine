namespace SAM1application
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrowBox)).BeginInit();
            this.SuspendLayout();
            // 
            // interfaceText
            // 
            this.interfaceText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.interfaceText.AutoSize = true;
            this.interfaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.interfaceText.Location = new System.Drawing.Point(-101, 0);
            this.interfaceText.Margin = new System.Windows.Forms.Padding(0);
            this.interfaceText.MaximumSize = new System.Drawing.Size(700, 1280);
            this.interfaceText.MinimumSize = new System.Drawing.Size(700, 1280);
            this.interfaceText.Name = "interfaceText";
            this.interfaceText.Size = new System.Drawing.Size(700, 1280);
            this.interfaceText.TabIndex = 0;
            this.interfaceText.Text = "starting";
            this.interfaceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrowBox
            // 
            this.arrowBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.arrowBox.BackColor = System.Drawing.Color.Transparent;
            this.arrowBox.Image = global::SAM1application.Properties.Resources.arrow;
            this.arrowBox.InitialImage = global::SAM1application.Properties.Resources.arrow;
            this.arrowBox.Location = new System.Drawing.Point(199, 300);
            this.arrowBox.MaximumSize = new System.Drawing.Size(100, 100);
            this.arrowBox.Name = "arrowBox";
            this.arrowBox.Size = new System.Drawing.Size(100, 100);
            this.arrowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowBox.TabIndex = 1;
            this.arrowBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // currentAmount
            // 
            this.currentAmount.AutoSize = true;
            this.currentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.currentAmount.Location = new System.Drawing.Point(97, 30);
            this.currentAmount.Name = "currentAmount";
            this.currentAmount.Size = new System.Drawing.Size(338, 120);
            this.currentAmount.TabIndex = 3;
            this.currentAmount.Text = "label2";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 749);
            this.Controls.Add(this.currentAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrowBox);
            this.Controls.Add(this.interfaceText);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            ((System.ComponentModel.ISupportInitialize)(this.arrowBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label interfaceText;
        private System.Windows.Forms.PictureBox arrowBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentAmount;
    }
}