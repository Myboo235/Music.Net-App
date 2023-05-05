using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.View.Admin
{
    public partial class DashboardForm : Form
    {
        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public DashboardForm()
        {
            InitializeComponent();
            pictureBox1.Image = resizeImage(Image.FromFile(directory + @"\Assets\Images\muzira-banner.png"), new Size(150, 100));
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void Button_Users_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            //guna2Panel1.Width = this.Width - guna2CustomGradientPanel1.Width - 35;
            guna2Panel1.Height = this.Height - flowLayoutPanel1.Height - 100;
            guna2Panel2.Height = this.Height - flowLayoutPanel1.Height - 100;

            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void Button_So_Al_Click(object sender, EventArgs e)
        {
            guna2Panel2.Location = new Point(245, 122);
            guna2Panel2.Visible = true;
            guna2Panel2.Width = this.Width - guna2CustomGradientPanel1.Width - 35;
            guna2Panel2.Height = this.Height - flowLayoutPanel1.Height - 100;

            guna2Panel1.Visible = false;
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
        }

        private void DashboardForm_Resize(object sender, EventArgs e)
        {

        }
    }
}
