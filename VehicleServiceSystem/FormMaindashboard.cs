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
    public partial class FormMaindashboard : Form
    {
        public FormMaindashboard()
        {
            InitializeComponent();
        }

        private void FormMaindashboard_Load(object sender, EventArgs e)
        {
            LoardGrideView();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
          //  LoardGrideView();
        }

        private void DataCustomerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoardGrideView()
        {
            string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CusDetails";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataCustomerDetails.DataSource = dt;



            }



        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Length > 0)
            {
                string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM CusDetails WHERE CusId LIKE '%" + txtCustomerID.Text + "%';";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataCustomerDetails.DataSource = dt;



                }
            }
            else {
                string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM CusDetails";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataCustomerDetails.DataSource = dt;



                }
            }
        }

        private void DataCustomerDetails2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataCustomerDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
