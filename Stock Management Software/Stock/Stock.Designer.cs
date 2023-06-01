namespace Stock
{
    partial class Stock
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
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            ProductCode2 = new TextBox();
            ProductName2 = new TextBox();
            Quantity = new TextBox();
            Status2 = new ComboBox();
            AddButton2 = new Button();
            DeleteButton2 = new Button();
            ResetButton2 = new Button();
            dataGridView2 = new DataGridView();
            dgProCode = new DataGridViewTextBoxColumn();
            dgProName = new DataGridViewTextBoxColumn();
            dgQuantity = new DataGridViewTextBoxColumn();
            dgDate = new DataGridViewTextBoxColumn();
            dgStatus = new DataGridViewTextBoxColumn();
            LabelTotalProducts = new Label();
            LabelTotalQuantity = new Label();
            Date = new Label();
            ProdCode = new Label();
            ProdName = new Label();
            Qty = new Label();
            Stat = new Label();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(48, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(96, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // ProductCode2
            // 
            ProductCode2.Location = new Point(175, 75);
            ProductCode2.Name = "ProductCode2";
            ProductCode2.Size = new Size(148, 23);
            ProductCode2.TabIndex = 1;
            ProductCode2.KeyDown += ProductCode2_KeyDown;
            ProductCode2.KeyPress += ProductCode2_KeyPress;
            // 
            // ProductName2
            // 
            ProductName2.Location = new Point(339, 75);
            ProductName2.Name = "ProductName2";
            ProductName2.Size = new Size(148, 23);
            ProductName2.TabIndex = 2;
            ProductName2.KeyDown += ProductName2_KeyDown;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(503, 75);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(113, 23);
            Quantity.TabIndex = 3;
            Quantity.KeyDown += Quantity_KeyDown;
            Quantity.KeyPress += Quantity_KeyPress;
            // 
            // Status2
            // 
            Status2.DropDownStyle = ComboBoxStyle.DropDownList;
            Status2.FormattingEnabled = true;
            Status2.Items.AddRange(new object[] { "Active", "Inactive" });
            Status2.Location = new Point(631, 75);
            Status2.Name = "Status2";
            Status2.Size = new Size(121, 23);
            Status2.TabIndex = 4;
            Status2.KeyDown += Status2_KeyDown;
            // 
            // AddButton2
            // 
            AddButton2.Location = new Point(766, 163);
            AddButton2.Name = "AddButton2";
            AddButton2.Size = new Size(85, 37);
            AddButton2.TabIndex = 5;
            AddButton2.Text = "Add";
            AddButton2.UseVisualStyleBackColor = true;
            AddButton2.Click += AddButton2_Click;
            // 
            // DeleteButton2
            // 
            DeleteButton2.Location = new Point(766, 206);
            DeleteButton2.Name = "DeleteButton2";
            DeleteButton2.Size = new Size(85, 35);
            DeleteButton2.TabIndex = 6;
            DeleteButton2.Text = "Delete";
            DeleteButton2.UseVisualStyleBackColor = true;
            DeleteButton2.Click += DeleteButton2_Click;
            // 
            // ResetButton2
            // 
            ResetButton2.Location = new Point(766, 247);
            ResetButton2.Name = "ResetButton2";
            ResetButton2.Size = new Size(85, 37);
            ResetButton2.TabIndex = 7;
            ResetButton2.Text = "Reset";
            ResetButton2.UseVisualStyleBackColor = true;
            ResetButton2.Click += ResetButton2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dgProCode, dgProName, dgQuantity, dgDate, dgStatus });
            dataGridView2.Location = new Point(48, 162);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(704, 339);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView1_CellContentClick;
            dataGridView2.MouseDoubleClick += dataGridView2_MouseDoubleClick;
            // 
            // dgProCode
            // 
            dgProCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgProCode.HeaderText = "Product Code";
            dgProCode.Name = "dgProCode";
            // 
            // dgProName
            // 
            dgProName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgProName.HeaderText = "Product Name";
            dgProName.Name = "dgProName";
            // 
            // dgQuantity
            // 
            dgQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgQuantity.HeaderText = "Quantity";
            dgQuantity.Name = "dgQuantity";
            // 
            // dgDate
            // 
            dgDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgDate.HeaderText = "Date";
            dgDate.Name = "dgDate";
            // 
            // dgStatus
            // 
            dgStatus.HeaderText = "Status";
            dgStatus.Name = "dgStatus";
            // 
            // LabelTotalProducts
            // 
            LabelTotalProducts.AutoSize = true;
            LabelTotalProducts.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotalProducts.Location = new Point(162, 126);
            LabelTotalProducts.Name = "LabelTotalProducts";
            LabelTotalProducts.Size = new Size(18, 20);
            LabelTotalProducts.TabIndex = 10;
            LabelTotalProducts.Text = "0";
            // 
            // LabelTotalQuantity
            // 
            LabelTotalQuantity.AutoSize = true;
            LabelTotalQuantity.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotalQuantity.Location = new Point(454, 126);
            LabelTotalQuantity.Name = "LabelTotalQuantity";
            LabelTotalQuantity.Size = new Size(18, 20);
            LabelTotalQuantity.TabIndex = 11;
            LabelTotalQuantity.Text = "0";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(48, 48);
            Date.Name = "Date";
            Date.Size = new Size(31, 15);
            Date.TabIndex = 12;
            Date.Text = "Date";
            // 
            // ProdCode
            // 
            ProdCode.AutoSize = true;
            ProdCode.Location = new Point(175, 48);
            ProdCode.Name = "ProdCode";
            ProdCode.Size = new Size(80, 15);
            ProdCode.TabIndex = 13;
            ProdCode.Text = "Product Code";
            // 
            // ProdName
            // 
            ProdName.AutoSize = true;
            ProdName.Location = new Point(339, 48);
            ProdName.Name = "ProdName";
            ProdName.Size = new Size(81, 15);
            ProdName.TabIndex = 14;
            ProdName.Text = "ProductName";
            // 
            // Qty
            // 
            Qty.AutoSize = true;
            Qty.Location = new Point(503, 48);
            Qty.Name = "Qty";
            Qty.Size = new Size(53, 15);
            Qty.TabIndex = 15;
            Qty.Text = "Quantity";
            // 
            // Stat
            // 
            Stat.AutoSize = true;
            Stat.Location = new Point(631, 48);
            Stat.Name = "Stat";
            Stat.Size = new Size(39, 15);
            Stat.TabIndex = 16;
            Stat.Text = "Status";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 126);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 17;
            label1.Text = "Total Products:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(339, 126);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 18;
            label2.Text = "Total Quantity:";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 542);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Stat);
            Controls.Add(Qty);
            Controls.Add(ProdName);
            Controls.Add(ProdCode);
            Controls.Add(Date);
            Controls.Add(LabelTotalQuantity);
            Controls.Add(LabelTotalProducts);
            Controls.Add(dataGridView2);
            Controls.Add(ResetButton2);
            Controls.Add(DeleteButton2);
            Controls.Add(AddButton2);
            Controls.Add(Status2);
            Controls.Add(Quantity);
            Controls.Add(ProductName2);
            Controls.Add(ProductCode2);
            Controls.Add(dateTimePicker1);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox ProductCode2;
        private TextBox ProductName2;
        private TextBox Quantity;
        private ComboBox Status2;
        private Button AddButton2;
        private Button DeleteButton2;
        private Button ResetButton2;
        private DataGridView dataGridView2;
        private Label LabelTotalProducts;
        private Label LabelTotalQuantity;
        private Label Date;
        private Label ProdCode;
        private Label ProdName;
        private Label Qty;
        private Label Stat;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn dgProCode;
        private DataGridViewTextBoxColumn dgProName;
        private DataGridViewTextBoxColumn dgQuantity;
        private DataGridViewTextBoxColumn dgDate;
        private DataGridViewTextBoxColumn dgStatus;
        private Label label2;
        private Label label1;
    }
}