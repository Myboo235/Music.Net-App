namespace Music.Net_App.View
{
    partial class WelcomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.GetstartedButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(119)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(307, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Live your day with Muzica";
            // 
            // GetstartedButton
            // 
            this.GetstartedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(119)))), ((int)(((byte)(45)))));
            this.GetstartedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetstartedButton.FlatAppearance.BorderSize = 0;
            this.GetstartedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetstartedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GetstartedButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.GetstartedButton.IconColor = System.Drawing.Color.Black;
            this.GetstartedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GetstartedButton.Location = new System.Drawing.Point(433, 526);
            this.GetstartedButton.Name = "GetstartedButton";
            this.GetstartedButton.Size = new System.Drawing.Size(202, 51);
            this.GetstartedButton.TabIndex = 2;
            this.GetstartedButton.Text = "Get Started...";
            this.GetstartedButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GetstartedButton.UseVisualStyleBackColor = false;
            this.GetstartedButton.Click += new System.EventHandler(this.GetstartedButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(77, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(994, 387);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 706);
            this.Controls.Add(this.GetstartedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton GetstartedButton;
    }
}