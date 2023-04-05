namespace Music.Net_App.View
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
            this.MenuBar = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Menu = new FontAwesome.Sharp.IconButton();
            this.Button_Home = new FontAwesome.Sharp.IconButton();
            this.Button_Search = new FontAwesome.Sharp.IconButton();
            this.Button_Playlist = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.HomeLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NavBar = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Back = new FontAwesome.Sharp.IconButton();
            this.Button_Next = new FontAwesome.Sharp.IconButton();
            this.UserNav = new System.Windows.Forms.Panel();
            this.Button_User = new FontAwesome.Sharp.IconButton();
            this.VideoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.IntroVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.RecentPlayed = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.TopMixes = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.ContactBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button_Friends = new FontAwesome.Sharp.IconButton();
            this.Button_Follow = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Button_Play = new FontAwesome.Sharp.IconButton();
            this.Button_Forward = new FontAwesome.Sharp.IconButton();
            this.Button_Backward = new FontAwesome.Sharp.IconButton();
            this.MenuBar.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.HomeLayout.SuspendLayout();
            this.NavBar.SuspendLayout();
            this.VideoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntroVideo)).BeginInit();
            this.RecentPlayed.SuspendLayout();
            this.TopMixes.SuspendLayout();
            this.ContactBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.Black;
            this.MenuBar.Controls.Add(this.Button_Menu);
            this.MenuBar.Controls.Add(this.Button_Home);
            this.MenuBar.Controls.Add(this.Button_Search);
            this.MenuBar.Controls.Add(this.Button_Playlist);
            this.MenuBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(244, 752);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.WrapContents = false;
            // 
            // Button_Menu
            // 
            this.Button_Menu.FlatAppearance.BorderSize = 0;
            this.Button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Menu.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.Button_Menu.IconColor = System.Drawing.Color.White;
            this.Button_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Menu.IconSize = 40;
            this.Button_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Menu.Location = new System.Drawing.Point(3, 3);
            this.Button_Menu.Name = "Button_Menu";
            this.Button_Menu.Size = new System.Drawing.Size(48, 48);
            this.Button_Menu.TabIndex = 5;
            this.Button_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Menu.UseVisualStyleBackColor = true;
            // 
            // Button_Home
            // 
            this.Button_Home.FlatAppearance.BorderSize = 0;
            this.Button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Home.IconChar = FontAwesome.Sharp.IconChar.House;
            this.Button_Home.IconColor = System.Drawing.Color.White;
            this.Button_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Home.IconSize = 40;
            this.Button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Home.Location = new System.Drawing.Point(3, 57);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(231, 48);
            this.Button_Home.TabIndex = 2;
            this.Button_Home.Text = "Home";
            this.Button_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Home.UseVisualStyleBackColor = true;
            // 
            // Button_Search
            // 
            this.Button_Search.FlatAppearance.BorderSize = 0;
            this.Button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassChart;
            this.Button_Search.IconColor = System.Drawing.Color.White;
            this.Button_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Search.IconSize = 40;
            this.Button_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Search.Location = new System.Drawing.Point(3, 111);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(231, 48);
            this.Button_Search.TabIndex = 3;
            this.Button_Search.Text = "Search";
            this.Button_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Search.UseVisualStyleBackColor = true;
            // 
            // Button_Playlist
            // 
            this.Button_Playlist.FlatAppearance.BorderSize = 0;
            this.Button_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Playlist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Playlist.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.Button_Playlist.IconColor = System.Drawing.Color.White;
            this.Button_Playlist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Playlist.IconSize = 40;
            this.Button_Playlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Playlist.Location = new System.Drawing.Point(3, 165);
            this.Button_Playlist.Name = "Button_Playlist";
            this.Button_Playlist.Size = new System.Drawing.Size(231, 48);
            this.Button_Playlist.TabIndex = 4;
            this.Button_Playlist.Text = "Your Playlist";
            this.Button_Playlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Playlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Playlist.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.flowLayoutPanel2.Controls.Add(this.MenuBar);
            this.flowLayoutPanel2.Controls.Add(this.HomeLayout);
            this.flowLayoutPanel2.Controls.Add(this.ContactBar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1182, 744);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // HomeLayout
            // 
            this.HomeLayout.Controls.Add(this.NavBar);
            this.HomeLayout.Controls.Add(this.VideoPanel);
            this.HomeLayout.Controls.Add(this.RecentPlayed);
            this.HomeLayout.Controls.Add(this.TopMixes);
            this.HomeLayout.Controls.Add(this.panel1);
            this.HomeLayout.Location = new System.Drawing.Point(247, 3);
            this.HomeLayout.Name = "HomeLayout";
            this.HomeLayout.Size = new System.Drawing.Size(696, 752);
            this.HomeLayout.TabIndex = 2;
            // 
            // NavBar
            // 
            this.NavBar.Controls.Add(this.Button_Back);
            this.NavBar.Controls.Add(this.Button_Next);
            this.NavBar.Controls.Add(this.UserNav);
            this.NavBar.Controls.Add(this.Button_User);
            this.NavBar.Location = new System.Drawing.Point(3, 3);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(693, 99);
            this.NavBar.TabIndex = 0;
            // 
            // Button_Back
            // 
            this.Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Back.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.Button_Back.IconColor = System.Drawing.Color.White;
            this.Button_Back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Back.IconSize = 35;
            this.Button_Back.Location = new System.Drawing.Point(3, 3);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(50, 45);
            this.Button_Back.TabIndex = 0;
            this.Button_Back.UseVisualStyleBackColor = true;
            // 
            // Button_Next
            // 
            this.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Next.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            this.Button_Next.IconColor = System.Drawing.Color.White;
            this.Button_Next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Next.IconSize = 35;
            this.Button_Next.Location = new System.Drawing.Point(59, 3);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(50, 45);
            this.Button_Next.TabIndex = 1;
            this.Button_Next.UseVisualStyleBackColor = true;
            // 
            // UserNav
            // 
            this.UserNav.Location = new System.Drawing.Point(112, 0);
            this.UserNav.Margin = new System.Windows.Forms.Padding(0);
            this.UserNav.Name = "UserNav";
            this.UserNav.Size = new System.Drawing.Size(486, 48);
            this.UserNav.TabIndex = 2;
            // 
            // Button_User
            // 
            this.Button_User.FlatAppearance.BorderSize = 0;
            this.Button_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_User.ForeColor = System.Drawing.Color.White;
            this.Button_User.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.Button_User.IconColor = System.Drawing.Color.White;
            this.Button_User.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_User.IconSize = 35;
            this.Button_User.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_User.Location = new System.Drawing.Point(598, 0);
            this.Button_User.Margin = new System.Windows.Forms.Padding(0);
            this.Button_User.Name = "Button_User";
            this.Button_User.Size = new System.Drawing.Size(90, 45);
            this.Button_User.TabIndex = 0;
            this.Button_User.Text = "User";
            this.Button_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_User.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button_User.UseVisualStyleBackColor = true;
            // 
            // VideoPanel
            // 
            this.VideoPanel.Controls.Add(this.IntroVideo);
            this.VideoPanel.Location = new System.Drawing.Point(3, 108);
            this.VideoPanel.Name = "VideoPanel";
            this.VideoPanel.Size = new System.Drawing.Size(697, 139);
            this.VideoPanel.TabIndex = 4;
            // 
            // IntroVideo
            // 
            this.IntroVideo.Enabled = true;
            this.IntroVideo.Location = new System.Drawing.Point(3, 3);
            this.IntroVideo.Name = "IntroVideo";
            this.IntroVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("IntroVideo.OcxState")));
            this.IntroVideo.Size = new System.Drawing.Size(694, 314);
            this.IntroVideo.TabIndex = 0;
            // 
            // RecentPlayed
            // 
            this.RecentPlayed.Controls.Add(this.iconButton4);
            this.RecentPlayed.Location = new System.Drawing.Point(3, 253);
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
            this.TopMixes.Controls.Add(this.iconButton5);
            this.TopMixes.Location = new System.Drawing.Point(3, 314);
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
            // ContactBar
            // 
            this.ContactBar.BackColor = System.Drawing.Color.Black;
            this.ContactBar.Controls.Add(this.panel2);
            this.ContactBar.Controls.Add(this.Button_Friends);
            this.ContactBar.Controls.Add(this.Button_Follow);
            this.ContactBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContactBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContactBar.Location = new System.Drawing.Point(949, 3);
            this.ContactBar.Name = "ContactBar";
            this.ContactBar.Size = new System.Drawing.Size(226, 752);
            this.ContactBar.TabIndex = 3;
            this.ContactBar.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 24);
            this.panel2.TabIndex = 7;
            // 
            // Button_Friends
            // 
            this.Button_Friends.FlatAppearance.BorderSize = 0;
            this.Button_Friends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Friends.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Friends.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.Button_Friends.IconColor = System.Drawing.Color.White;
            this.Button_Friends.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Friends.IconSize = 40;
            this.Button_Friends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Friends.Location = new System.Drawing.Point(3, 33);
            this.Button_Friends.Name = "Button_Friends";
            this.Button_Friends.Size = new System.Drawing.Size(218, 48);
            this.Button_Friends.TabIndex = 5;
            this.Button_Friends.Text = "Friends";
            this.Button_Friends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Friends.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Friends.UseVisualStyleBackColor = true;
            // 
            // Button_Follow
            // 
            this.Button_Follow.FlatAppearance.BorderSize = 0;
            this.Button_Follow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Follow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Follow.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.Button_Follow.IconColor = System.Drawing.Color.White;
            this.Button_Follow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Follow.IconSize = 40;
            this.Button_Follow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Follow.Location = new System.Drawing.Point(3, 87);
            this.Button_Follow.Name = "Button_Follow";
            this.Button_Follow.Size = new System.Drawing.Size(218, 48);
            this.Button_Follow.TabIndex = 6;
            this.Button_Follow.Text = "Follow";
            this.Button_Follow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Follow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Follow.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(3, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 153);
            this.panel1.TabIndex = 6;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(188, 103);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(505, 110);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Button_Forward);
            this.panel3.Controls.Add(this.Button_Backward);
            this.panel3.Controls.Add(this.Button_Play);
            this.panel3.Location = new System.Drawing.Point(3, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 47);
            this.panel3.TabIndex = 8;
            // 
            // Button_Play
            // 
            this.Button_Play.BackColor = System.Drawing.Color.Transparent;
            this.Button_Play.FlatAppearance.BorderSize = 0;
            this.Button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Play.ForeColor = System.Drawing.Color.White;
            this.Button_Play.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.Button_Play.IconColor = System.Drawing.Color.White;
            this.Button_Play.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Play.IconSize = 30;
            this.Button_Play.Location = new System.Drawing.Point(56, 5);
            this.Button_Play.Name = "Button_Play";
            this.Button_Play.Size = new System.Drawing.Size(53, 42);
            this.Button_Play.TabIndex = 0;
            this.Button_Play.UseVisualStyleBackColor = false;
            this.Button_Play.Click += new System.EventHandler(this.Button_Play_Click);
            // 
            // Button_Forward
            // 
            this.Button_Forward.FlatAppearance.BorderSize = 0;
            this.Button_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Forward.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.Button_Forward.IconColor = System.Drawing.Color.White;
            this.Button_Forward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Forward.IconSize = 30;
            this.Button_Forward.Location = new System.Drawing.Point(120, 3);
            this.Button_Forward.Name = "Button_Forward";
            this.Button_Forward.Size = new System.Drawing.Size(56, 44);
            this.Button_Forward.TabIndex = 1;
            this.Button_Forward.UseVisualStyleBackColor = true;
            // 
            // Button_Backward
            // 
            this.Button_Backward.FlatAppearance.BorderSize = 0;
            this.Button_Backward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Backward.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.Button_Backward.IconColor = System.Drawing.Color.White;
            this.Button_Backward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Backward.IconSize = 30;
            this.Button_Backward.Location = new System.Drawing.Point(-6, 3);
            this.Button_Backward.Name = "Button_Backward";
            this.Button_Backward.Size = new System.Drawing.Size(56, 44);
            this.Button_Backward.TabIndex = 1;
            this.Button_Backward.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 744);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Resize += new System.EventHandler(this.FormMainMenu_Resize);
            this.MenuBar.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.HomeLayout.ResumeLayout(false);
            this.NavBar.ResumeLayout(false);
            this.VideoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IntroVideo)).EndInit();
            this.RecentPlayed.ResumeLayout(false);
            this.TopMixes.ResumeLayout(false);
            this.ContactBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel MenuBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton Button_Home;
        private FontAwesome.Sharp.IconButton Button_Search;
        private FontAwesome.Sharp.IconButton Button_Playlist;
        private FontAwesome.Sharp.IconButton Button_Menu;
        private System.Windows.Forms.FlowLayoutPanel HomeLayout;
        private System.Windows.Forms.FlowLayoutPanel NavBar;
        private System.Windows.Forms.FlowLayoutPanel ContactBar;
        private FontAwesome.Sharp.IconButton Button_Friends;
        private FontAwesome.Sharp.IconButton Button_Back;
        private FontAwesome.Sharp.IconButton Button_Next;
        private System.Windows.Forms.Panel UserNav;
        private FontAwesome.Sharp.IconButton Button_User;
        private FontAwesome.Sharp.IconButton Button_Follow;
        private System.Windows.Forms.FlowLayoutPanel RecentPlayed;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.FlowLayoutPanel TopMixes;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.FlowLayoutPanel VideoPanel;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer IntroVideo;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton Button_Play;
        private FontAwesome.Sharp.IconButton Button_Forward;
        private FontAwesome.Sharp.IconButton Button_Backward;
    }
}