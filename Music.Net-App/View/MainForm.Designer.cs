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
            this.ContactBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button_Close_ContactBar = new FontAwesome.Sharp.IconButton();
            this.Button_Friends = new FontAwesome.Sharp.IconButton();
            this.Button_Follow = new FontAwesome.Sharp.IconButton();
            this.MainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NavBar = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Back = new FontAwesome.Sharp.IconButton();
            this.Button_Next = new FontAwesome.Sharp.IconButton();
            this.UserNav = new System.Windows.Forms.Panel();
            this.Button_User = new FontAwesome.Sharp.IconButton();
            this.NavForm = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Button_Forward = new FontAwesome.Sharp.IconButton();
            this.Button_Backward = new FontAwesome.Sharp.IconButton();
            this.Button_Play = new FontAwesome.Sharp.IconButton();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.MenuBar = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Menu = new FontAwesome.Sharp.IconButton();
            this.Button_Home = new FontAwesome.Sharp.IconButton();
            this.Button_Search = new FontAwesome.Sharp.IconButton();
            this.Button_Playlist = new FontAwesome.Sharp.IconButton();
            this.MainBackGround = new System.Windows.Forms.FlowLayoutPanel();
            this.ContactBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.NavBar.SuspendLayout();
            this.PlayBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.MainBackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactBar
            // 
            this.ContactBar.BackColor = System.Drawing.Color.Black;
            this.ContactBar.Controls.Add(this.panel2);
            this.ContactBar.Controls.Add(this.Button_Friends);
            this.ContactBar.Controls.Add(this.Button_Follow);
            this.ContactBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContactBar.Location = new System.Drawing.Point(940, 3);
            this.ContactBar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ContactBar.Name = "ContactBar";
            this.ContactBar.Size = new System.Drawing.Size(242, 746);
            this.ContactBar.TabIndex = 3;
            this.ContactBar.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Button_Close_ContactBar);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 45);
            this.panel2.TabIndex = 7;
            // 
            // Button_Close_ContactBar
            // 
            this.Button_Close_ContactBar.BackColor = System.Drawing.Color.Black;
            this.Button_Close_ContactBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close_ContactBar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Button_Close_ContactBar.IconColor = System.Drawing.Color.White;
            this.Button_Close_ContactBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Close_ContactBar.IconSize = 25;
            this.Button_Close_ContactBar.Location = new System.Drawing.Point(169, 0);
            this.Button_Close_ContactBar.Name = "Button_Close_ContactBar";
            this.Button_Close_ContactBar.Size = new System.Drawing.Size(49, 45);
            this.Button_Close_ContactBar.TabIndex = 0;
            this.Button_Close_ContactBar.UseVisualStyleBackColor = false;
            this.Button_Close_ContactBar.Click += new System.EventHandler(this.Button_Close_ContactBar_Click);
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
            this.Button_Friends.Location = new System.Drawing.Point(3, 54);
            this.Button_Friends.Name = "Button_Friends";
            this.Button_Friends.Size = new System.Drawing.Size(218, 48);
            this.Button_Friends.TabIndex = 5;
            this.Button_Friends.Text = "   Friends";
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
            this.Button_Follow.Location = new System.Drawing.Point(3, 108);
            this.Button_Follow.Name = "Button_Follow";
            this.Button_Follow.Size = new System.Drawing.Size(218, 48);
            this.Button_Follow.TabIndex = 6;
            this.Button_Follow.Text = "   Follow";
            this.Button_Follow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Follow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Follow.UseVisualStyleBackColor = true;
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MainLayout.Controls.Add(this.NavBar);
            this.MainLayout.Controls.Add(this.NavForm);
            this.MainLayout.Controls.Add(this.PlayBar);
            this.MainLayout.Location = new System.Drawing.Point(244, 3);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Size = new System.Drawing.Size(696, 741);
            this.MainLayout.TabIndex = 2;
            // 
            // NavBar
            // 
            this.NavBar.Controls.Add(this.Button_Back);
            this.NavBar.Controls.Add(this.Button_Next);
            this.NavBar.Controls.Add(this.UserNav);
            this.NavBar.Controls.Add(this.Button_User);
            this.NavBar.Location = new System.Drawing.Point(3, 3);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(693, 58);
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
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
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
            // NavForm
            // 
            this.NavForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.NavForm.Location = new System.Drawing.Point(3, 67);
            this.NavForm.Name = "NavForm";
            this.NavForm.Size = new System.Drawing.Size(688, 504);
            this.NavForm.TabIndex = 1;
            this.NavForm.Resize += new System.EventHandler(this.FormMainMenu_Resize);
            // 
            // PlayBar
            // 
            this.PlayBar.BackColor = System.Drawing.Color.Black;
            this.PlayBar.Controls.Add(this.panel3);
            this.PlayBar.Controls.Add(this.MusicPlayer);
            this.PlayBar.Location = new System.Drawing.Point(0, 577);
            this.PlayBar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.PlayBar.Name = "PlayBar";
            this.PlayBar.Size = new System.Drawing.Size(694, 91);
            this.PlayBar.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.Button_Forward);
            this.panel3.Controls.Add(this.Button_Backward);
            this.panel3.Controls.Add(this.Button_Play);
            this.panel3.Location = new System.Drawing.Point(6, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 58);
            this.panel3.TabIndex = 8;
            // 
            // Button_Forward
            // 
            this.Button_Forward.FlatAppearance.BorderSize = 0;
            this.Button_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Forward.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.Button_Forward.IconColor = System.Drawing.Color.White;
            this.Button_Forward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Forward.IconSize = 30;
            this.Button_Forward.Location = new System.Drawing.Point(123, 5);
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
            // Button_Play
            // 
            this.Button_Play.BackColor = System.Drawing.Color.Black;
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
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(205, 0);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(477, 138);
            this.MusicPlayer.TabIndex = 7;
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
            this.Button_Menu.Size = new System.Drawing.Size(54, 48);
            this.Button_Menu.TabIndex = 5;
            this.Button_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Menu.UseVisualStyleBackColor = true;
            this.Button_Menu.Click += new System.EventHandler(this.Button_Menu_Click);
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
            this.Button_Home.Text = "    Home";
            this.Button_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Home.UseVisualStyleBackColor = true;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
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
            this.Button_Search.Text = "   Search";
            this.Button_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
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
            this.Button_Playlist.Text = "   Your Playlist";
            this.Button_Playlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Playlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Playlist.UseVisualStyleBackColor = true;
            // 
            // MainBackGround
            // 
            this.MainBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MainBackGround.Controls.Add(this.MenuBar);
            this.MainBackGround.Controls.Add(this.MainLayout);
            this.MainBackGround.Controls.Add(this.ContactBar);
            this.MainBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBackGround.Location = new System.Drawing.Point(0, 0);
            this.MainBackGround.Name = "MainBackGround";
            this.MainBackGround.Size = new System.Drawing.Size(1182, 744);
            this.MainBackGround.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 744);
            this.Controls.Add(this.MainBackGround);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 791);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Resize += new System.EventHandler(this.FormMainMenu_Resize);
            this.ContactBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.NavBar.ResumeLayout(false);
            this.PlayBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MainBackGround.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ContactBar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Button_Close_ContactBar;
        private FontAwesome.Sharp.IconButton Button_Friends;
        private FontAwesome.Sharp.IconButton Button_Follow;
        private System.Windows.Forms.FlowLayoutPanel MainLayout;
        private System.Windows.Forms.FlowLayoutPanel NavBar;
        private FontAwesome.Sharp.IconButton Button_Back;
        private FontAwesome.Sharp.IconButton Button_Next;
        private System.Windows.Forms.Panel UserNav;
        private FontAwesome.Sharp.IconButton Button_User;
        private System.Windows.Forms.FlowLayoutPanel NavForm;
        private System.Windows.Forms.Panel PlayBar;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton Button_Forward;
        private FontAwesome.Sharp.IconButton Button_Backward;
        private FontAwesome.Sharp.IconButton Button_Play;
        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        private System.Windows.Forms.FlowLayoutPanel MenuBar;
        private FontAwesome.Sharp.IconButton Button_Menu;
        private FontAwesome.Sharp.IconButton Button_Home;
        private FontAwesome.Sharp.IconButton Button_Search;
        private FontAwesome.Sharp.IconButton Button_Playlist;
        private System.Windows.Forms.FlowLayoutPanel MainBackGround;
    }
}