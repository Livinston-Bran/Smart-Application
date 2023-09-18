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
    public partial class uc_info : UserControl
    {
        public uc_info()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Assistant assistant = new Assistant();
            assistant.Show();
        }
    }
}
