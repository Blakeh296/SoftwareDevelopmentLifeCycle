using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aw2012VendorNameandAddress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1LoadData_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Define connection string. See ConnectionStrings.com for reference.
                string connectionString = @"Server=PL12\MTCDEVDB;Database=AdventureWorks2012;Trusted_Connection=True;";

                // Define the connection using the connection string.
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                // Define a data adapter to pull the data from the server using the connection and a stored procedure.
                SqlDataAdapter dataAdapter = new SqlDataAdapter("dbo.vendorNameandAddress", sqlConnection);

                // Declare an empty data table to hold the data.
                DataTable DataTableGridView1 = new DataTable();

                // Fill the data table using the data adapter.
                dataAdapter.Fill(DataTableGridView1);

                // Use the data table as the data source for a data grid control.
                dataGridView1.DataSource = DataTableGridView1;
            }
            
            catch
            {
                MessageBox.Show("How did you break it?");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
