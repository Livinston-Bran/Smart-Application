using Smart_Application.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Application
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uc_Controls1.Visible = false;
            uc_Dashboard1.Visible = false;
            uc_info1.Visible = false;
            uc_mainform1.Visible = true;
            uc_Signals1.Visible = false;
            uc_User1.Visible = false;
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uc_Controls1.Visible = false;
            uc_Dashboard1.Visible = true;
            uc_info1.Visible = false;
            uc_mainform1.Visible = false;
            uc_Signals1.Visible = false;
            uc_User1.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uc_Controls1.Visible = false;
            uc_Dashboard1.Visible = false;
            uc_info1.Visible = false;
            uc_mainform1.Visible = false;
            uc_Signals1.Visible = true;
            uc_User1.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uc_Controls1.Visible = true;
            uc_Dashboard1.Visible = false;
            uc_info1.Visible = false;
            uc_mainform1.Visible = false;
            uc_Signals1.Visible = false;
            uc_User1.Visible = false;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            uc_Controls1.Visible = false;
            uc_Dashboard1.Visible = false;
            uc_info1.Visible = true;
            uc_mainform1.Visible = false;
            uc_Signals1.Visible = false;
            uc_User1.Visible = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uc_Controls1.Visible = false;
            uc_Dashboard1.Visible = false;
            uc_info1.Visible = false;
            uc_mainform1.Visible = false;
            uc_Signals1.Visible = false;
            uc_User1.Visible = true;
        }

        private void uc_mainform1_Load(object sender, EventArgs e)
        {

        }
    }
}
