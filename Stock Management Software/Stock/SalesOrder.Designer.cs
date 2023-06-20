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
            dataGridView3 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            DropDownList = new ComboBox();
            Search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.Location = new Point(34, 87);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(1120, 318);
            dataGridView3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 39);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 1;
            label1.Text = "Select Cateogry";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(410, 39);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Search";
            // 
            // DropDownList
            // 
            DropDownList.FormattingEnabled = true;
            DropDownList.Items.AddRange(new object[] { "Order Number", "Allocated Status", "Despatch Status", "Account Ref", "Name" });
            DropDownList.Location = new Point(170, 39);
            DropDownList.Name = "DropDownList";
            DropDownList.Size = new Size(216, 23);
            DropDownList.TabIndex = 3;
            // 
            // Search
            // 
            Search.Location = new Point(477, 39);
            Search.Name = "Search";
            Search.Size = new Size(362, 23);
            Search.TabIndex = 4;
            Search.TextChanged += Search_TextChanged;
            // 
            // SalesOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 668);
            Controls.Add(Search);
            Controls.Add(DropDownList);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Name = "SalesOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Order";
            Load += SalesOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView3;
        private Label label1;
        private Label label2;
        private ComboBox DropDownList;
        private TextBox Search;
    }
}