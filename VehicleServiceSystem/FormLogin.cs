using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VehicleServiceSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            guna2Elipse1.TargetControl = this;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FormSignin obj1 = new FormSignin();
            obj1.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            obj1.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text;

                if (username == "admin" && password == "1234")
                {
                    FormDashboard obj2 = new FormDashboard();
                    obj2.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    obj2.Show();
                }
                else
                {
                    SystemSounds.Hand.Play();

                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            
        }

        private void pnlBack_Paint(object sender, PaintEventArgs e)
        {
            
            pnlBack.BackColor = Color.FromArgb(100,0,0,0);

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
