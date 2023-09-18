using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Smart_Application.Messege_Box
{
    public partial class wifi : Form
    {
        public wifi()
        {
            InitializeComponent();
        }

        public bool pingStatus()
        {
            bool pingStatus = false;
            string hostNameOrAddress = "Google.com";

            using (Ping p = new Ping())
            {
                string data = "BranLivinston";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1000;

                try
                {
                    PingReply reply = p.Send(hostNameOrAddress, timeout, buffer);
                    pingStatus = (reply.Status == IPStatus.Success);
                }
                catch (Exception)
                {
                    pingStatus = false;
                }
                return pingStatus;
            }
        }
        private void wifi_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pingStatus() == true)
            {
                PictureBox1.Image = Properties.Resources.wifi_con;
                Label1.Text = "Internet Connected";
                Label1.ForeColor = Color.FromArgb(0, 192, 0);
            }
            else
            {
                PictureBox1.Image = Properties.Resources.wifi_disconnect;
                Label1.Text = "Internet Not Connected";
                Label1.ForeColor = Color.FromArgb(240, 89, 69);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
