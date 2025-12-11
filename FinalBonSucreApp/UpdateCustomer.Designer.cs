namespace FinalBonSucreApp
{
    partial class UpdateCustomerForm
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
            DGVCustomers = new DataGridView();
            TxtId = new TextBox();
            LblCustomerName = new Label();
            LblCustomerEmail = new Label();
            LblCustomerId = new Label();
            BtnUpdate = new Button();
            TxtCustomerName = new TextBox();
            TxtCustomerEmail = new TextBox();
            TxtCustomerDateOfBirth = new TextBox();
            LblCustomerDateOfBirth = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVCustomers).BeginInit();
            SuspendLayout();
            // 
            // DGVCustomers
            // 
            DGVCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCustomers.Location = new Point(8, 7);
            DGVCustomers.Margin = new Padding(2, 2, 2, 2);
            DGVCustomers.Name = "DGVCustomers";
            DGVCustomers.RowHeadersWidth = 62;
            DGVCustomers.Size = new Size(543, 159);
            DGVCustomers.TabIndex = 0;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(83, 215);
            TxtId.Margin = new Padding(2, 2, 2, 2);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(106, 23);
            TxtId.TabIndex = 3;
            // 
            // LblCustomerName
            // 
            LblCustomerName.AutoSize = true;
            LblCustomerName.Location = new Point(8, 172);
            LblCustomerName.Margin = new Padding(2, 0, 2, 0);
            LblCustomerName.Name = "LblCustomerName";
            LblCustomerName.Size = new Size(39, 15);
            LblCustomerName.TabIndex = 4;
            LblCustomerName.Text = "Name";
            // 
            // LblCustomerEmail
            // 
            LblCustomerEmail.AutoSize = true;
            LblCustomerEmail.Location = new Point(12, 194);
            LblCustomerEmail.Margin = new Padding(2, 0, 2, 0);
            LblCustomerEmail.Name = "LblCustomerEmail";
            LblCustomerEmail.Size = new Size(36, 15);
            LblCustomerEmail.TabIndex = 5;
            LblCustomerEmail.Text = "Email";
            // 
            // LblCustomerId
            // 
            LblCustomerId.AutoSize = true;
            LblCustomerId.Location = new Point(30, 217);
            LblCustomerId.Margin = new Padding(2, 0, 2, 0);
            LblCustomerId.Name = "LblCustomerId";
            LblCustomerId.Size = new Size(17, 15);
            LblCustomerId.TabIndex = 6;
            LblCustomerId.Text = "Id";
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(206, 172);
            BtnUpdate.Margin = new Padding(2, 2, 2, 2);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(78, 59);
            BtnUpdate.TabIndex = 7;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // TxtCustomerName
            // 
            TxtCustomerName.Location = new Point(83, 170);
            TxtCustomerName.Margin = new Padding(2, 2, 2, 2);
            TxtCustomerName.Name = "TxtCustomerName";
            TxtCustomerName.Size = new Size(106, 23);
            TxtCustomerName.TabIndex = 8;
            // 
            // TxtCustomerEmail
            // 
            TxtCustomerEmail.Location = new Point(83, 193);
            TxtCustomerEmail.Margin = new Padding(2, 2, 2, 2);
            TxtCustomerEmail.Name = "TxtCustomerEmail";
            TxtCustomerEmail.Size = new Size(106, 23);
            TxtCustomerEmail.TabIndex = 9;
            // 
            // TxtCustomerDateOfBirth
            // 
            TxtCustomerDateOfBirth.Location = new Point(83, 237);
            TxtCustomerDateOfBirth.Margin = new Padding(2, 2, 2, 2);
            TxtCustomerDateOfBirth.Name = "TxtCustomerDateOfBirth";
            TxtCustomerDateOfBirth.Size = new Size(106, 23);
            TxtCustomerDateOfBirth.TabIndex = 10;
            // 
            // LblCustomerDateOfBirth
            // 
            LblCustomerDateOfBirth.AutoSize = true;
            LblCustomerDateOfBirth.Location = new Point(8, 239);
            LblCustomerDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            LblCustomerDateOfBirth.Name = "LblCustomerDateOfBirth";
            LblCustomerDateOfBirth.Size = new Size(47, 30);
            LblCustomerDateOfBirth.TabIndex = 11;
            LblCustomerDateOfBirth.Text = "Date Of\r\nBirth";
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(LblCustomerDateOfBirth);
            Controls.Add(TxtCustomerDateOfBirth);
            Controls.Add(TxtCustomerEmail);
            Controls.Add(TxtCustomerName);
            Controls.Add(BtnUpdate);
            Controls.Add(LblCustomerId);
            Controls.Add(LblCustomerEmail);
            Controls.Add(LblCustomerName);
            Controls.Add(TxtId);
            Controls.Add(DGVCustomers);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UpdateCustomerForm";
            Text = "Update Customer";
            Load += UpdateCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)DGVCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVCustomers;
        private TextBox TxtId;
        private Label LblCustomerName;
        private Label LblCustomerEmail;
        private Label LblCustomerId;
        private Button BtnUpdate;
        private TextBox TxtCustomerName;
        private TextBox TxtCustomerEmail;
        private TextBox TxtCustomerDateOfBirth;
        private Label LblCustomerDateOfBirth;
    }
}