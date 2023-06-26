using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class SalesOrderLines : Form
    {
        public SalesOrderLines()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable("SOP_ITEM");
        private void SalesOrderLines_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["StockConn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from SOP_ITEM", cn))
                    {
                        da.Fill(dt);
                        dataGridView4.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        SqlConnection con = new SqlConnection("Data Source=BLACKPERL\\WORKBENCH;Initial Catalog=SANDBOX_SAGE50;Integrated Security =True;User ID=sa;Password=***********");

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectionBox.Text == "Order Number")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SOP_ITEM] WHERE ORDER_NUMBER LIKE '" + SearchBox.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView4.DataSource = data;
            }
            else if (SelectionBox.Text == "Item Number")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SOP_ITEM] WHERE ITEM_NUMBER LIKE '" + SearchBox.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView4.DataSource = data;
            }
            else if (SelectionBox.Text == "Stock Code")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SOP_ITEM] WHERE STOCK_CODE LIKE '" + SearchBox.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView4.DataSource = data;
            }
            else if (SelectionBox.Text == "Description")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SOP_ITEM] WHERE DESCRIPTION LIKE '" + SearchBox.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView4.DataSource = data;
            }
            else if (SelectionBox.Text == "Quantity Order")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SOP_ITEM] WHERE QTY_ORDER LIKE '" + SearchBox.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView4.DataSource = data;
            }
            else if (SelectionBox.Text == "Quantity Allocated")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SOP_ITEM] WHERE QTY_ALLOCATED LIKE '" + SearchBox.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView4.DataSource = data;
            }
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Delivery ship = new Delivery(dataGridView4.SelectedRows[0].Cells[0].Value.ToString(),
                                          dataGridView4.SelectedRows[0].Cells[1].Value.ToString());

            ship.Show();
        }
    }
}
