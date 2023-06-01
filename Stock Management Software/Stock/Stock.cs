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

namespace Stock
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            this.ActiveControl = dateTimePicker1;
            Status2.SelectedIndex = 0;
            LoadData();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductCode2.Focus();
            }
        }

        private void ProductCode2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ProductCode2.Text.Length > 0)
                {
                    ProductName2.Focus();
                }
                else
                {
                    ProductCode2.Focus();
                }
            }
        }

        private void ProductName2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ProductName2.Text.Length > 0)
                {
                    Quantity.Focus();
                }
                else
                {
                    ProductName2.Focus();
                }
            }
        }

        private void Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Quantity.Text.Length > 0)
                {
                    Status2.Focus();
                }
                else
                {
                    Quantity.Focus();
                }
            }
        }

        private void Status2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Status2.SelectedIndex != -1)
                {
                    AddButton2.Focus();
                }
                else
                {
                    Status2.Focus();
                }
            }
        }

        private void ProductCode2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void ResetRecords()
        {
            dateTimePicker1.Value = DateTime.Now;
            ProductCode2.Clear();
            ProductName2.Clear();
            Quantity.Clear();
            Status2.SelectedIndex = -1;
            AddButton2.Text = "Add";
            dateTimePicker1.Focus();
        }

        private void ResetButton2_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }
        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(ProductCode2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(ProductCode2, "Product code required");
            }
            else if (string.IsNullOrEmpty(ProductName2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(ProductName2, "Product name required");
            }
            else if (string.IsNullOrEmpty(Quantity.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(Quantity, "Quantity required");
            }
            else if (Status2.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(Status2, "Select status");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private bool IfProductsExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Stock] WHERE [ProductCode]='" + productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void AddButton2_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = Connection.GetConnection();
                con.Open();
                bool status = false;
                if (Status2.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                var sqlQuery = "";
                if (IfProductsExists(con, ProductCode2.Text))
                {
                    sqlQuery = @"UPDATE [Stock] SET [ProductName] = '" + ProductName2.Text + "' ,[Quantity] = '" + Quantity.Text + "',[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + ProductCode2.Text + "'";
                }
                else
                {
                    sqlQuery = @"INSERT INTO Stock (ProductCode, ProductName, TransDate, Quantity, ProductStatus)
                                 VALUES ('" + ProductCode2.Text + "','" + ProductName2.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + Quantity.Text + "','" + status + "')";
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record saved successfully");
                ResetRecords();
            }
        }
        public void LoadData()
        {
            SqlConnection con = Connection.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Stock].[dbo].[Stock]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells["dgProCode"].Value = item["ProductCode"].ToString();
                dataGridView2.Rows[n].Cells["dgProName"].Value = item["ProductName"].ToString();
                dataGridView2.Rows[n].Cells["dgQuantity"].Value = float.Parse(item["Quantity"].ToString());
                dataGridView2.Rows[n].Cells["dgDate"].Value = Convert.ToDateTime(item["TransDate"].ToString()).ToString("dd/MM/yyyy");
                if ((bool)item["ProductStatus"])
                {
                    dataGridView2.Rows[n].Cells["dgStatus"].Value = "Active";
                }
                else
                {
                    dataGridView2.Rows[n].Cells["dgstatus"].Value = "Inactive";
                }
            }
            if (dataGridView2.Rows.Count > 0)
            {
                LabelTotalProducts.Text = dataGridView2.Rows.Count.ToString();
                float totQty = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    totQty += float.Parse(dataGridView2.Rows[i].Cells["dgQuantity"].Value.ToString());
                    LabelTotalQuantity.Text = totQty.ToString();
                }
            }
            else
            {
                LabelTotalProducts.Text = "0";
                LabelTotalQuantity.Text = "0";
            }
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddButton2.Text = "Update";
            ProductCode2.Text = dataGridView2.SelectedRows[0].Cells["dgProCode"].Value.ToString();
            ProductName2.Text = dataGridView2.SelectedRows[0].Cells["dgProName"].Value.ToString();
            Quantity.Text = dataGridView2.SelectedRows[0].Cells["dgQuantity"].Value.ToString();
            dateTimePicker1.Text = DateTime.Parse(dataGridView2.SelectedRows[0].Cells["dgDate"].Value.ToString()).ToString("dd/MM/yyyy");
            if (dataGridView2.SelectedRows[0].Cells["dgStatus"].Value.ToString() == "Active")
            {
                Status2.SelectedIndex = 0;
            }
            else
            {
                Status2.SelectedIndex = 1;
            }
        }

        private void DeleteButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Validation())
                {
                    SqlConnection con = Connection.GetConnection();
                    var sqlQuery = "";
                    if (IfProductsExists(con, ProductCode2.Text))
                    {
                        con.Open();
                        sqlQuery = @"DELETE FROM [Stock] WHERE [ProductCode] = '" + ProductCode2.Text + "'";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Record does not exist");
                    }
                    LoadData();
                    ResetRecords();
                }
            }
        }
    }
}

