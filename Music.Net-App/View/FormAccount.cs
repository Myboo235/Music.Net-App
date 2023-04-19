using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.View
{
    public partial class FormAccount : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
                  int nLeftRect,
                  int nTopRect,
                  int nRightRect,
                  int nBottomRect,
                  int nWidthEllipse,
                  int nHeightEllipse
        );
   
                                                                                       
        public FormAccount()
        {
            InitializeComponent();
            iconButton2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, iconButton2.Width, iconButton2.Height, 20, 20));

        }

     
    }
}
