using Smart_Application.Messege_Box;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Application.User_Controls
{
    public partial class uc_mainform : UserControl
    {
        public uc_mainform()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            newdevice newdev = new newdevice();
            newdev.Show();
        }
    }
}
