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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stock
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            Status.SelectedIndex = 0;
            LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = Connection.GetConnection();
                //Insert logic
                con.Open();
                bool status = false;
                if (Status.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                var sqlQuery = "";
                if (IfProductsExists(con, ProductCode.Text))
                {
                    sqlQuery = @"UPDATE [Products] SET [ProductName] = '" + ProductName.Text + "' ,[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + ProductCode.Text + "'";
                }
                else
                {
                    sqlQuery = @"INSERT INTO [Stock].[dbo].[Products] ([ProductCode],[ProductName],[ProductStatus]) VALUES
                            ('" + ProductCode.Text + "','" + ProductName.Text + "','" + status + "')";
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                //Reading Data
                LoadData();
                ResetRecords(); 
            }
        }

        private bool IfProductsExists(SqlConnection con, string ProductCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Products] WHERE [ProductCode]= '" + ProductCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void LoadData()
        {
            SqlConnection con = Connection.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Stock].[dbo].[Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactivate";
                }

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddButton.Text = "Update";
            ProductCode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ProductName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                Status.SelectedIndex = 0;
            }
            else
            {
                Status.SelectedIndex = 1;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (Validation())
            {
                SqlConnection con = Connection.GetConnection();
                var sqlQuery = "";
                if (IfProductsExists(con, ProductCode.Text))
                {
                    con.Open();
                    sqlQuery = @"DELETE FROM [Products] WHERE [ProductCode] = '" + ProductCode.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Record does not exist");
                }
                //Reading Data
                LoadData();
                ResetRecords();
            }
        }

        private void ResetRecords()
        {
            ProductCode.Clear();
            ProductName.Clear();
            Status.SelectedIndex = -1;
            AddButton.Text = "Add";
            ProductCode.Focus();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }

        private bool Validation()
        {
            bool result = false;
            if(!string.IsNullOrEmpty(ProductCode.Text) && !string.IsNullOrEmpty(ProductName.Text) && Status.SelectedIndex > -1)
            {
                result = true;
            }
            return result;
        }
    }
}

