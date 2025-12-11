namespace FinalBonSucreApp
{
    partial class AddDessertForm
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
            LblDessertName = new Label();
            LblDessertPrice = new Label();
            LblDessertCategory = new Label();
            TxtName = new TextBox();
            TxtPrice = new TextBox();
            CBoxCategory = new ComboBox();
            TxtNewCategory = new TextBox();
            BtnAddDessert = new Button();
            SuspendLayout();
            // 
            // LblDessertName
            // 
            LblDessertName.AutoSize = true;
            LblDessertName.Location = new Point(27, 18);
            LblDessertName.Margin = new Padding(2, 0, 2, 0);
            LblDessertName.Name = "LblDessertName";
            LblDessertName.Size = new Size(39, 15);
            LblDessertName.TabIndex = 0;
            LblDessertName.Text = "Name";
            // 
            // LblDessertPrice
            // 
            LblDessertPrice.AutoSize = true;
            LblDessertPrice.Location = new Point(33, 44);
            LblDessertPrice.Margin = new Padding(2, 0, 2, 0);
            LblDessertPrice.Name = "LblDessertPrice";
            LblDessertPrice.Size = new Size(33, 15);
            LblDessertPrice.TabIndex = 1;
            LblDessertPrice.Text = "Price";
            // 
            // LblDessertCategory
            // 
            LblDessertCategory.AutoSize = true;
            LblDessertCategory.Location = new Point(11, 70);
            LblDessertCategory.Margin = new Padding(2, 0, 2, 0);
            LblDessertCategory.Name = "LblDessertCategory";
            LblDessertCategory.Size = new Size(55, 15);
            LblDessertCategory.TabIndex = 2;
            LblDessertCategory.Text = "Category";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(84, 16);
            TxtName.Margin = new Padding(2, 2, 2, 2);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(106, 23);
            TxtName.TabIndex = 3;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(84, 42);
            TxtPrice.Margin = new Padding(2, 2, 2, 2);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(106, 23);
            TxtPrice.TabIndex = 4;
            // 
            // CBoxCategory
            // 
            CBoxCategory.FormattingEnabled = true;
            CBoxCategory.Location = new Point(84, 68);
            CBoxCategory.Margin = new Padding(2, 2, 2, 2);
            CBoxCategory.Name = "CBoxCategory";
            CBoxCategory.Size = new Size(106, 23);
            CBoxCategory.TabIndex = 5;
            // 
            // TxtNewCategory
            // 
            TxtNewCategory.Location = new Point(84, 91);
            TxtNewCategory.Margin = new Padding(2, 2, 2, 2);
            TxtNewCategory.Name = "TxtNewCategory";
            TxtNewCategory.Size = new Size(106, 23);
            TxtNewCategory.TabIndex = 6;
            // 
            // BtnAddDessert
            // 
            BtnAddDessert.Location = new Point(42, 122);
            BtnAddDessert.Margin = new Padding(2, 2, 2, 2);
            BtnAddDessert.Name = "BtnAddDessert";
            BtnAddDessert.Size = new Size(99, 20);
            BtnAddDessert.TabIndex = 7;
            BtnAddDessert.Text = "Add Dessert";
            BtnAddDessert.UseVisualStyleBackColor = true;
            BtnAddDessert.Click += BtnAddDessert_Click;
            // 
            // AddDessertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 158);
            Controls.Add(BtnAddDessert);
            Controls.Add(TxtNewCategory);
            Controls.Add(CBoxCategory);
            Controls.Add(TxtPrice);
            Controls.Add(TxtName);
            Controls.Add(LblDessertCategory);
            Controls.Add(LblDessertPrice);
            Controls.Add(LblDessertName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddDessertForm";
            Text = "Add Dessert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblDessertName;
        private Label LblDessertPrice;
        private Label LblDessertCategory;
        private TextBox TxtName;
        private TextBox TxtPrice;
        private ComboBox CBoxCategory;
        private TextBox TxtNewCategory;
        private Button BtnAddDessert;
    }
}