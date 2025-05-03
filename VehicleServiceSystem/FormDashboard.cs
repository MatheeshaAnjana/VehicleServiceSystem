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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            guna2Elipse1.TargetControl = this;

        }
        public void loadform(Form form)
        {

            if (this.pnlMain.Controls.Count > 0) this.pnlMain.Controls.RemoveAt(0);

            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            this.pnlMain.Controls.Add(form);
            this.pnlMain.Tag = form;
            form.Show();

            timer1.Start();

            
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
           // pnlHeader.BackColor = Color.FromArgb(150,0,0,0);

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            pnlMain.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new FormMaindashboard());
            pnlSmall.Height = btnView.Height;
            pnlSmall.Top = btnView.Top;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            loadform(new FormCustomer());
            pnlSmall.Height = btnCustomer.Height;
            pnlSmall.Top = btnCustomer.Top;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            loadform(new FormBill());
            pnlSmall.Height = btnBill.Height;
            pnlSmall.Top = btnBill.Top;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            loadform(new FormAbout());
            pnlSmall.Height = btnAbout.Height;
            pnlSmall.Top = btnAbout.Top;
        }

        private void btnService_Click_1(object sender, EventArgs e)
        {
            loadform(new FormService());
            pnlSmall.Height = btnService.Height;
            pnlSmall.Top = btnService.Top;
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FormDashboard obj3 = new FormDashboard();
            obj3.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();

            obj3.Show();
            
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            pnlHeader.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            //guna2Panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            pnlTop.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeReal.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDateReal.Text = DateTime.Now.ToString("MMM dd yyyy dddd");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlSmall_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadform(new FormReport());
            pnlSmall.Height = btnReport.Height;
            pnlSmall.Top = btnReport.Top;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
    }

