﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.View
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            //w = flowLayoutPanel3.Width / 4 - 8 ;
        }
        private List<PictureBox> tb = new List<PictureBox>();
        int w;
        private void SearchForm_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel2.Width = this.Width-9;
            guna2TextBox1.Size = new Size(this.Width - 280, 47);
            flowLayoutPanel3.Width= this.Width-21;
            //flowLayoutPanel3.Height= this.Height-150;
            /*if (tb!=null)
            {
                foreach(PictureBox t in tb)
                {
                    t.Width = w;
                }


            }*/
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                PictureBox t = new PictureBox();
                tb.Add(t);
                t.Height = 200;
                t.Width = 194 ;
                t.BackColor = Color.Red;

                string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
                t.Image = Image.FromFile(directory + @"\Assets\Images\Song-icon.jpg");
                
                t.SizeMode = PictureBoxSizeMode.CenterImage;
                t.Anchor = AnchorStyles.None;

                flowLayoutPanel3.Controls.Add(t);
            }
        }

    }
}
