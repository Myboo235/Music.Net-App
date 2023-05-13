using Guna.UI2.WinForms;
using Music.Net_App.BLL;
using Music.Net_App.DAL;
using Music.Net_App.DTO;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.View
{
    public partial class SearchForm : Form
    {

        public delegate void SongDelegate(string SongName);
        public SongDelegate sd { get; set; }
        SongBLL song = new SongBLL();
        AlbumBLL album = new AlbumBLL();
        private List<PictureBox> tb = new List<PictureBox>();
        private List<Guna2Panel> pn = new List<Guna2Panel>();
        public SearchForm()
        {
            InitializeComponent();
            flowLayoutPanel3.BackColor = Color.Transparent;
            guna2Panel1.Width = flowLayoutPanel3.Width - 30;
        }
        

        private void SearchForm_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel2.Width = this.Width-9;
            guna2TextBox1.Size = new Size(this.Width - 280, 47);
            flowLayoutPanel3.Width= this.Width-21;
            guna2Panel1.Width = flowLayoutPanel3.Width-12;
            guna2Panel1.Width = flowLayoutPanel3.Width - 30;
            //flowLayoutPanel3.Height= this.Height-150;
            /*if (tb!=null)
            {
                foreach(PictureBox t in tb)
                {
                    t.Width = w;
                }


            }*/
            if (pn != null)
            {
                foreach (Guna2Panel p in pn)
                {
                    p.Width = flowLayoutPanel3.Width - 30;
                }


            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((flowLayoutPanel3.Width - 30) / 4).ToString());

            

            for (int i = 0; i < 5; i++)
            {
                PictureBox t = new PictureBox();
                tb.Add(t);
                t.Height = 200;
                t.Width = (flowLayoutPanel3.Width - 30)/4 ;
                t.BackColor = Color.Red;

                string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
                t.Image = Image.FromFile(directory + @"\Assets\Images\Song-icon.jpg");

                t.SizeMode = PictureBoxSizeMode.CenterImage;
                t.Anchor = AnchorStyles.None;

                flowLayoutPanel3.Controls.Add(t);
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click");
            string song = (sender as Label).Text;
            MessageBox.Show(song);
            sd(song);
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
            string song = (sender as Label).Text;
            MessageBox.Show(song);
            sd(song);
        }
        private void Button_Search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Controls.Clear();
            foreach (Song2DTO s in song.GetSongByName(guna2TextBox1.Text))
            //foreach (AlbumDTO a in album.GetAllAlbum())
            {
                Guna2Panel p = new Guna2Panel();
                Label label = new Label 
                {
                    Text = s.SongName,
                    //Text = a.AlbumName,
                    ForeColor = Color.White,
                    Padding = new Padding(20, 10, 0, 0),
                    Height = 40,
                    Width = p.Width,
                };
                label.Click += new EventHandler(Label_Click);
                

                pn.Add(p);
                p.Height = 80;
                p.Width = flowLayoutPanel3.Width - 30;
                p.BackColor = Color.Transparent;
                p.FillColor = Color.Transparent;
                p.BorderColor = Color.White;
                //p.BorderRadius = 20;
                p.CustomBorderColor = Color.White;
                p.CustomBorderThickness = new Padding(0 , 1 , 0 , 0);
                p.Controls.Add(label);
                
                
                /*string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
                t.Image = Image.FromFile(directory + @"\Assets\Images\Song-icon.jpg");

                t.SizeMode = PictureBoxSizeMode.CenterImage;
                t.Anchor = AnchorStyles.None;*/

                flowLayoutPanel3.Controls.Add(p);
            }
            
        }




        /*  Graphics g = Graphics.FromImage(t.Image);
            g.DrawString(s[i], new Font("Tahoma", 30), Brushes.White, new PointF(80, 80));*/

    }
}
