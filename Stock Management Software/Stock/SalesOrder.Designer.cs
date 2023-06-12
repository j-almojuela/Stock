namespace Stock
{
    partial class SalesOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dgNo = new DataGridViewTextBoxColumn();
            dgType = new DataGridViewTextBoxColumn();
            dgDate = new DataGridViewTextBoxColumn();
            dgName = new DataGridViewTextBoxColumn();
            dgAmount = new DataGridViewTextBoxColumn();
            dgForeign = new DataGridViewTextBoxColumn();
            dgCurrency = new DataGridViewTextBoxColumn();
            dgAllocated = new DataGridViewTextBoxColumn();
            dgDespatched = new DataGridViewTextBoxColumn();
            dgPrinted = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgNo, dgType, dgDate, dgName, dgAmount, dgForeign, dgCurrency, dgAllocated, dgDespatched, dgPrinted });
            dataGridView1.Location = new Point(32, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1120, 318);
            dataGridView1.TabIndex = 0;
            // 
            // dgNo
            // 
            dgNo.HeaderText = "No.";
            dgNo.Name = "dgNo";
            dgNo.ReadOnly = true;
            // 
            // dgType
            // 
            dgType.HeaderText = "Type";
            dgType.Name = "dgType";
            dgType.ReadOnly = true;
            // 
            // dgDate
            // 
            dgDate.HeaderText = "Date";
            dgDate.Name = "dgDate";
            dgDate.ReadOnly = true;
            // 
            // dgName
            // 
            dgName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgName.HeaderText = "Name";
            dgName.Name = "dgName";
            dgName.ReadOnly = true;
            // 
            // dgAmount
            // 
            dgAmount.HeaderText = "Amount £";
            dgAmount.Name = "dgAmount";
            dgAmount.ReadOnly = true;
            // 
            // dgForeign
            // 
            dgForeign.HeaderText = "Foreign Amount";
            dgForeign.Name = "dgForeign";
            dgForeign.ReadOnly = true;
            // 
            // dgCurrency
            // 
            dgCurrency.HeaderText = "Currency Code";
            dgCurrency.Name = "dgCurrency";
            dgCurrency.ReadOnly = true;
            // 
            // dgAllocated
            // 
            dgAllocated.HeaderText = "Allocated";
            dgAllocated.Name = "dgAllocated";
            dgAllocated.ReadOnly = true;
            // 
            // dgDespatched
            // 
            dgDespatched.HeaderText = "Despatched";
            dgDespatched.Name = "dgDespatched";
            dgDespatched.ReadOnly = true;
            // 
            // dgPrinted
            // 
            dgPrinted.HeaderText = "Printed";
            dgPrinted.Name = "dgPrinted";
            dgPrinted.ReadOnly = true;
            // 
            // SalesOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 668);
            Controls.Add(dataGridView1);
            Name = "SalesOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesOrder";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dgNo;
        private DataGridViewTextBoxColumn dgType;
        private DataGridViewTextBoxColumn dgDate;
        private DataGridViewTextBoxColumn dgName;
        private DataGridViewTextBoxColumn dgAmount;
        private DataGridViewTextBoxColumn dgForeign;
        private DataGridViewTextBoxColumn dgCurrency;
        private DataGridViewTextBoxColumn dgAllocated;
        private DataGridViewTextBoxColumn dgDespatched;
        private DataGridViewTextBoxColumn dgPrinted;
    }
}