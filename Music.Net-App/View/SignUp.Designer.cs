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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButtonSpotify = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonSignUp = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.flowLayoutPanel1.Controls.Add(this.iconButtonSpotify);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBoxUserName);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBoxPassword);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(370, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(445, 623);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.iconButtonSpotify.Location = new System.Drawing.Point(3, 3);
            this.iconButtonSpotify.Name = "iconButtonSpotify";
            this.iconButtonSpotify.Size = new System.Drawing.Size(436, 130);
            this.iconButtonSpotify.TabIndex = 0;
            this.iconButtonSpotify.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 139);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(436, 223);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(3, 390);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(436, 24);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.Enter += new System.EventHandler(this.Enter_Username);
            this.textBoxUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.textBoxUserName.Leave += new System.EventHandler(this.Leave_Username);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(3, 442);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(436, 24);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.Enter_Password);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.textBoxPassword.Leave += new System.EventHandler(this.Leave_Password);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 472);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(436, 35);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonSignUp);
            this.panel1.Location = new System.Drawing.Point(3, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 47);
            this.panel1.TabIndex = 7;
            // 
            // iconButtonSignUp
            // 
            this.iconButtonSignUp.BackColor = System.Drawing.Color.Green;
            this.iconButtonSignUp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSignUp.IconColor = System.Drawing.Color.Black;
            this.iconButtonSignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSignUp.Location = new System.Drawing.Point(107, 3);
            this.iconButtonSignUp.Name = "iconButtonSignUp";
            this.iconButtonSignUp.Size = new System.Drawing.Size(223, 33);
            this.iconButtonSignUp.TabIndex = 6;
            this.iconButtonSignUp.Text = "Sign Up";
            this.iconButtonSignUp.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 210);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25455F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đăng nhập";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButtonSpotify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private FontAwesome.Sharp.IconButton iconButtonSignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}