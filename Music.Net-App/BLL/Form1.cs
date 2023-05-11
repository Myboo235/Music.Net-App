using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.BLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumBLL b = new AlbumBLL();
            guna2DataGridView1.DataSource = b.GetAllAlbum();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumBLL b = new AlbumBLL();
            guna2DataGridView1.DataSource = b.FindAlbumByName(guna2TextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlbumBLL b = new AlbumBLL();
            guna2DataGridView1.DataSource = b.GetAllSongOfAlbum(guna2TextBox1.Text);
        }
    }
    
}
