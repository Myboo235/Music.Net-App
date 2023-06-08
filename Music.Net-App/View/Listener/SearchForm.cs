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
        private List<Guna2Panel> tb = new List<Guna2Panel>();
        private List<Guna2Panel> pn = new List<Guna2Panel>();
        string filter = "Song";
        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
        public SearchForm()
        {
            InitializeComponent();
            flowLayoutPanel3.BackColor = Color.Transparent;

        }
        

        private void SearchForm_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel2.Width = this.Width-9;
            guna2TextBox1.Size = new Size(this.Width - 280, 47);
            flowLayoutPanel3.Width= this.Width-21;
            //flowLayoutPanel3.Height= this.Height-150;
            if (tb != null)
            {
                foreach (Guna2Panel f in tb)
                {
                    f.Width = (flowLayoutPanel3.Width - 30) / 4;
                }


            }
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
                //tb.Add(t);
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
            if(filter == "Song")
            {
                foreach (SongDTO s in SongBLL.Instance.GetSongByName(guna2TextBox1.Text))
                //foreach (AlbumDTO a in album.GetAllAlbum())
                {
                    Guna2Panel p = new Guna2Panel();
                    FlowLayoutPanel f = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.TopDown,
                        Width = p.Width
                    };
                    FlowLayoutPanel fb = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.BottomUp,
                        Size = new Size(262, 81),
                        Dock = DockStyle.Right,
                    };
                    Label SongName = new Label
                    {
                        Text = s.SongName,
                        //Text = a.AlbumName,
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        Padding = new Padding(20, 10, 0, 0),
                        //Dock = DockStyle.Top,
                        Height = 40,
                        Width = f.Width,
                    };
                    Label Artist = new Label
                    {
                        Text = s.ArtistName,
                        //Text = a.AlbumName,
                        ForeColor = Color.DimGray,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        //Margin = new Padding(0, 20, 0, 0),
                        Padding = new Padding(20, 0, 0, 0),
                        Height = 40,
                        Width = f.Width,
                        //Dock = DockStyle.Left,

                    };
                    SongName.Click += new EventHandler(Label_Click);
                    Guna2Button b = new Guna2Button
                    {
                        Text = "Add to Playlist",
                        Font = new Font("Segoe UI", 9),
                        Size = new Size(206, 52),
                        FillColor = Color.Transparent,
                        BorderColor = Color.White,
                        BorderRadius = 20,
                        BorderThickness = 2,

                    };

                    pn.Add(p);
                    p.Height = 80;
                    p.Width = flowLayoutPanel3.Width - 30;
                    p.BackColor = Color.Transparent;
                    p.FillColor = Color.Transparent;
                    p.BorderColor = Color.White;
                    //p.BorderRadius = 20;
                    p.CustomBorderColor = Color.White;
                    p.CustomBorderThickness = new Padding(0, 1, 0, 0);
                    f.Controls.Add(SongName);
                    f.Controls.Add(Artist);
                    fb.Controls.Add(b);
                    p.Controls.Add(f);
                    p.Controls.Add(fb);

                    /*string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
                    t.Image = Image.FromFile(directory + @"\Assets\Images\Song-icon.jpg");

                    t.SizeMode = PictureBoxSizeMode.CenterImage;
                    t.Anchor = AnchorStyles.None;*/

                    flowLayoutPanel3.Controls.Add(p);
                }
            }
            else if(filter == "Album")
            {
                foreach (AlbumDTO a in AlbumBLL.Instance.GetAllAlbum()) 
                {
                    Guna2Panel t = new Guna2Panel();
                    FlowLayoutPanel f = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.TopDown,
                        Width = 170,
                        BackColor = Color.Transparent,
                        Height = 200
                        //Dock = DockStyle.Left
                    };
                    Panel panel = new Panel
                    { 
                        Width = f.Width-9,
                        Height = 80,
                    };
                    Panel Albumpanel = new Panel
                    {
                        Width = f.Width - 9,
                        Height = 40,
                    };
                    Label AlbumName = new Label
                    {
                        Text = a.AlbumName,
                        ForeColor = Color.Black,
                        Width = 100,
                        Height = 40,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        AutoSize = true
                    };

                    Label ArtistName = new Label
                    {
                        //Text = a.ArtistName,
                        ForeColor = Color.WhiteSmoke,
                        Width = 100,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Underline),
                        AutoSize = true
                    };
                    PictureBox p = new PictureBox
                    {
                        Image = Image.FromFile(directory + @"\Assets\Images\Song-icon.jpg"),
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        Width = 181,
                        //Size = new Size(181,181),
                        Dock = DockStyle.Right,
                    };
                    t.Height = 200;
                    t.Width = (flowLayoutPanel3.Width - 30) / 4;
                    t.BackColor = Color.Transparent;
                    t.FillColor = ColorTranslator.FromHtml("#777777");
                    t.Anchor = AnchorStyles.None;
                    t.BorderRadius = 20;
                    Albumpanel.Controls.Add(AlbumName);
                    f.Controls.Add(panel);
                    f.Controls.Add(Albumpanel);
                    f.Controls.Add(ArtistName);
                    t.Controls.Add(f);
                    t.Controls.Add(p);
                    
                    tb.Add(t);
                    flowLayoutPanel3.Controls.Add(t);
                }
            }

        }

        private void Filter_Click(object sender, EventArgs e)
        {
            filter = (sender as Guna2CustomRadioButton).Text;
        }




        /*  Graphics g = Graphics.FromImage(t.Image);
            g.DrawString(s[i], new Font("Tahoma", 30), Brushes.White, new PointF(80, 80));*/

    }
}
