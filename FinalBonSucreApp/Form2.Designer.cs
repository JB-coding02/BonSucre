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
            LblName = new Label();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            LblDateOfBirth = new Label();
            TxtDateOfBirth = new TextBox();
            BtnAddCustomer = new Button();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Location = new Point(170, 24);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(150, 31);
            TxtName.TabIndex = 0;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(74, 27);
            LblName.Name = "LblName";
            LblName.Size = new Size(63, 25);
            LblName.TabIndex = 1;
            LblName.Text = "Name:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(170, 61);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(150, 31);
            TxtEmail.TabIndex = 2;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(79, 64);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(58, 25);
            LblEmail.TabIndex = 3;
            LblEmail.Text = "Email:";
            // 
            // LblDateOfBirth
            // 
            LblDateOfBirth.AutoSize = true;
            LblDateOfBirth.Location = new Point(18, 101);
            LblDateOfBirth.Name = "LblDateOfBirth";
            LblDateOfBirth.Size = new Size(119, 25);
            LblDateOfBirth.TabIndex = 4;
            LblDateOfBirth.Text = "Date Of Birth:";
            // 
            // TxtDateOfBirth
            // 
            TxtDateOfBirth.Location = new Point(170, 98);
            TxtDateOfBirth.Name = "TxtDateOfBirth";
            TxtDateOfBirth.Size = new Size(150, 31);
            TxtDateOfBirth.TabIndex = 5;
            // 
            // BtnAddCustomer
            // 
            BtnAddCustomer.Location = new Point(79, 156);
            BtnAddCustomer.Name = "BtnAddCustomer";
            BtnAddCustomer.Size = new Size(168, 34);
            BtnAddCustomer.TabIndex = 6;
            BtnAddCustomer.Text = "Add Customer";
            BtnAddCustomer.UseVisualStyleBackColor = true;
            BtnAddCustomer.Click += BtnAddCustomer_Click;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 213);
            Controls.Add(BtnAddCustomer);
            Controls.Add(TxtDateOfBirth);
            Controls.Add(LblDateOfBirth);
            Controls.Add(LblEmail);
            Controls.Add(TxtEmail);
            Controls.Add(LblName);
            Controls.Add(TxtName);
            Name = "AddCustomerForm";
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtName;
        private Label LblName;
        private TextBox TxtEmail;
        private Label LblEmail;
        private Label LblDateOfBirth;
        private TextBox TxtDateOfBirth;
        private Button BtnAddCustomer;
    }
}