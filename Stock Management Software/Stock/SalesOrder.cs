using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Stock
{
    public partial class SalesOrder : Form
    {
        public SalesOrder()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable("SALES_ORDER");
        private void SalesOrder_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["StockConn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from SALES_ORDER", cn))
                    {
                        da.Fill(dt);
                        dataGridView3.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        SqlConnection con = new SqlConnection("Data Source=BLACKPERL\\WORKBENCH;Initial Catalog=SANDBOX_SAGE50;Integrated Security =True;User ID=sa;Password=***********");
        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (DropDownList.Text == "Order Number")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SALES_ORDER] WHERE ORDER_NUMBER LIKE '" + Search.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView3.DataSource = data;
            }
            else if (DropDownList.Text == "Allocated Status")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SALES_ORDER] WHERE ALLOCATED_STATUS LIKE '" + Search.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView3.DataSource = data;
            }
            else if (DropDownList.Text == "Despatch Status")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SALES_ORDER] WHERE DESPATCH_STATUS LIKE '" + Search.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView3.DataSource = data;
            }
            else if (DropDownList.Text == "Account Ref")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SALES_ORDER] WHERE ACCOUNT_REF LIKE '" + Search.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView3.DataSource = data;
            }
            else if (DropDownList.Text == "Name")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [SANDBOX_SAGE50].[dbo].[SALES_ORDER] WHERE NAME LIKE '" + Search.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView3.DataSource = data;
            }
        }
    }
}


