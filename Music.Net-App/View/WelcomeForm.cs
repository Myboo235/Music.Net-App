using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Music.Net_App.View
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
            pictureBox1.Image = Image.FromFile(directory + @"\Assets\muzira-banner.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        private void GetstartedButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.ShowDialog();
        }
    }
}
