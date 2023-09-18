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
    public partial class uc_Dashboard : UserControl
    {
        public uc_Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            switch (temp.Checked)
            {
                case true:
                    activate act = new activate();
                    act.Show();
                    return;

                case false:
                    deactivate deact = new deactivate();
                    deact.Show();
                    return;
            }
        }


        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            switch (light.Checked)
            {
                case true:
                    activate act = new activate();
                    act.Show();
                    return;

                case false:
                    deactivate deact = new deactivate();
                    deact.Show();
                    return;
            }
        }

        
        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            switch (ac.Checked)
            {
                case true:
                    activate act = new activate();
                    act.Show();
                    return;

                case false:
                    deactivate deact = new deactivate();
                    deact.Show();
                    return;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {

        }


        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            switch (fridge.Checked)
            {
                case true:
                    activate act = new activate();
                    act.Show();
                    return;

                case false:
                    deactivate deact = new deactivate();
                    deact.Show();
                    return;
            }
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
