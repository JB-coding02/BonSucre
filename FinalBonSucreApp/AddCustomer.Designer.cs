namespace FinalBonSucreApp
{
    partial class AddCustomerForm
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
            TxtName = new TextBox();
            LblCustomerName = new Label();
            TxtEmail = new TextBox();
            LblCustomerEmail = new Label();
            LblCustomerDateOfBirth = new Label();
            TxtDateOfBirth = new TextBox();
            BtnAddCustomer = new Button();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Location = new Point(119, 14);
            TxtName.Margin = new Padding(2, 2, 2, 2);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(106, 23);
            TxtName.TabIndex = 0;
            // 
            // LblCustomerName
            // 
            LblCustomerName.AutoSize = true;
            LblCustomerName.Location = new Point(49, 14);
            LblCustomerName.Margin = new Padding(2, 0, 2, 0);
            LblCustomerName.Name = "LblCustomerName";
            LblCustomerName.Size = new Size(42, 15);
            LblCustomerName.TabIndex = 1;
            LblCustomerName.Text = "Name:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(119, 37);
            TxtEmail.Margin = new Padding(2, 2, 2, 2);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(106, 23);
            TxtEmail.TabIndex = 2;
            // 
            // LblCustomerEmail
            // 
            LblCustomerEmail.AutoSize = true;
            LblCustomerEmail.Location = new Point(55, 38);
            LblCustomerEmail.Margin = new Padding(2, 0, 2, 0);
            LblCustomerEmail.Name = "LblCustomerEmail";
            LblCustomerEmail.Size = new Size(39, 15);
            LblCustomerEmail.TabIndex = 3;
            LblCustomerEmail.Text = "Email:";
            // 
            // LblCustomerDateOfBirth
            // 
            LblCustomerDateOfBirth.AutoSize = true;
            LblCustomerDateOfBirth.Location = new Point(13, 61);
            LblCustomerDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            LblCustomerDateOfBirth.Name = "LblCustomerDateOfBirth";
            LblCustomerDateOfBirth.Size = new Size(78, 15);
            LblCustomerDateOfBirth.TabIndex = 4;
            LblCustomerDateOfBirth.Text = "Date Of Birth:";
            // 
            // TxtDateOfBirth
            // 
            TxtDateOfBirth.Location = new Point(119, 59);
            TxtDateOfBirth.Margin = new Padding(2, 2, 2, 2);
            TxtDateOfBirth.Name = "TxtDateOfBirth";
            TxtDateOfBirth.Size = new Size(106, 23);
            TxtDateOfBirth.TabIndex = 5;
            // 
            // BtnAddCustomer
            // 
            BtnAddCustomer.Location = new Point(55, 94);
            BtnAddCustomer.Margin = new Padding(2, 2, 2, 2);
            BtnAddCustomer.Name = "BtnAddCustomer";
            BtnAddCustomer.Size = new Size(118, 20);
            BtnAddCustomer.TabIndex = 6;
            BtnAddCustomer.Text = "Add Customer";
            BtnAddCustomer.UseVisualStyleBackColor = true;
            BtnAddCustomer.Click += BtnAddCustomer_Click;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 128);
            Controls.Add(BtnAddCustomer);
            Controls.Add(TxtDateOfBirth);
            Controls.Add(LblCustomerDateOfBirth);
            Controls.Add(LblCustomerEmail);
            Controls.Add(TxtEmail);
            Controls.Add(LblCustomerName);
            Controls.Add(TxtName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddCustomerForm";
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtName;
        private Label LblCustomerName;
        private TextBox TxtEmail;
        private Label LblCustomerEmail;
        private Label LblCustomerDateOfBirth;
        private TextBox TxtDateOfBirth;
        private Button BtnAddCustomer;
    }
}