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
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Button_Friends = new FontAwesome.Sharp.IconButton();
            this.Button_Follow = new FontAwesome.Sharp.IconButton();
            this.MainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NavBar = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Back = new FontAwesome.Sharp.IconButton();
            this.Button_Next = new FontAwesome.Sharp.IconButton();
            this.UserNav = new System.Windows.Forms.Panel();
            this.Button_User = new FontAwesome.Sharp.IconButton();
            this.NavForm = new System.Windows.Forms.Panel();
            this.PlayBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Button_Add = new FontAwesome.Sharp.IconButton();
            this.Button_Compress = new FontAwesome.Sharp.IconButton();
            this.Button_Random = new FontAwesome.Sharp.IconButton();
            this.Button_Repeat = new FontAwesome.Sharp.IconButton();
            this.Button_Play = new FontAwesome.Sharp.IconButton();
            this.Button_Backward = new FontAwesome.Sharp.IconButton();
            this.Button_Forward = new FontAwesome.Sharp.IconButton();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.MenuBar = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Menu = new FontAwesome.Sharp.IconButton();
            this.Button_Home = new FontAwesome.Sharp.IconButton();
            this.Button_Search = new FontAwesome.Sharp.IconButton();
            this.Button_Playlist = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_LogOut = new FontAwesome.Sharp.IconButton();
            this.MainBackGround = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ContactBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.NavBar.SuspendLayout();
            this.NavForm.SuspendLayout();
            this.PlayBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.MainBackGround.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactBar
            // 
            this.ContactBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactBar.BackColor = System.Drawing.Color.Black;
            this.ContactBar.Controls.Add(this.panel2);
            this.ContactBar.Controls.Add(this.Button_Friends);
            this.ContactBar.Controls.Add(this.Button_Follow);
            this.ContactBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContactBar.Location = new System.Drawing.Point(945, 0);
            this.ContactBar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ContactBar.Name = "ContactBar";
            this.ContactBar.Size = new System.Drawing.Size(248, 746);
            this.ContactBar.TabIndex = 3;
            this.ContactBar.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Button_Close_ContactBar);
            this.panel2.Controls.Add(this.guna2ControlBox3);
            this.panel2.Controls.Add(this.guna2ControlBox1);
            this.panel2.Controls.Add(this.guna2ControlBox2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 45);
            this.panel2.TabIndex = 7;
            // 
            // Button_Close_ContactBar
            // 
            this.Button_Close_ContactBar.BackColor = System.Drawing.Color.Black;
            this.Button_Close_ContactBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close_ContactBar.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.Button_Close_ContactBar.IconColor = System.Drawing.Color.White;
            this.Button_Close_ContactBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Close_ContactBar.IconSize = 25;
            this.Button_Close_ContactBar.Location = new System.Drawing.Point(190, 3);
            this.Button_Close_ContactBar.Name = "Button_Close_ContactBar";
            this.Button_Close_ContactBar.Size = new System.Drawing.Size(55, 39);
            this.Button_Close_ContactBar.TabIndex = 0;
            this.Button_Close_ContactBar.UseVisualStyleBackColor = false;
            this.Button_Close_ContactBar.Click += new System.EventHandler(this.Button_Close_ContactBar_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2ControlBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(59, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(50, 39);
            this.guna2ControlBox3.TabIndex = 9;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(115, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(50, 40);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2ControlBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(4, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(50, 39);
            this.guna2ControlBox2.TabIndex = 10;
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
            this.MainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MainLayout.Controls.Add(this.NavBar);
            this.MainLayout.Controls.Add(this.NavForm);
            this.MainLayout.Controls.Add(this.PlayBar);
            this.MainLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainLayout.Location = new System.Drawing.Point(241, 3);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Size = new System.Drawing.Size(704, 743);
            this.MainLayout.TabIndex = 2;
            this.MainLayout.Resize += new System.EventHandler(this.FormMainMenu_Resize);
            // 
            // NavBar
            // 
            this.NavBar.Controls.Add(this.Button_Back);
            this.NavBar.Controls.Add(this.Button_Next);
            this.NavBar.Controls.Add(this.UserNav);
            this.NavBar.Controls.Add(this.Button_User);
            this.NavBar.Location = new System.Drawing.Point(3, 3);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(698, 58);
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
            this.Button_User.Click += new System.EventHandler(this.Button_User_Click);
            // 
            // NavForm
            // 
            this.NavForm.Controls.Add(this.panel4);
            this.NavForm.Location = new System.Drawing.Point(0, 64);
            this.NavForm.Margin = new System.Windows.Forms.Padding(0);
            this.NavForm.Name = "NavForm";
            this.NavForm.Size = new System.Drawing.Size(703, 520);
            this.NavForm.TabIndex = 10;
            this.NavForm.Resize += new System.EventHandler(this.FormMainMenu_Resize);
            // 
            // PlayBar
            // 
            this.PlayBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayBar.BackColor = System.Drawing.Color.Black;
            this.PlayBar.Controls.Add(this.panel3);
            this.PlayBar.Controls.Add(this.MusicPlayer);
            this.PlayBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PlayBar.Location = new System.Drawing.Point(0, 584);
            this.PlayBar.Margin = new System.Windows.Forms.Padding(0);
            this.PlayBar.Name = "PlayBar";
            this.PlayBar.Size = new System.Drawing.Size(704, 140);
            this.PlayBar.TabIndex = 9;
            this.PlayBar.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Button_Add);
            this.panel3.Controls.Add(this.Button_Compress);
            this.panel3.Controls.Add(this.Button_Random);
            this.panel3.Controls.Add(this.Button_Repeat);
            this.panel3.Controls.Add(this.Button_Play);
            this.panel3.Controls.Add(this.Button_Backward);
            this.panel3.Controls.Add(this.Button_Forward);
            this.panel3.Location = new System.Drawing.Point(130, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 58);
            this.panel3.TabIndex = 8;
            // 
            // Button_Add
            // 
            this.Button_Add.FlatAppearance.BorderSize = 0;
            this.Button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.Button_Add.IconColor = System.Drawing.Color.White;
            this.Button_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Add.IconSize = 30;
            this.Button_Add.Location = new System.Drawing.Point(3, 22);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(77, 32);
            this.Button_Add.TabIndex = 4;
            this.Button_Add.UseVisualStyleBackColor = true;
            // 
            // Button_Compress
            // 
            this.Button_Compress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Compress.FlatAppearance.BorderSize = 0;
            this.Button_Compress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Compress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Compress.IconChar = FontAwesome.Sharp.IconChar.CompressAlt;
            this.Button_Compress.IconColor = System.Drawing.Color.White;
            this.Button_Compress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Compress.IconSize = 30;
            this.Button_Compress.Location = new System.Drawing.Point(368, 22);
            this.Button_Compress.Name = "Button_Compress";
            this.Button_Compress.Size = new System.Drawing.Size(72, 32);
            this.Button_Compress.TabIndex = 3;
            this.Button_Compress.UseVisualStyleBackColor = true;
            this.Button_Compress.Click += new System.EventHandler(this.Button_Compress_Click);
            // 
            // Button_Random
            // 
            this.Button_Random.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Random.BackColor = System.Drawing.Color.Transparent;
            this.Button_Random.FlatAppearance.BorderSize = 0;
            this.Button_Random.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Random.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.Button_Random.IconColor = System.Drawing.Color.White;
            this.Button_Random.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Random.IconSize = 30;
            this.Button_Random.Location = new System.Drawing.Point(57, 22);
            this.Button_Random.Name = "Button_Random";
            this.Button_Random.Size = new System.Drawing.Size(75, 32);
            this.Button_Random.TabIndex = 2;
            this.Button_Random.UseVisualStyleBackColor = false;
            // 
            // Button_Repeat
            // 
            this.Button_Repeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Repeat.BackColor = System.Drawing.Color.Transparent;
            this.Button_Repeat.FlatAppearance.BorderSize = 0;
            this.Button_Repeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Repeat.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.Button_Repeat.IconColor = System.Drawing.Color.White;
            this.Button_Repeat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Repeat.IconSize = 30;
            this.Button_Repeat.Location = new System.Drawing.Point(309, 22);
            this.Button_Repeat.Name = "Button_Repeat";
            this.Button_Repeat.Size = new System.Drawing.Size(76, 32);
            this.Button_Repeat.TabIndex = 2;
            this.Button_Repeat.UseVisualStyleBackColor = false;
            // 
            // Button_Play
            // 
            this.Button_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Play.BackColor = System.Drawing.Color.Transparent;
            this.Button_Play.FlatAppearance.BorderSize = 0;
            this.Button_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Play.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Play.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.Button_Play.IconColor = System.Drawing.Color.White;
            this.Button_Play.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Play.IconSize = 35;
            this.Button_Play.Location = new System.Drawing.Point(198, 5);
            this.Button_Play.Name = "Button_Play";
            this.Button_Play.Size = new System.Drawing.Size(53, 49);
            this.Button_Play.TabIndex = 0;
            this.Button_Play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Play.UseVisualStyleBackColor = false;
            this.Button_Play.Click += new System.EventHandler(this.Button_Play_Click);
            // 
            // Button_Backward
            // 
            this.Button_Backward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Backward.FlatAppearance.BorderSize = 0;
            this.Button_Backward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Backward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Backward.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.Button_Backward.IconColor = System.Drawing.Color.White;
            this.Button_Backward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Backward.IconSize = 35;
            this.Button_Backward.Location = new System.Drawing.Point(136, 5);
            this.Button_Backward.Name = "Button_Backward";
            this.Button_Backward.Size = new System.Drawing.Size(56, 49);
            this.Button_Backward.TabIndex = 1;
            this.Button_Backward.UseVisualStyleBackColor = true;
            // 
            // Button_Forward
            // 
            this.Button_Forward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Forward.FlatAppearance.BorderSize = 0;
            this.Button_Forward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Forward.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.Button_Forward.IconColor = System.Drawing.Color.White;
            this.Button_Forward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Forward.IconSize = 35;
            this.Button_Forward.Location = new System.Drawing.Point(247, 5);
            this.Button_Forward.Name = "Button_Forward";
            this.Button_Forward.Size = new System.Drawing.Size(56, 49);
            this.Button_Forward.TabIndex = 1;
            this.Button_Forward.UseVisualStyleBackColor = true;
            this.Button_Forward.Click += new System.EventHandler(this.Button_Forward_Click);
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(3, 64);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(698, 98);
            this.MusicPlayer.TabIndex = 7;
            // 
            // MenuBar
            // 
            this.MenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuBar.BackColor = System.Drawing.Color.Black;
            this.MenuBar.Controls.Add(this.Button_Menu);
            this.MenuBar.Controls.Add(this.Button_Home);
            this.MenuBar.Controls.Add(this.Button_Search);
            this.MenuBar.Controls.Add(this.Button_Playlist);
            this.MenuBar.Controls.Add(this.panel1);
            this.MenuBar.Controls.Add(this.Button_LogOut);
            this.MenuBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(241, 749);
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
            this.Button_Playlist.Click += new System.EventHandler(this.Button_Playlist_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(3, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 463);
            this.panel1.TabIndex = 6;
            // 
            // Button_LogOut
            // 
            this.Button_LogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_LogOut.FlatAppearance.BorderSize = 0;
            this.Button_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_LogOut.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.Button_LogOut.IconColor = System.Drawing.Color.White;
            this.Button_LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_LogOut.IconSize = 40;
            this.Button_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_LogOut.Location = new System.Drawing.Point(3, 688);
            this.Button_LogOut.Name = "Button_LogOut";
            this.Button_LogOut.Size = new System.Drawing.Size(231, 48);
            this.Button_LogOut.TabIndex = 6;
            this.Button_LogOut.Text = "   Log Out";
            this.Button_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_LogOut.UseVisualStyleBackColor = true;
            this.Button_LogOut.Click += new System.EventHandler(this.Button_LogOut_Click);
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
            this.MainBackGround.Size = new System.Drawing.Size(1223, 773);
            this.MainBackGround.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(501, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            this.panel4.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 773);
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
            this.NavForm.ResumeLayout(false);
            this.PlayBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MainBackGround.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel PlayBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Panel NavForm;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Button_LogOut;
        private FontAwesome.Sharp.IconButton Button_Random;
        private FontAwesome.Sharp.IconButton Button_Repeat;
        private FontAwesome.Sharp.IconButton Button_Add;
        private FontAwesome.Sharp.IconButton Button_Compress;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
    }
}