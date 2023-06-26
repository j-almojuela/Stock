using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Delivery : Form
    {
        public Delivery(string order, string item)
        {
            InitializeComponent();

            dataGridView5.Rows.Add();
            dataGridView5.Rows[0].Cells[0].Value = order;
            dataGridView5.Rows[0].Cells[1].Value = item;
        }

        private void Delivery_Load(object sender, EventArgs e)
        {

        }
    }
}
