namespace Music.Net_App.View
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.HomeLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.VideoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.IntroVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.RecentPlayed = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.TopMixes = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.HomeLayout.SuspendLayout();
            this.VideoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntroVideo)).BeginInit();
            this.RecentPlayed.SuspendLayout();
            this.TopMixes.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeLayout
            // 
            this.HomeLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.HomeLayout.Controls.Add(this.VideoPanel);
            this.HomeLayout.Controls.Add(this.RecentPlayed);
            this.HomeLayout.Controls.Add(this.TopMixes);
            this.HomeLayout.Location = new System.Drawing.Point(0, 6);
            this.HomeLayout.Margin = new System.Windows.Forms.Padding(0);
            this.HomeLayout.Name = "HomeLayout";
            this.HomeLayout.Size = new System.Drawing.Size(879, 523);
            this.HomeLayout.TabIndex = 3;
            // 
            // VideoPanel
            // 
            this.VideoPanel.Controls.Add(this.IntroVideo);
            this.VideoPanel.Location = new System.Drawing.Point(3, 3);
            this.VideoPanel.Name = "VideoPanel";
            this.VideoPanel.Size = new System.Drawing.Size(697, 362);
            this.VideoPanel.TabIndex = 4;
            // 
            // IntroVideo
            // 
            this.IntroVideo.Enabled = true;
            this.IntroVideo.Location = new System.Drawing.Point(3, 3);
            this.IntroVideo.Name = "IntroVideo";
            this.IntroVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("IntroVideo.OcxState")));
            this.IntroVideo.Size = new System.Drawing.Size(688, 404);
            this.IntroVideo.TabIndex = 0;
            // 
            // RecentPlayed
            // 
            this.RecentPlayed.Controls.Add(this.iconButton4);
            this.RecentPlayed.Location = new System.Drawing.Point(3, 371);
            this.RecentPlayed.Name = "RecentPlayed";
            this.RecentPlayed.Size = new System.Drawing.Size(697, 55);
            this.RecentPlayed.TabIndex = 1;
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 40;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(3, 3);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(159, 36);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "Recent Played";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // TopMixes
            // 
            this.TopMixes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMixes.Controls.Add(this.iconButton5);
            this.TopMixes.Location = new System.Drawing.Point(3, 432);
            this.TopMixes.Name = "TopMixes";
            this.TopMixes.Size = new System.Drawing.Size(697, 55);
            this.TopMixes.TabIndex = 3;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 40;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(3, 3);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(159, 36);
            this.iconButton5.TabIndex = 3;
            this.iconButton5.Text = "Your Top Mixes";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(878, 726);
            this.Controls.Add(this.HomeLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Resize += new System.EventHandler(this.HomeForm_Resize);
            this.HomeLayout.ResumeLayout(false);
            this.VideoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IntroVideo)).EndInit();
            this.RecentPlayed.ResumeLayout(false);
            this.TopMixes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel HomeLayout;
        private System.Windows.Forms.FlowLayoutPanel VideoPanel;
        private AxWMPLib.AxWindowsMediaPlayer IntroVideo;
        private System.Windows.Forms.FlowLayoutPanel RecentPlayed;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.FlowLayoutPanel TopMixes;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}