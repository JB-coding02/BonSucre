namespace FinalBonSucreApp
{
    partial class AddDessert
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
            BtnAddDessert = new Button();
            LblPrice = new Label();
            TxtPrice = new TextBox();
            TxtCategory = new TextBox();
            LblCategory = new Label();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Location = new Point(123, 46);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(150, 31);
            TxtName.TabIndex = 0;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(31, 49);
            LblName.Name = "LblName";
            LblName.Size = new Size(63, 25);
            LblName.TabIndex = 1;
            LblName.Text = "Name:";
            // 
            // BtnAddDessert
            // 
            BtnAddDessert.Location = new Point(104, 230);
            BtnAddDessert.Name = "BtnAddDessert";
            BtnAddDessert.Size = new Size(148, 34);
            BtnAddDessert.TabIndex = 2;
            BtnAddDessert.Text = "Add Dessert";
            BtnAddDessert.UseVisualStyleBackColor = true;
            BtnAddDessert.Click += BtnAddDessert_Click;
            // 
            // LblPrice
            // 
            LblPrice.AutoSize = true;
            LblPrice.Location = new Point(41, 86);
            LblPrice.Name = "LblPrice";
            LblPrice.Size = new Size(53, 25);
            LblPrice.TabIndex = 3;
            LblPrice.Text = "Price:";
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(123, 83);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(150, 31);
            TxtPrice.TabIndex = 4;
            // 
            // TxtCategory
            // 
            TxtCategory.Location = new Point(123, 120);
            TxtCategory.Name = "TxtCategory";
            TxtCategory.Size = new Size(150, 31);
            TxtCategory.TabIndex = 5;
            // 
            // LblCategory
            // 
            LblCategory.AutoSize = true;
            LblCategory.Location = new Point(6, 123);
            LblCategory.Name = "LblCategory";
            LblCategory.Size = new Size(88, 25);
            LblCategory.TabIndex = 6;
            LblCategory.Text = "Category:";
            // 
            // AddDessert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(LblCategory);
            Controls.Add(TxtCategory);
            Controls.Add(TxtPrice);
            Controls.Add(LblPrice);
            Controls.Add(BtnAddDessert);
            Controls.Add(LblName);
            Controls.Add(TxtName);
            Name = "AddDessert";
            Text = "AddDessert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtName;
        private Label LblName;
        private Button BtnAddDessert;
        private Label LblPrice;
        private TextBox TxtPrice;
        private TextBox TxtCategory;
        private Label LblCategory;
    }
}