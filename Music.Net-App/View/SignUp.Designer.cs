namespace Music.Net_App.View
{
    partial class SignUp
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
            this.iconButtonSpotify = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.iconButtonSignUp = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonSpotify
            // 
            this.iconButtonSpotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSpotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.iconButtonSpotify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.iconButtonSpotify.IconChar = FontAwesome.Sharp.IconChar.Spotify;
            this.iconButtonSpotify.IconColor = System.Drawing.Color.White;
            this.iconButtonSpotify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSpotify.IconSize = 72;
            this.iconButtonSpotify.Location = new System.Drawing.Point(0, 0);
            this.iconButtonSpotify.Name = "iconButtonSpotify";
            this.iconButtonSpotify.Size = new System.Drawing.Size(413, 130);
            this.iconButtonSpotify.TabIndex = 0;
            this.iconButtonSpotify.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(17, 27);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(359, 24);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.Enter += new System.EventHandler(this.Enter_Username);
            this.textBoxUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.textBoxUserName.Leave += new System.EventHandler(this.Leave_Username);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(19, 18);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(359, 24);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.Enter_Password);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.textBoxPassword.Leave += new System.EventHandler(this.Leave_Password);
            // 
            // iconButtonSignUp
            // 
            this.iconButtonSignUp.BackColor = System.Drawing.Color.Green;
            this.iconButtonSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconButtonSignUp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSignUp.IconColor = System.Drawing.Color.Black;
            this.iconButtonSignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSignUp.Location = new System.Drawing.Point(106, 502);
            this.iconButtonSignUp.Name = "iconButtonSignUp";
            this.iconButtonSignUp.Size = new System.Drawing.Size(223, 33);
            this.iconButtonSignUp.TabIndex = 6;
            this.iconButtonSignUp.Text = "Sign Up";
            this.iconButtonSignUp.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.iconButtonSignUp);
            this.panel3.Controls.Add(this.iconButtonSpotify);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 623);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 1);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24.21818F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sign In";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Location = new System.Drawing.Point(8, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 64);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Location = new System.Drawing.Point(6, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 58);
            this.panel2.TabIndex = 10;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SignUp";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonSpotify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private FontAwesome.Sharp.IconButton iconButtonSignUp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}