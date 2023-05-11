using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.View.Listener
{
    public partial class ProfileForm : Form
    {
        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
        public ProfileForm()
        {
            InitializeComponent();
            guna2CirclePictureBox1.Image = resizeImage(Image.FromFile(directory + @"\Assets\Images\Profile-picture.png"),
                new Size(guna2CirclePictureBox1.Width, guna2CirclePictureBox1.Height)); 
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            
            
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

    }
}
