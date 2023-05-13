using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music.Net_App.DAL;
using Music.Net_App.DTO;

namespace Music.Net_App.View.Listener
{
    public partial class AccountForm : Form
    {
        public AccountForm(string name)
        {
            InitializeComponent();
            iconButton1.Text += name;

            //this.HorizontalScroll.Value = true;
        }
    }
}
