namespace FinalBonSucreApp
{
    partial class UpdateDessertForm
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
            DGVDesserts = new DataGridView();
            TxtDessertName = new TextBox();
            TxtDessertPrice = new TextBox();
            TxtDessertId = new TextBox();
            LblDessertName = new Label();
            LblDessertPrice = new Label();
            LblDessertId = new Label();
            BtnUpdateDessert = new Button();
            TxtDessertCategory = new TextBox();
            LblDessertCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVDesserts).BeginInit();
            SuspendLayout();
            // 
            // DGVDesserts
            // 
            DGVDesserts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDesserts.Location = new Point(8, 7);
            DGVDesserts.Margin = new Padding(2, 2, 2, 2);
            DGVDesserts.Name = "DGVDesserts";
            DGVDesserts.RowHeadersWidth = 62;
            DGVDesserts.Size = new Size(543, 151);
            DGVDesserts.TabIndex = 0;
            // 
            // TxtDessertName
            // 
            TxtDessertName.Location = new Point(77, 162);
            TxtDessertName.Margin = new Padding(2, 2, 2, 2);
            TxtDessertName.Name = "TxtDessertName";
            TxtDessertName.Size = new Size(106, 23);
            TxtDessertName.TabIndex = 1;
            // 
            // TxtDessertPrice
            // 
            TxtDessertPrice.Location = new Point(77, 184);
            TxtDessertPrice.Margin = new Padding(2, 2, 2, 2);
            TxtDessertPrice.Name = "TxtDessertPrice";
            TxtDessertPrice.Size = new Size(106, 23);
            TxtDessertPrice.TabIndex = 2;
            // 
            // TxtDessertId
            // 
            TxtDessertId.Location = new Point(77, 206);
            TxtDessertId.Margin = new Padding(2, 2, 2, 2);
            TxtDessertId.Name = "TxtDessertId";
            TxtDessertId.Size = new Size(106, 23);
            TxtDessertId.TabIndex = 3;
            // 
            // LblDessertName
            // 
            LblDessertName.AutoSize = true;
            LblDessertName.Location = new Point(8, 164);
            LblDessertName.Margin = new Padding(2, 0, 2, 0);
            LblDessertName.Name = "LblDessertName";
            LblDessertName.Size = new Size(39, 15);
            LblDessertName.TabIndex = 4;
            LblDessertName.Text = "Name";
            // 
            // LblDessertPrice
            // 
            LblDessertPrice.AutoSize = true;
            LblDessertPrice.Location = new Point(15, 186);
            LblDessertPrice.Margin = new Padding(2, 0, 2, 0);
            LblDessertPrice.Name = "LblDessertPrice";
            LblDessertPrice.Size = new Size(33, 15);
            LblDessertPrice.TabIndex = 5;
            LblDessertPrice.Text = "Price";
            // 
            // LblDessertId
            // 
            LblDessertId.AutoSize = true;
            LblDessertId.Location = new Point(30, 208);
            LblDessertId.Margin = new Padding(2, 0, 2, 0);
            LblDessertId.Name = "LblDessertId";
            LblDessertId.Size = new Size(17, 15);
            LblDessertId.TabIndex = 6;
            LblDessertId.Text = "Id";
            // 
            // BtnUpdateDessert
            // 
            BtnUpdateDessert.Location = new Point(186, 164);
            BtnUpdateDessert.Margin = new Padding(2, 2, 2, 2);
            BtnUpdateDessert.Name = "BtnUpdateDessert";
            BtnUpdateDessert.Size = new Size(78, 59);
            BtnUpdateDessert.TabIndex = 7;
            BtnUpdateDessert.Text = "Update";
            BtnUpdateDessert.UseVisualStyleBackColor = true;
            BtnUpdateDessert.Click += BtnUpdateDessert_Click;
            // 
            // TxtDessertCategory
            // 
            TxtDessertCategory.Location = new Point(77, 229);
            TxtDessertCategory.Margin = new Padding(2, 2, 2, 2);
            TxtDessertCategory.Name = "TxtDessertCategory";
            TxtDessertCategory.Size = new Size(106, 23);
            TxtDessertCategory.TabIndex = 8;
            // 
            // LblDessertCategory
            // 
            LblDessertCategory.AutoSize = true;
            LblDessertCategory.Location = new Point(8, 230);
            LblDessertCategory.Margin = new Padding(2, 0, 2, 0);
            LblDessertCategory.Name = "LblDessertCategory";
            LblDessertCategory.Size = new Size(55, 15);
            LblDessertCategory.TabIndex = 9;
            LblDessertCategory.Text = "Category";
            // 
            // UpdateDessertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(LblDessertCategory);
            Controls.Add(TxtDessertCategory);
            Controls.Add(BtnUpdateDessert);
            Controls.Add(LblDessertId);
            Controls.Add(LblDessertPrice);
            Controls.Add(LblDessertName);
            Controls.Add(TxtDessertId);
            Controls.Add(TxtDessertPrice);
            Controls.Add(TxtDessertName);
            Controls.Add(DGVDesserts);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UpdateDessertForm";
            Text = "Update Dessert";
            Load += UpdateDessert_Load;
            ((System.ComponentModel.ISupportInitialize)DGVDesserts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVDesserts;
        private TextBox TxtDessertName;
        private TextBox TxtDessertPrice;
        private TextBox TxtDessertId;
        private Label LblDessertName;
        private Label LblDessertPrice;
        private Label LblDessertId;
        private Button BtnUpdateDessert;
        private TextBox TxtDessertCategory;
        private Label LblDessertCategory;
    }
}