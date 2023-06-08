using FontAwesome.Sharp;
using Music.Net_App.View.Listener;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using Music.Net_App.DAL;
using Music.Net_App.DTO;
using Music.Net_App.BLL;
using Music.Net_App.View.Artist;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Music.Net_App.View
{
    public partial class MainForm : Form
    {

        private Form currentChildForm;
        private UserDTO User = null;
        private String previousChildFormName = "";
        private Form previousChildForm;
        //private Form nextChildForm;
        private string theme = "default";
        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "") + @"\Assets\Musics\";
        private string currentPlaylistID = "0";

        public MainForm(string email,string typeuser)
        {
            InitializeComponent();
            resize();
            MusicPlayer.Ctlcontrols.stop();

            if(typeuser == "Listener")
            {
                User = UserBLL.Instance.GetListenerByEmail(email);
                Button_Song.Visible = false;
                Button_Album.Visible = false;
            }
            else
            {
                MessageBox.Show(email);
                User = UserBLL.Instance.GetArtistByEmail(email);
                MessageBox.Show(User.TypeUser);
            }
            
            this.FormBorderStyle = FormBorderStyle.None;
            currentChildForm = new HomeForm(User);
            OpenChildForm(currentChildForm);
            SetUpMainForm();
        }

        public void OpenPlaylistSongsForm(object sender, EventArgs e)
        {
            string buttonPlaylistID = (sender as Button).Name;
            if (buttonPlaylistID != currentPlaylistID)
            {
                currentPlaylistID = (sender as Button).Name;
                PlaylistSongsForm f = new PlaylistSongsForm(Convert.ToInt32(buttonPlaylistID));
                OpenChildForm(f);
                f.psd += SetUpMainForm;
            }
            resize();
        }

        public void SetUpMainForm()
        {
            flowLayoutPanel1.Controls.Clear();
            List<PlaylistDTO> playlistofuser = new List<PlaylistDTO>();
            if (User.TypeUser == "Listener")
            {
                playlistofuser = PlaylistBLL.Instance.GetAllPlaylistOfListener(User.UserId);
            }
            else
            {
                playlistofuser = PlaylistBLL.Instance.GetAllPlaylistOfArtist(User.UserId);
            }
            foreach (PlaylistDTO p in playlistofuser)
            {
                IconButton b = new IconButton
                {
                    Name = p.PlaylistId.ToString(),
                    Size = new Size(206, 48),
                    ForeColor = Color.DimGray,
                    Font = new Font("Segoe UI",10,FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Transparent,
                    Text = "#" + p.PlaylistName,
                    TextAlign = ContentAlignment.MiddleLeft,
                    RightToLeft = RightToLeft.No,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    IconChar = IconChar.None,
                    AutoSize = true,
                };
                b.FlatAppearance.BorderSize = 0;
                b.Click += new EventHandler(OpenPlaylistSongsForm);
                flowLayoutPanel1.Controls.Add(b);
            }
        }
        public void SetMusicPlayer(string Song)
        {
            MusicPlayer.URL = directory + @Song + ".mp3";
            Button_Play.IconChar = IconChar.Pause;
        }
        private void LeftBar_MouseHover(object sender, EventArgs e)
        {
            Button buttonHover = (Button)sender;
            buttonHover.ForeColor = Color.White;
            buttonHover.BackColor = ColorTranslator.FromHtml("#777777");
        }
        private void LeftBar_MouseLeave(object sender, EventArgs e)
        {
            Button buttonLeft = (Button)sender;
            buttonLeft.ForeColor = ColorTranslator.FromHtml("#B2B2B2");
            buttonLeft.BackColor = ColorTranslator.FromHtml("#000000");
        }
        private void resize()
        {
            MainLayout.Size = new Size(MainBackGround.Width - MenuBar.Width - ContactBar.Width, MainBackGround.Height);
            UserNav.Width = MainLayout.Width - Button_Back.Width - Button_Next.Width - 120;

            flowLayoutPanel1.Height = MenuBar.Height - 48 * 5 - 70;
            NavBar.Width = MainLayout.Width;

            NavForm.Width = MainLayout.Width;
            NavForm.Height = MainLayout.Height - PlayBar.Height - NavBar.Height -10;

            PlayBar.Width = MainLayout.Width - 10;
            MusicPlayer.Width = MainLayout.Width;

            //MusicPlayer.Width = PlayBar.Width - panel3.Width -50 ;
            if (currentChildForm != null)
            {
                /*if (currentChildForm.Height > NavForm.Height)
                {
                    NavForm.Margin = new Padding(0, 0, 0, 50);

                }*/
                currentChildForm.Margin = new Padding(0, 0, 0, 0);
                currentChildForm.Width = MainLayout.Width;
                //currentChildForm.Height = MainLayout.Height-200;

            }
        }
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            resize();
        }
        private void Button_Search_Click(object sender, EventArgs e)
        {
            //PlayBar.Visible = false;
            if (currentChildForm.GetType().Name.ToString() != "SearchForm")
            {
                SearchForm f = new SearchForm();
                OpenChildForm(f);
                f.sd += SetMusicPlayer;
            }
            resize();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (previousChildForm != null)
            {
                //MessageBox.Show("current is not null");
                NavForm.Controls.Remove(currentChildForm);
                previousChildFormName = currentChildForm.GetType().Name.ToString();
                previousChildForm = currentChildForm;

                if (previousChildFormName == "PlaylistSongsForm")
                    currentPlaylistID = "0";
                Form tempForm = childForm;
                childForm = currentChildForm;
                currentChildForm = tempForm;


                //currentChildForm = childForm;
                currentChildForm.TopLevel = false;
                currentChildForm.FormBorderStyle = FormBorderStyle.None;

                //MainLayout.Controls.Clear();
                //MainLayout.Controls.Add(NavBar);

                //MainLayout.Controls.Add(PlayBar);
                NavForm.Controls.Add(currentChildForm);
                currentChildForm.BringToFront();
                currentChildForm.Show();

                childForm.Close();
                
            }
            else
            {
                //MessageBox.Show("current is null");
                previousChildFormName = currentChildForm.GetType().Name.ToString();
                previousChildForm = currentChildForm;
                currentChildForm.TopLevel = false;
                currentChildForm.FormBorderStyle = FormBorderStyle.None;

                //MainLayout.Controls.Clear();
                //MainLayout.Controls.Add(NavBar);
                currentChildForm = childForm;
                //MainLayout.Controls.Add(PlayBar);
                NavForm.Controls.Add(currentChildForm);
                currentChildForm.BringToFront();
                currentChildForm.Show();

                //childForm.Close();
            }
            SetUpMainForm();
            resize();
        }

        private void Button_Close_ContactBar_Click(object sender, EventArgs e)
        {

            if (ContactBar.Width == 55)
            {
                Button_Close_ContactBar.IconChar = IconChar.ChevronRight;
                Button_Close_ContactBar.Dock = DockStyle.Right;
                //panel2.Width = ContactBar.Width;
                ContactBar.Width = 250;
            }
            else
            {
                Button_Close_ContactBar.IconChar = IconChar.ChevronLeft;
                Button_Close_ContactBar.Dock = DockStyle.Left;
                MainLayout.Width += ContactBar.Width;
                ContactBar.Width = 55;
            }
            resize();
        }

        private void Button_Play_Click(object sender, EventArgs e)
        {
            if (Button_Play.IconChar.ToString() == "Play")
            {
                Button_Play.IconChar = IconChar.Pause;
                MusicPlayer.Ctlcontrols.play();
            }
            else if (Button_Play.IconChar.ToString() == "Pause")
            {
                Button_Play.IconChar = IconChar.Play;
                MusicPlayer.Ctlcontrols.pause();
            }
        }

        private void Button_LogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Forward_Click(object sender, EventArgs e)
        {

        }

        private void Button_Compress_Click(object sender, EventArgs e)
        {
            Hide();
            MinimizeForm m = new MinimizeForm();
            m.FormClosed += new FormClosedEventHandler(Form_Closed);
            m.Show();

        }
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            MinimizeForm frm = (MinimizeForm)sender;
            MessageBox.Show(frm.Name);
            Show();
        }
        private void Button_Home_Click(object sender, EventArgs e)
        {
            if (currentChildForm.GetType().Name.ToString() != "HomeForm")
                OpenChildForm(new HomeForm(User));
            resize();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {

            if (previousChildFormName != "")
            {
                MessageBox.Show("Back to  " + previousChildFormName);
                OpenChildForm(previousChildForm);

            }
            else
                MessageBox.Show("No back");
        }

        private void Button_Menu_Click(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                MenuBar.Width = 244;
            }
            else MenuBar.Width = 55;

            resize();
        }

        private void Button_Playlist_Click(object sender, EventArgs e)
        {
            if (currentChildForm.GetType().Name.ToString() != "PlaylistForm")
            {
                PlaylistForm f = new PlaylistForm(User);
                OpenChildForm(f);
                f.pd += SetUpMainForm;
            }
                

            resize();
        }

        private void Button_User_Click(object sender, EventArgs e)
        {
            if (panel4.Visible)
            {
                panel4.Visible = false;
                panel4.SendToBack();
                return;
            }
            panel4.Visible = true;
            panel4.BringToFront();
        }

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            if (currentChildForm.GetType().Name.ToString() != "ProfileForm")
                OpenChildForm(new ProfileForm(User));
            resize();
            panel4.Visible = false;
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (theme != "light")
            {
                foreach (var IconButton in GetAll(this, typeof(IconButton)))
                {
                    (IconButton as IconButton).IconColor = Color.FromArgb(232, 119, 45);
                    IconButton.ForeColor = Color.FromArgb(232, 119, 45);
                    IconButton.BackColor = Color.Transparent;
                }
                foreach (var Panel in GetAll(this, typeof(Panel)))
                {
                    Panel.BackColor = ColorTranslator.FromHtml("#f5f5f5");
                }
                foreach (var FlowLayoutPanel in GetAll(this, typeof(FlowLayoutPanel)))
                {
                    FlowLayoutPanel.BackColor = ColorTranslator.FromHtml("#f5f5f5");
                }
                /*UserNav.BackColor = ColorTranslator.FromHtml("#ccc");
                NavBar.BackColor= ColorTranslator.FromHtml("#ccc");
                NavForm.BackColor = ColorTranslator.FromHtml("#ccc");*/
                /*foreach (Control c in MainBackGround.Controls)
                {
                    foreach (Control i in c.Controls)
                    {


                        if (i is IconButton)
                        {
                            (i as IconButton).IconColor = Color.FromArgb(232, 119, 45);
                            i.ForeColor = Color.FromArgb(232, 119, 45);

                        }
                        foreach (Control z in i.Controls)
                        {
                            if (z is IconButton)
                            {
                                (z as IconButton).IconColor = Color.FromArgb(232, 119, 45);
                                z.ForeColor = Color.FromArgb(232, 119, 45);

                            }
                        }


                    }
                    MessageBox.Show(c.Name);
                    c.BackColor = ColorTranslator.FromHtml("#f5f5f5");
                    c.ForeColor = Color.Black;

                }*/
                theme = "light";
            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Account_Click(object sender, EventArgs e)
        {
            if (currentChildForm.GetType().Name.ToString() != "AccountForm")
                OpenChildForm(new AccountForm(User));
            resize();
            panel4.Visible = false;
        }


        private void Button_Song_Click(object sender, EventArgs e)
        {
            MessageBox.Show(User.TypeUser);
            if(User.TypeUser == "Artist")
            {
                SongForm f = new SongForm(User);
                OpenChildForm(f);
            }
        }

        private void Button_Log_Click(object sender, EventArgs e)
        {
            SignIn_UpForm f = new SignIn_UpForm();
            f.ShowDialog();
            this.Close();

        }

        private void MusicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (MusicPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                Button_Play.IconChar = IconChar.Play; // Set the icon to "play"
            }
            else
            {
                Button_Play.IconChar = IconChar.Pause; // Set the icon to "pause" since it's already playing
            }
        }

        private void Button_Repeat_Click(object sender, EventArgs e)
        {
            if (MusicPlayer.settings.getMode("loop") == true)
            {
                MusicPlayer.settings.setMode("loop", false); // Turn off repeat mode
                Button_Repeat.IconColor = Color.White; // Set the icon to indicate repeat mode off
            }
            else
            {
                MusicPlayer.settings.setMode("loop", true); // Turn on repeat mode
                Button_Repeat.IconColor = Color.FromArgb(232, 119, 45); // Set the icon to indicate repeat mode on
            }
        }

        private void Button_Album_Click(object sender, EventArgs e)
        {
            MessageBox.Show(User.TypeUser);
            if (User.TypeUser == "Artist")
            {
                AlbumForm f = new AlbumForm(User);

                OpenChildForm(f);
            }


        }
    }
}