using Music.Net_App.BLL;
using Music.Net_App.DAL.Viet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Music.Net_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            //MessageBox.Show(userBLL.checkUser("johnsmith@email.com", "password123").ToString());

            //dataGridView1.DataSource = userBLL.getAllUser().ToList();
            //dataGridView1.DataSource = userBLL.getUsersByName("John Smith").ToList();
            //dataGridView1.DataSource = userBLL.getUserPlaylist(1).ToList();
            //Listener ls = new Listener(1, 1 ,  "John Smith",  "johnsmith@email.com", "password123", 1 , 2020-09, "", " ");
            Listener ls = new Listener() { Name = "John Smith11"};

        

            userBLL.addUser(ls);
          dataGridView1.DataSource = userBLL.getAllUser().ToList();
        }
    }
}
