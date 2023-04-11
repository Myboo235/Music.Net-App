﻿using FontAwesome.Sharp;
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
            currentChildForm =new HomeForm();
            OpenChildForm(currentChildForm);
            resize();
            MusicPlayer.URL = directory + @"\Assets\Musics\y2mate.com - DVRST  CLOSE EYES.mp3";
            MusicPlayer.Ctlcontrols.stop();
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
            //MenuBar.Height = this.Height;
            //ContactBar.Height = this.Height;

            MainLayout.Size = new Size(MainBackGround.Width - MenuBar.Width - ContactBar.Width, MainBackGround.Height);
            UserNav.Width = MainLayout.Width - Button_Back.Width - Button_Next.Width - 120;
            NavBar.Width = MainLayout.Width;

            NavForm.Width = MainLayout.Width-10;
            NavForm.Height = MainLayout.Height - PlayBar.Height - 120;
 
            PlayBar.Width= MainLayout.Width;

            MusicPlayer.Width = PlayBar.Width - panel3.Width -50 ;
            if (currentChildForm != null)
            {
                currentChildForm.Width = NavForm.Width;
                //NavForm.Height = currentChildForm.Height;
            }
        }
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            resize();            
        }
        private void Button_Search_Click(object sender, EventArgs e)
        {
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

                NavForm.Controls.Add(childForm);

                childForm.BringToFront();
                childForm.Show();

                NavForm.Margin = new Padding(0,0,0,50);

                //previousChildForm.Close();
            }

            resize();
        }

        private void Button_Close_ContactBar_Click(object sender, EventArgs e)
        {
            /*panel2.Left  -= (ContactBar.Width - 10);*/
            
            //panel2.Width += (ContactBar.Width + 45);
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

            /*HomeLayout.Width += ContactBar.Width;*/
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
        private void Button_Home_Click(object sender, EventArgs e)
        {
            if(currentChildForm.GetType().Name.ToString() != "HomeForm")
                OpenChildForm(new HomeForm());
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

    }
}