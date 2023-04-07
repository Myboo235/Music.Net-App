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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel2.Width = this.Width;
            richTextBox1.Size = new Size(this.Width - 280, 47);
            panel2.Width= this.Width;
        }
    }
}
