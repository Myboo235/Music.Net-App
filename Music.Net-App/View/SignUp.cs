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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

   

        private void Enter_Username(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                textBoxUserName.Text = "Username";
                textBoxUserName.ForeColor = Color.Silver;
            }
        }

        private void Leave_Username(object sender, EventArgs e)
        {
            if(textBoxUserName.Text == "Username")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;
            }
        }

        private void Enter_Password(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.Silver;
            }
        }

        private void Leave_Password(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

     

   

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBoxUserName.Text == "Username") {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;
            }
            if(textBoxPassword.Text == "Password") {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
      

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                this.textBoxPassword.PasswordChar = '*';
            }
     

        }

 
    }
}
