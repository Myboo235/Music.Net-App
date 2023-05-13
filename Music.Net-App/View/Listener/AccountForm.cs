using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Music.Net_App.DAL;
using Music.Net_App.DTO;

namespace Music.Net_App.View.Listener
{
    public partial class AccountForm : Form
    {
        UserDTO User = new UserDTO();
        public AccountForm(UserDTO user)
        {
            InitializeComponent();

            User = user;
            //MessageBox.Show(user.CountryName);
            SetUpAccount();
            //this.HorizontalScroll.Value = true;
        }

        private void SetUpAccount()
        {
            iconButton1.Text += User.Name;
            guna2TextBox1.Text = User.Name;
            guna2TextBox2.Text = User.Email;
            guna2TextBox3.Text = User.DateJoin.ToString();
            guna2TextBox3.Enabled = false;

            //guna2ComboBox1.val
            //guna2ComboBox1.ForeColor = Color.Red;
        }
    }
}
