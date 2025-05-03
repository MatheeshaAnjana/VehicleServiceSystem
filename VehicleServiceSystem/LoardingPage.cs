using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleServiceSystem
{
    public partial class LoardingPage : Form
    {
        public LoardingPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            guna2Elipse1.TargetControl = this;

        }
        int stPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            stPoint += 5;
            if (stPoint > 100)
                stPoint = 100;

            prgBar.Value = stPoint;
            lblLoadPrecentage.Text = stPoint.ToString() + "%";

            if (prgBar.Value == 100)
            {
                timer1.Stop();
                FormLogin obj = new FormLogin();
                obj.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                obj.Show();
            }
        }
        private void LoardingPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void prgBar1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblLoadPrecentage_Click(object sender, EventArgs e)
        {

        }
    }
}
