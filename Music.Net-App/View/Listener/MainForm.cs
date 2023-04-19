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

namespace Music.Net_App.View
{
    public partial class MainForm : Form
    {
        
        private Form currentChildForm;

        private String previousChildFormName = "";
        private Form previousChildForm ;
        private Form nextChildForm;
        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");



        public MainForm()
        {
            InitializeComponent();
            /*HomeLayout.Controls.Clear();*/

            resize();
            MusicPlayer.URL = directory + @"\Assets\Musics\y2mate.com - DVRST  CLOSE EYES.mp3";
            MusicPlayer.Ctlcontrols.stop();
            
            this.FormBorderStyle = FormBorderStyle.None;
            customizeDesing();
            currentChildForm = new HomeForm();
            OpenChildForm(new HomeForm());
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

            panel1.Height = MenuBar.Height -48*5 -70 ;
            NavBar.Width = MainLayout.Width;

            NavForm.Width = MainLayout.Width;
            NavForm.Height = MainLayout.Height - PlayBar.Height - NavBar.Height -10;
 
            PlayBar.Width= MainLayout.Width-10;
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
                //currentChildForm.Height = MainLayout.Height + 500;
                
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
                OpenChildForm(new SearchForm());
                
            }
            resize();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                NavForm.Controls.Remove(currentChildForm);
                previousChildFormName = currentChildForm.GetType().Name.ToString();
                previousChildForm = currentChildForm;

                currentChildForm = childForm;
                currentChildForm.TopLevel = false;
                currentChildForm.FormBorderStyle = FormBorderStyle.None;

                //MainLayout.Controls.Clear();
                //MainLayout.Controls.Add(NavBar);
                
                //MainLayout.Controls.Add(PlayBar);
                NavForm.Controls.Add(currentChildForm);
                childForm.BringToFront();
                childForm.Show();
            }

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
            if(currentChildForm.GetType().Name.ToString() != "HomeForm")
                OpenChildForm(new MainForm());
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
            if(MenuBar.Width == 55)
            {
                MenuBar.Width = 244;
            }
            else MenuBar.Width = 55;

            resize();
        }

        private void Button_Playlist_Click(object sender, EventArgs e)
        {
            if (currentChildForm.GetType().Name.ToString() != "PlaylistForm")
                OpenChildForm(new PlaylistForm());
            resize();
        }

        private void Button_User_Click(object sender, EventArgs e)
        {
         /*   FormAccount formAccount = new FormAccount();
            formAccount.ShowDialog();*/
        }

        private void Button_User_Click(object sender, EventArgs e)
        {

            panelUser.Visible = true;
           


        }




        private void customizeDesing()
        {
            
            panelUser.Visible = false;

        } 
   

        private void iconButtonAccount_Click(object sender, EventArgs e)
        {
            FormAccount f2 = new FormAccount();
            f2.ShowDialog();
        }

        private void iconButtonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want logout", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
