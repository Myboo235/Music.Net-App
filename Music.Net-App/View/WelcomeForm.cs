using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Music.Net_App.View
{
    public partial class WelcomeForm : Form
    {
        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
        public WelcomeForm()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(directory + @"\Assets\Images\muzira-banner.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; 
        }
    
        private void GetstartedButton_Click(object sender, EventArgs e)
        {
            Hide();
            SignIn_UpForm main = new SignIn_UpForm();
            main.ShowDialog();
            Close();
        }
    }
}
