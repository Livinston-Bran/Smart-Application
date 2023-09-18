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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int count = 0;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String username = TextBox1.Text;
            String password = TextBox2.Text;

            count = count + 1;

            if (count > 3)
            {
                MessageBox.Show("Sorry Invalid User Attempt !!");
                this.Close();
            }

            if (username.Equals("branL") && password.Equals("2001"))
            {
                dashboard dashboard = new dashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect !");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Label3.Text = DateTime.Now.ToShortTimeString();


            int currentHour = DateTime.Now.Hour;

            if (currentHour < 12)
                guna2HtmlLabel6.Text = "Good Morning Bran!";
            else if (currentHour < 18)
                guna2HtmlLabel6.Text = "Good Afternoon Bran!";
            else
                guna2HtmlLabel6.Text = "Good Evening Bran!";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Label3.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
