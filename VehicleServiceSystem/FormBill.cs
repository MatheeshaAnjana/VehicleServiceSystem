using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using DGVPrinterHelper;
namespace VehicleServiceSystem
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }
        DGVPrinter printer = new DGVPrinter();
        public void getServicedata()
        {
            string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Service_Name,Service_Price FROM Services";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataGridViewService.DataSource = dt;




            }
        }
        private void FormBill_Load(object sender, EventArgs e)
        {
            // getCMBdata();
            guna2DataGridView1.Hide();
            getServicedata();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            /* string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 string query = "SELECT VehicleModel FROM CusDetails WHERE CusID =" + txtCid.Text + ";";
                 SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                 DataTable dt = new DataTable();
                 adapter.Fill(dt);
                 txtVehicleModel.DataSource = dt;
                 txtVehicleModel.ValueMember = "VehicleType";
             }*/
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCallculateBill_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT VehicleModel,VehicleType FROM CusDetails WHERE CusID =" + txtCid.Text + ";";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    guna2DataGridView1.DataSource = dt;
                    //guna2DataGridView1.ValueMember = "VehicleType";
                    txtVehicleModel.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    cmbVehicleType.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtServiceName.Text = DataGridViewService.SelectedRows[0].Cells[0].Value.ToString();
            txtServicePrice.Text = DataGridViewService.SelectedRows[0].Cells[1].Value.ToString();
        }
        double Grand_tot = 0, n = 0;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length >0) {
                string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Service_Name,Service_Price FROM Services WHERE Service_Name LIKE '%" + txtSearch.Text + "%';";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGridViewService.DataSource = dt;

                   

                }
            }
            else
            {
                string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Service_Name,Service_Price FROM Services";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGridViewService.DataSource = dt;




                }
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            try
            {
                printer.Title = " AUTO MOTIVE SERVICE ";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Your Grand Total = Rs. " + txtTotalBill.Text;
                printer.FooterSpacing = 15;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(DataGridViewBill);

                //report form
               




            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format error: " + ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);
            }

            try
            {
                string connectionString = "Data Source=MATHEESHA;Initial Catalog=Customer;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string query = "string query = \"INSERT INTO report(bill_id, cus_id, vehicle_model, select_services, grand_total, date) VALUES (@v1, @v2, @v3, @v4, @v5, @v6);\";\r\n";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@v1", Convert.ToInt32(12));
                    cmd.Parameters.AddWithValue("@v2", Convert.ToInt32(txtCid.Text));
                    cmd.Parameters.AddWithValue("@v3", txtVehicleModel.Text);
                    cmd.Parameters.AddWithValue("@v4", txtServiceName.Text);
                    cmd.Parameters.AddWithValue("@v5", Convert.ToDouble(txtTotalBill.Text));
                    cmd.Parameters.AddWithValue("@v6", DateTime.Now.Date);

                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("Register Not Success");
                    }
                    else
                    {
                        MessageBox.Show("Register Success");
                    }




                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtServicePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtServiceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DataGridViewBill);
                row.Cells[0].Value = n++;
                row.Cells[1].Value = txtCid.Text;
                row.Cells[2].Value = txtVehicleModel.Text;
                row.Cells[3].Value = txtServiceName.Text;
                row.Cells[4].Value = txtServicePrice.Text;
                //row.Cells[5].Value = txtServiceName.Text;
                DataGridViewBill.Rows.Add(row);
                Grand_tot = Convert.ToDouble(txtServicePrice.Text) + Grand_tot;
                txtTotalBill.Text = Convert.ToString(Grand_tot);
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
    }
}
