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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtVehicleModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVehicleType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "DELETE FROM CusDetails WHERE CusID = @v1";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@v1", txtCustomerID.Text);

                connection.Open();
               int rows =  command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show(rows > 0 ? "Deleted" : "Delete Fail");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            cmbVehicleType.Items.Clear();
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtVehicleModel.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "UPDATE CusDetails SET CusFullName = @v2,CusPhone = @v3,CusEmail = @v4,VehicleType = @v5,VehicleModel = @v6 WHERE CusID = @v1";

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

                MessageBox.Show(rows > 0 ? "Update SuccessFully" : "Not Update");

            }
            }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
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

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
    