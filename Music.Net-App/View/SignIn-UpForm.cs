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

namespace Music.Net_App.View
{
    public partial class SignIn_UpForm : Form
    {
        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public SignIn_UpForm()
        {
            InitializeComponent();
            pictureBox1.Image = resizeImage(Image.FromFile(directory + @"\Assets\Images\muzira-banner.png"), new Size(150, 100));
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            if(Button_SignUp.Text == "SIGN UP")
            {
                label1.Text = "Sign up for free \nMuzira account";
                label4.Visible = false;
                guna2TextBox3.Visible = true;
                guna2Button1.Text = "SIGN IN";
                label2.Text = "Already have an account. ";
                Button_SignUp.Text = "SIGN IN";
            }
            else
            {
                label1.Text = "Log in to continue.";
                label4.Visible = true;
                guna2TextBox3.Visible = false;
                guna2Button1.Text = "SIGN UP";
                label2.Text = "Don't have an account ?";
                Button_SignUp.Text = "SIGN UP";
            }

        }
    }
}
