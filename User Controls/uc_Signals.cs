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
    public partial class uc_Signals : UserControl
    {
        public uc_Signals()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            wifi wifi = new wifi();
            wifi.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            newdevice device = new newdevice();
            device.Show();
        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            switch (guna2ToggleSwitch3.Checked)
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

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            switch (guna2ToggleSwitch1.Checked)
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

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            switch (guna2ToggleSwitch2.Checked)
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

        private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
        {
            switch (guna2ToggleSwitch5.Checked)
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
    }
}
