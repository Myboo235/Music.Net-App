using Guna.UI2.WinForms;
using Music.Net_App.BLL;
using Music.Net_App.DAL;
using Music.Net_App.View.Admin;
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

        private void Reset_Password_Click(object sender, EventArgs e)
        {
            label1.Text = "Reset Password";
            guna2TextBox2.Visible = false;
            label2.Visible = false;
            Button_Change.Visible = false;
            Button_SignIn_SignUp.Text = "RESET PASSWORD";

        }
        private void Button_Change_Click(object sender, EventArgs e)
        {
            //if()
            if(Button_Change.Text == "SIGN UP")
            {
                label1.Text = "Sign up for free\nMuzira account";
                label4.Visible = false;
                guna2TextBox3.Visible = true;
                Button_SignIn_SignUp.Text = "SIGN UP";
                label2.Text = "Already have an account. ";
                Button_Change.Text = "SIGN IN";

            }
            else if(Button_Change.Text == "SIGN IN")
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
            if (!guna2RadioButton1.Checked && !guna2RadioButton2.Checked)
            {
                MessageBox.Show("Please choose type ");
                return false;
            }
            return true;
        }
        private bool CheckInformationSignIn()
        {
            if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "")
            {
                MessageBox.Show("Please fill the information ");

                return false;
            }
            if (!guna2RadioButton1.Checked && !guna2RadioButton2.Checked)
            {
                MessageBox.Show("Please choose type ");
                return false;
            }
            return true;
        }

        private void Button_SignIn_SignUp_Click(object sender, EventArgs e)
        {
            if (Button_SignIn_SignUp.Text == "LOG IN")
            {
                if (!CheckInformationSignIn()) return;
                if(guna2TextBox1.Text =="Admin" && guna2TextBox2.Text == "Admin123")
                {
                    MessageBox.Show("Welcome Admin");
                    Hide();
                    DashboardForm dbf = new DashboardForm();
                    dbf.ShowDialog(this);
                    Close();
                    return;
                }
                if (guna2RadioButton1.Checked)
                {
                    if (UserBLL.Instance.CheckArtist(guna2TextBox1.Text, guna2TextBox2.Text))
                    {
                        MessageBox.Show("Sign in successfully");
                        Hide();
                        MainForm main = new MainForm(guna2TextBox1.Text,"Artist");
                        main.ShowDialog(this);
                        Close();
                    }
                    else MessageBox.Show("Sign in fail");
                }else if (guna2RadioButton2.Checked)
                {
                    if (UserBLL.Instance.CheckListener(guna2TextBox1.Text, guna2TextBox2.Text))
                    {
                        MessageBox.Show("Sign in successfully");
                        Hide();
                        MainForm main = new MainForm(guna2TextBox1.Text,"Listener");
                        main.ShowDialog(this);
                        Close();
                    }
                    else MessageBox.Show("Sign in fail");
                }
                
                return;
            }
            else if(Button_SignIn_SignUp.Text == "SIGN UP")
            {
                if (!CheckInformationSignUp()) return;
                if (UserBLL.Instance.CheckEmail(guna2TextBox1.Text))
                {
                    MessageBox.Show("There is already email");
                    return;
                }
                else
                {
                    
                    UserDTO user = new UserDTO
                    {
                        Name = guna2TextBox3.Text,
                        Email = guna2TextBox1.Text,
                        Password = guna2TextBox2.Text,
                        DateJoin = DateTime.Now,
                    };
                    if (guna2RadioButton2.Checked)
                    {
                        MessageBox.Show("Sign up");
                        if (UserBLL.Instance.AddListener(user))
                        {

                            MessageBox.Show("Sign up successfully");
                        }
                        else
                        {
                            MessageBox.Show("Sign up fail");
                        }
                    }else if(guna2RadioButton1.Checked)
                    {
                        if (UserBLL.Instance.AddArtist(user))
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
            else
            {
                if(guna2TextBox1.Text == "")
                {
                    MessageBox.Show("Please fill the information ");
                    return;
                }
                if (guna2RadioButton1.Checked)
                {
                    if (UserBLL.Instance.ResetPasswordArtist(guna2TextBox1.Text))
                    {
                        MessageBox.Show("Reset successfully. Your new pass is Muzira123. Please Sign in again");
                    }
                    else
                    {
                        MessageBox.Show("Reset fail");
                    }
                }
                else if (guna2RadioButton2.Checked)
                {
                    if (UserBLL.Instance.ResetPasswordListener(guna2TextBox1.Text))
                    {
                        MessageBox.Show("Reset successfully. Your new pass is Muzira123. Please Sign in again");
                    }
                    else
                    {
                        MessageBox.Show("Reset fail");
                    }
                }

            
        }
        }

        
    }
}
