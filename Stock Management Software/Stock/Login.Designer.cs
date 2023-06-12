namespace Stock
{
    partial class Login
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
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ClearButton = new Button();
            LoginButton = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(143, 79);
            Username.Name = "Username";
            Username.Size = new Size(277, 23);
            Username.TabIndex = 0;
            Username.Text = "admin";
            Username.TextChanged += Username_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(143, 132);
            Password.Name = "Password";
            Password.PasswordChar = '•';
            Password.Size = new Size(277, 23);
            Password.TabIndex = 1;
            Password.Text = "admin123";
            Password.TextChanged += Password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 61);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 114);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(143, 194);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(130, 43);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(290, 194);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(130, 43);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(320, 163);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 306);
            Controls.Add(linkLabel1);
            Controls.Add(LoginButton);
            Controls.Add(ClearButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Button ClearButton;
        private Button LoginButton;
        private LinkLabel linkLabel1;
    }
}