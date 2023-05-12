using Guna.UI2.WinForms;
using Music.Net_App.BLL;
using Music.Net_App.DAL;
using Music.Net_App.DTO;
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
        public SearchForm()
        {
            InitializeComponent();
            flowLayoutPanel3.BackColor = Color.Transparent;
        }
        private List<PictureBox> tb = new List<PictureBox>();
        private List<Guna2Panel> pn = new List<Guna2Panel>();

        private void SearchForm_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel2.Width = this.Width-9;
            guna2TextBox1.Size = new Size(this.Width - 280, 47);
            flowLayoutPanel3.Width= this.Width-21;
            guna2Panel1.Width = flowLayoutPanel3.Width-12;
            flowLayoutPanel5.Width = this.Width-6;
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
                    p.Width = p.Width = flowLayoutPanel3.Width - 12;
                }


            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((flowLayoutPanel3.Width - 30) / 4).ToString());
            String[] s = new String[5] {

            "Classical",
            "Electronic",
            "Hip-Hop",
            "Pop",
            "Rock"

            };
            

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

        private void Button_Search_Click(object sender, EventArgs e)
        {
            SongBLL song = new SongBLL();
            foreach(Song1DTO s in song.GetAllSongs())
            {
                Guna2Panel p = new Guna2Panel();
                pn.Add(p);
                p.Height = 80;
                p.Width = flowLayoutPanel3.Width - 15;
                p.BackColor = Color.Transparent;
                p.FillColor = Color.Azure;
                p.BorderColor = Color.White;
                p.BorderRadius = 20;
                p.BorderThickness = 5;
                p.Controls.Add(new Label
                {
                    Text = s.SongName,
                    Padding = new Padding(20, 10, 0, 0),
                    Height = 40,
                    Width = p.Width,

                });
                
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
