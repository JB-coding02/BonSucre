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
            LblName = new Label();
            LblEmail = new Label();
            LblCustomerId = new Label();
            BtnUpdate = new Button();
            TxtCustomerName = new TextBox();
            TxtCustomerEmail = new TextBox();
            TxtCustomerDateOfBirth = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVCustomers).BeginInit();
            SuspendLayout();
            // 
            // DGVCustomers
            // 
            DGVCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCustomers.Location = new Point(12, 12);
            DGVCustomers.Name = "DGVCustomers";
            DGVCustomers.RowHeadersWidth = 62;
            DGVCustomers.Size = new Size(776, 265);
            DGVCustomers.TabIndex = 0;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(119, 358);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(150, 31);
            TxtId.TabIndex = 3;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(12, 287);
            LblName.Name = "LblName";
            LblName.Size = new Size(59, 25);
            LblName.TabIndex = 4;
            LblName.Text = "Name";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(17, 324);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(54, 25);
            LblEmail.TabIndex = 5;
            LblEmail.Text = "Email";
            // 
            // LblCustomerId
            // 
            LblCustomerId.AutoSize = true;
            LblCustomerId.Location = new Point(43, 361);
            LblCustomerId.Name = "LblCustomerId";
            LblCustomerId.Size = new Size(28, 25);
            LblCustomerId.TabIndex = 6;
            LblCustomerId.Text = "Id";
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(294, 287);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(112, 99);
            BtnUpdate.TabIndex = 7;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // TxtCustomerName
            // 
            TxtCustomerName.Location = new Point(119, 284);
            TxtCustomerName.Name = "TxtCustomerName";
            TxtCustomerName.Size = new Size(150, 31);
            TxtCustomerName.TabIndex = 8;
            // 
            // TxtCustomerEmail
            // 
            TxtCustomerEmail.Location = new Point(119, 321);
            TxtCustomerEmail.Name = "TxtCustomerEmail";
            TxtCustomerEmail.Size = new Size(150, 31);
            TxtCustomerEmail.TabIndex = 9;
            // 
            // TxtCustomerDateOfBirth
            // 
            TxtCustomerDateOfBirth.Location = new Point(119, 395);
            TxtCustomerDateOfBirth.Name = "TxtCustomerDateOfBirth";
            TxtCustomerDateOfBirth.Size = new Size(150, 31);
            TxtCustomerDateOfBirth.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 398);
            label1.Name = "label1";
            label1.Size = new Size(74, 50);
            label1.TabIndex = 11;
            label1.Text = "Date Of\r\nBirth";
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TxtCustomerDateOfBirth);
            Controls.Add(TxtCustomerEmail);
            Controls.Add(TxtCustomerName);
            Controls.Add(BtnUpdate);
            Controls.Add(LblCustomerId);
            Controls.Add(LblEmail);
            Controls.Add(LblName);
            Controls.Add(TxtId);
            Controls.Add(DGVCustomers);
            Name = "UpdateCustomerForm";
            Text = "UpdateCustomer";
            Load += UpdateCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)DGVCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVCustomers;
        private TextBox TxtId;
        private Label LblName;
        private Label LblEmail;
        private Label LblCustomerId;
        private Button BtnUpdate;
        private TextBox TxtCustomerName;
        private TextBox TxtCustomerEmail;
        private TextBox TxtCustomerDateOfBirth;
        private Label label1;
    }
}