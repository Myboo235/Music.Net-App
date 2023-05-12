namespace Music.Net_App.View.Listener
{
    partial class MinimizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinimizeForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Button_Play = new FontAwesome.Sharp.IconButton();
            this.Button_Backward = new FontAwesome.Sharp.IconButton();
            this.Button_Forward = new FontAwesome.Sharp.IconButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.Button_Play);
            this.panel3.Controls.Add(this.Button_Backward);
            this.panel3.Controls.Add(this.Button_Forward);
            this.panel3.Location = new System.Drawing.Point(2, 341);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 59);
            this.panel3.TabIndex = 9;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(302, 9);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(84, 38);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Button_Play
            // 
            this.Button_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Play.BackColor = System.Drawing.Color.Transparent;
            this.Button_Play.FlatAppearance.BorderSize = 0;
            this.Button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Play.ForeColor = System.Drawing.Color.White;
            this.Button_Play.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.Button_Play.IconColor = System.Drawing.Color.White;
            this.Button_Play.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Play.IconSize = 30;
            this.Button_Play.Location = new System.Drawing.Point(174, 5);
            this.Button_Play.Name = "Button_Play";
            this.Button_Play.Size = new System.Drawing.Size(53, 42);
            this.Button_Play.TabIndex = 0;
            this.Button_Play.UseVisualStyleBackColor = false;
            this.Button_Play.Click += new System.EventHandler(this.Button_Play_Click);
            // 
            // Button_Backward
            // 
            this.Button_Backward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Backward.FlatAppearance.BorderSize = 0;
            this.Button_Backward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Backward.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.Button_Backward.IconColor = System.Drawing.Color.White;
            this.Button_Backward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Backward.IconSize = 30;
            this.Button_Backward.Location = new System.Drawing.Point(112, 5);
            this.Button_Backward.Name = "Button_Backward";
            this.Button_Backward.Size = new System.Drawing.Size(56, 44);
            this.Button_Backward.TabIndex = 1;
            this.Button_Backward.UseVisualStyleBackColor = true;
            // 
            // Button_Forward
            // 
            this.Button_Forward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Forward.FlatAppearance.BorderSize = 0;
            this.Button_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Forward.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.Button_Forward.IconColor = System.Drawing.Color.White;
            this.Button_Forward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Forward.IconSize = 30;
            this.Button_Forward.Location = new System.Drawing.Point(223, 3);
            this.Button_Forward.Name = "Button_Forward";
            this.Button_Forward.Size = new System.Drawing.Size(56, 44);
            this.Button_Forward.TabIndex = 1;
            this.Button_Forward.UseVisualStyleBackColor = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(343, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(2, 220);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(395, 168);
            this.MusicPlayer.TabIndex = 8;
            // 
            // MinimizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MusicPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MinimizeForm";
            this.Text = "Minimize";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton Button_Play;
        private FontAwesome.Sharp.IconButton Button_Backward;
        private FontAwesome.Sharp.IconButton Button_Forward;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}