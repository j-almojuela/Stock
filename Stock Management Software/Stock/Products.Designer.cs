namespace Stock
{
    partial class Products
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
            ProductCode = new TextBox();
            ProductName = new TextBox();
            Status = new ComboBox();
            DeleteButton = new Button();
            AddButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ResetButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ProductCode
            // 
            ProductCode.Location = new Point(42, 60);
            ProductCode.Name = "ProductCode";
            ProductCode.Size = new Size(187, 23);
            ProductCode.TabIndex = 0;
            // 
            // ProductName
            // 
            ProductName.Location = new Point(235, 61);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(187, 23);
            ProductName.TabIndex = 1;
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Items.AddRange(new object[] { "Active", "Deactivate" });
            Status.Location = new Point(428, 61);
            Status.Name = "Status";
            Status.Size = new Size(153, 23);
            Status.TabIndex = 2;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(612, 59);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(693, 59);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Product Code";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 42);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 6;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 42);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Status";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(41, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(808, 350);
            dataGridView1.TabIndex = 8;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Product Code";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Product Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.Name = "Column3";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(774, 59);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(75, 23);
            ResetButton.TabIndex = 9;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 593);
            Controls.Add(ResetButton);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(Status);
            Controls.Add(ProductName);
            Controls.Add(ProductCode);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProductCode;
        private TextBox ProductName;
        private ComboBox Status;
        private Button DeleteButton;
        private Button AddButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button ResetButton;
        private ErrorProvider errorProvider1;
    }
}