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
            this.currentAmount = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.interfaceText = new System.Windows.Forms.Label();
            this.interfaceImage = new System.Windows.Forms.PictureBox();
            this.arrowBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowBox)).BeginInit();
            this.SuspendLayout();
            // 
            // currentAmount
            // 
            this.currentAmount.AutoSize = true;
            this.currentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.currentAmount.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.currentAmount.Location = new System.Drawing.Point(309, 837);
            this.currentAmount.Name = "currentAmount";
            this.currentAmount.Size = new System.Drawing.Size(273, 120);
            this.currentAmount.TabIndex = 3;
            this.currentAmount.Text = "0 元 ";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.priceLabel.Location = new System.Drawing.Point(-42, 527);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(607, 91);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "the price is 0 元 ";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interfaceText
            // 
            this.interfaceText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.interfaceText.AutoSize = true;
            this.interfaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.interfaceText.Location = new System.Drawing.Point(-167, 0);
            this.interfaceText.Margin = new System.Windows.Forms.Padding(0);
            this.interfaceText.MaximumSize = new System.Drawing.Size(700, 1280);
            this.interfaceText.MinimumSize = new System.Drawing.Size(700, 1280);
            this.interfaceText.Name = "interfaceText";
            this.interfaceText.Size = new System.Drawing.Size(700, 1280);
            this.interfaceText.TabIndex = 0;
            this.interfaceText.Text = "starting";
            this.interfaceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.interfaceText.Visible = false;
            // 
            // interfaceImage
            // 
            this.interfaceImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.interfaceImage.Image = global::SAM1application.Properties.Resources.sam2p1;
            this.interfaceImage.Location = new System.Drawing.Point(-9, 0);
            this.interfaceImage.Name = "interfaceImage";
            this.interfaceImage.Size = new System.Drawing.Size(562, 1209);
            this.interfaceImage.TabIndex = 6;
            this.interfaceImage.TabStop = false;
            // 
            // arrowBox
            // 
            this.arrowBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.arrowBox.BackColor = System.Drawing.Color.Transparent;
            this.arrowBox.Image = global::SAM1application.Properties.Resources.arrow;
            this.arrowBox.InitialImage = global::SAM1application.Properties.Resources.arrow;
            this.arrowBox.Location = new System.Drawing.Point(114, 252);
            this.arrowBox.MaximumSize = new System.Drawing.Size(100, 100);
            this.arrowBox.Name = "arrowBox";
            this.arrowBox.Size = new System.Drawing.Size(100, 100);
            this.arrowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowBox.TabIndex = 1;
            this.arrowBox.TabStop = false;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 472);
            this.Controls.Add(this.interfaceImage);
            this.Controls.Add(this.interfaceText);
            this.Controls.Add(this.currentAmount);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.arrowBox);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            ((System.ComponentModel.ISupportInitialize)(this.interfaceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentAmount;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label interfaceText;
        private System.Windows.Forms.PictureBox arrowBox;
        private System.Windows.Forms.PictureBox interfaceImage;
    }
}