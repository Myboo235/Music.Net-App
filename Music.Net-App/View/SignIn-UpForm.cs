using Guna.UI2.WinForms;
using Music.Net_App.BLL;
using Music.Net_App.DAL;
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
        UserBLL u = null;
        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public SignIn_UpForm()
        {
            InitializeComponent();
            u = new UserBLL();
            pictureBox1.Image = resizeImage(Image.FromFile(directory + @"\Assets\Images\muzira-banner.png"), new Size(150, 100));
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            if(Button_Change.Text == "SIGN UP")
            {
                label1.Text = "Sign up for free\nMuzira account";
                label4.Visible = false;
                guna2TextBox3.Visible = true;
                Button_SignIn_SignUp.Text = "SIGN UP";
                label2.Text = "Already have an account. ";
                Button_Change.Text = "SIGN IN";

            }
            else
            {
                label1.Text = "Log in to continue.";
                label4.Visible = true;
                guna2TextBox3.Visible = false;
                Button_SignIn_SignUp.Text = "LOG IN";
                label2.Text = "Don't have an account ?";
                Button_Change.Text = "SIGN UP";
            }


     

        }
        private bool CheckInformationSignUp()
        {
            if (guna2TextBox1.Text == "" || guna2TextBox2.Text =="" || guna2TextBox3.Text == "")
            {
                MessageBox.Show("Please fill the information ");
                return false;
            }
            return true;
        }
        private void Button_SignIn_SignUp_Click(object sender, EventArgs e)
        {
            if (Button_Change.Text == "SIGN UP") 
            {
                if (u.CheckUser(guna2TextBox1.Text, guna2TextBox2.Text))
                {
                    MessageBox.Show("Sign in successfully");
                    Hide();
                    MainForm main = new MainForm(guna2TextBox1.Text);
                    main.ShowDialog();
                    Close();
                }
                else MessageBox.Show("Sign in fail");
                return;
            }
            else 
            {
                if(!CheckInformationSignUp()) return;
                if (u.CheckEmail(guna2TextBox1.Text))
                {
                    MessageBox.Show("There is already email");
                    return;
                }
                else
                {
                    UserDTO listener = new UserDTO
                    {
                        
                        Name = guna2TextBox3.Text,
                        Email = guna2TextBox1.Text,
                        Password = guna2TextBox2.Text,
                        DateJoin = DateTime.Now,
                    };
                    if (u.AddListener(listener))
                    {
                        MessageBox.Show("Sign up successfully");
                    }
                    else
                    {
                        MessageBox.Show("Sign up fail");
                    }
                }
            }
            

        }
    }
}
