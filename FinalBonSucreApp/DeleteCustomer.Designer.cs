namespace FinalBonSucreApp
{
    partial class DeleteCustomerForm
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
            DGVCustomer = new DataGridView();
            BtnDeleteCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVCustomer).BeginInit();
            SuspendLayout();
            // 
            // DGVCustomer
            // 
            DGVCustomer.ColumnHeadersHeight = 34;
            DGVCustomer.Location = new Point(12, 12);
            DGVCustomer.Name = "DGVCustomer";
            DGVCustomer.RowHeadersWidth = 62;
            DGVCustomer.Size = new Size(364, 229);
            DGVCustomer.TabIndex = 2;
            // 
            // BtnDeleteCustomer
            // 
            BtnDeleteCustomer.Location = new Point(12, 247);
            BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            BtnDeleteCustomer.Size = new Size(364, 34);
            BtnDeleteCustomer.TabIndex = 1;
            BtnDeleteCustomer.Text = "Delete Customer";
            BtnDeleteCustomer.UseVisualStyleBackColor = true;
            BtnDeleteCustomer.Click += BtnDeleteCustomer_Click;
            // 
            // DeleteCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 288);
            Controls.Add(BtnDeleteCustomer);
            Controls.Add(DGVCustomer);
            Name = "DeleteCustomer";
            Text = "Delete Customer";
            Load += DeleteCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)DGVCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVCustomer;
        private Button BtnDeleteCustomer;
    }
}