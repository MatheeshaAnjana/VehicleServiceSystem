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
using System.Xml.Linq;

namespace VehicleServiceSystem
{
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }
        public void getData()
        {
            string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Services";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewServices.DataSource = dt;



            }
        }
        private void FormService_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtServiceId.Text = dataGridViewServices.SelectedRows[0].Cells[0].Value.ToString();
            txtServiceName.Text = dataGridViewServices.SelectedRows[0].Cells[1].Value.ToString();
            txtServicePrice.Text = dataGridViewServices.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string query = "INSERT Services VALUES (@v1,@v2,@v3);";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@v1", txtServiceId.Text);
                    cmd.Parameters.AddWithValue("@v2", txtServiceName.Text);
                    cmd.Parameters.AddWithValue("@v3", txtServicePrice.Text);


                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully add ");
                    connection.Close();
                    getData();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string query = "UPDATE Services SET Service_Name = @v2,Service_Price = @v3 WHERE Service_ID = @v1";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@v1", txtServiceId.Text);
                    cmd.Parameters.AddWithValue("@v2", txtServiceName.Text);
                    cmd.Parameters.AddWithValue("@v3", txtServicePrice.Text);


                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated ");
                    connection.Close();
                    getData();
                    //MessageBox.Show(rows > 0 ? "Update SuccessFully" : "Not Update");

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string query = "DELETE FROM Services WHERE Service_ID = @v1";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@v1", txtServiceId.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully delete ");
                    connection.Close();
                    getData();
                    // MessageBox.Show(rows > 0 ? "Deleted" : "Delete Fail");
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

        private void dataGridViewServices_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtServiceId.Text = dataGridViewServices.SelectedRows[0].Cells[0].Value.ToString();
            txtServiceName.Text = dataGridViewServices.SelectedRows[0].Cells[1].Value.ToString();
            txtServicePrice.Text = dataGridViewServices.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void lblServiceID_Click(object sender, EventArgs e)
        {

        }
    }
}