namespace Stock
{
    partial class SalesOrderLines
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
            label1 = new Label();
            label2 = new Label();
            SelectionBox = new ComboBox();
            SearchBox = new TextBox();
            dataGridView4 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 53);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 0;
            label1.Text = "Sort by";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(352, 53);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // SelectionBox
            // 
            SelectionBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SelectionBox.FormattingEnabled = true;
            SelectionBox.Items.AddRange(new object[] { "Order Number", "Item Number", "Stock Code", "Description", "Quantity Order", "Quantity Allocated" });
            SelectionBox.Location = new Point(104, 45);
            SelectionBox.Name = "SelectionBox";
            SelectionBox.Size = new Size(217, 29);
            SelectionBox.TabIndex = 2;
            SelectionBox.Text = "Select";
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.Location = new Point(419, 45);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Search                                                                         🔍";
            SearchBox.Size = new Size(374, 29);
            SearchBox.TabIndex = 3;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // dataGridView4
            // 
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(32, 118);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(1122, 486);
            dataGridView4.TabIndex = 4;
            // 
            // SalesOrderLines
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 668);
            Controls.Add(dataGridView4);
            Controls.Add(SearchBox);
            Controls.Add(SelectionBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SalesOrderLines";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Order Lines";
            Load += SalesOrderLines_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox SelectionBox;
        private TextBox SearchBox;
        private DataGridView dataGridView4;
    }
}