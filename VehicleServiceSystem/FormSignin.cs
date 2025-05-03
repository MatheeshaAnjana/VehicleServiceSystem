using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleServiceSystem
{
    public partial class FormSignin : Form
    {
        public FormSignin()
        {
            InitializeComponent();
            guna2Elipse1.TargetControl = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormDashboard obj2 = new FormDashboard();
            obj2.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            obj2.Show();

            string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "INSERT INTO CusDetails VALUES (@v1,@v2,@v3,@v4,@v5,@v6)";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@v1", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@v2", txtName.Text);
                cmd.Parameters.AddWithValue("@v3", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@v4", txtEmail.Text);
                cmd.Parameters.AddWithValue("@v5", cmbVehicleType.Text);
                cmd.Parameters.AddWithValue("@v6", txtVehicleModel.Text);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show(rows > 0 ? "Register Successfully" : "Register Not Success");


            }

           /* string connectionString1 = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString1))
            {

                string query = "INSERT INTO LoginTB VALUES (@v1,@v2)";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@v1", txtUserName.Text);
                cmd.Parameters.AddWithValue("@v2", txtPassword.Text);


                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show(rows > 0 ? "Register Successfully" : "Register Not Success");


            }*/

            FormMaindashboard formMaindashboard = new FormMaindashboard();

          //  LoardGrideView();

        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSignin_Load(object sender, EventArgs e)
        {

        }
    }
}
