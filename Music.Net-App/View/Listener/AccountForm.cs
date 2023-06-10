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
using System.Xml.Linq;
using Music.Net_App.BLL;
using Music.Net_App.DAL;
using Music.Net_App.DTO;

namespace Music.Net_App.View.Listener
{
    public partial class AccountForm : Form
    {
        UserDTO User = new UserDTO(); 
        CountryBLL Countrybll = new CountryBLL();
        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
        public AccountForm(UserDTO user)
        {
            InitializeComponent();

            User = user;
            guna2CirclePictureBox1.Image = resizeImage(Image.FromFile(directory + @"\Assets\Images\Profile-picture.png"),
                new Size(guna2CirclePictureBox1.Width, guna2CirclePictureBox1.Height));
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            SetUpAccount();
            
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void SetUpAccount()
        {
            iconButton1.Text = "Hello "+ User.Name;
            guna2TextBox1.Text = User.Name;
            guna2TextBox4.Text = User.Password;
            guna2TextBox2.Text = User.Email;
            guna2TextBox3.Text = User.DateJoin.ToString();
            guna2TextBox3.Enabled = false;

            foreach(CountryDTO c in Countrybll.GetAllCountry())
            {
                guna2ComboBox1.Items.Add(c.CountryName);
            }
            guna2ComboBox1.SelectedIndex = User.CountryId;
            guna2ComboBox2.Items.AddRange(new string[]{
                "Women","Men"
            });
            guna2ComboBox2.SelectedIndex = Convert.ToInt32(User.Gender);
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            User.Name = guna2TextBox1.Text;
            User.Email = guna2TextBox2.Text;
            User.Password = guna2TextBox4.Text;
            User.CountryId = guna2ComboBox1.SelectedIndex;
            User.Gender = Convert.ToBoolean(guna2ComboBox2.SelectedIndex);

            MessageBox.Show(User.TypeUser);
            if (UserBLL.Instance.ModifyUser(User))
            {
                MessageBox.Show("Modify successfully");
                SetUpAccount() ;
            }
            else
            {
                MessageBox.Show("There is a error when modify");
            }

        }
    }
}
