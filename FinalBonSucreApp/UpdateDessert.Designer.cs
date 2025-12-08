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
            DGVDesserts.Location = new Point(12, 12);
            DGVDesserts.Name = "DGVDesserts";
            DGVDesserts.RowHeadersWidth = 62;
            DGVDesserts.Size = new Size(776, 225);
            DGVDesserts.TabIndex = 0;
            // 
            // TxtDessertName
            // 
            TxtDessertName.Location = new Point(110, 270);
            TxtDessertName.Name = "TxtDessertName";
            TxtDessertName.Size = new Size(150, 31);
            TxtDessertName.TabIndex = 1;
            // 
            // TxtDessertPrice
            // 
            TxtDessertPrice.Location = new Point(110, 307);
            TxtDessertPrice.Name = "TxtDessertPrice";
            TxtDessertPrice.Size = new Size(150, 31);
            TxtDessertPrice.TabIndex = 2;
            // 
            // TxtDessertId
            // 
            TxtDessertId.Location = new Point(110, 344);
            TxtDessertId.Name = "TxtDessertId";
            TxtDessertId.Size = new Size(150, 31);
            TxtDessertId.TabIndex = 3;
            // 
            // LblDessertName
            // 
            LblDessertName.AutoSize = true;
            LblDessertName.Location = new Point(12, 273);
            LblDessertName.Name = "LblDessertName";
            LblDessertName.Size = new Size(59, 25);
            LblDessertName.TabIndex = 4;
            LblDessertName.Text = "Name";
            // 
            // LblDessertPrice
            // 
            LblDessertPrice.AutoSize = true;
            LblDessertPrice.Location = new Point(22, 310);
            LblDessertPrice.Name = "LblDessertPrice";
            LblDessertPrice.Size = new Size(49, 25);
            LblDessertPrice.TabIndex = 5;
            LblDessertPrice.Text = "Price";
            // 
            // LblDessertId
            // 
            LblDessertId.AutoSize = true;
            LblDessertId.Location = new Point(43, 347);
            LblDessertId.Name = "LblDessertId";
            LblDessertId.Size = new Size(28, 25);
            LblDessertId.TabIndex = 6;
            LblDessertId.Text = "Id";
            // 
            // BtnUpdateDessert
            // 
            BtnUpdateDessert.Location = new Point(266, 273);
            BtnUpdateDessert.Name = "BtnUpdateDessert";
            BtnUpdateDessert.Size = new Size(112, 99);
            BtnUpdateDessert.TabIndex = 7;
            BtnUpdateDessert.Text = "Update";
            BtnUpdateDessert.UseVisualStyleBackColor = true;
            BtnUpdateDessert.Click += BtnUpdateDessert_Click;
            // 
            // TxtDessertCategory
            // 
            TxtDessertCategory.Location = new Point(110, 381);
            TxtDessertCategory.Name = "TxtDessertCategory";
            TxtDessertCategory.Size = new Size(150, 31);
            TxtDessertCategory.TabIndex = 8;
            // 
            // LblDessertCategory
            // 
            LblDessertCategory.AutoSize = true;
            LblDessertCategory.Location = new Point(12, 384);
            LblDessertCategory.Name = "LblDessertCategory";
            LblDessertCategory.Size = new Size(84, 25);
            LblDessertCategory.TabIndex = 9;
            LblDessertCategory.Text = "Category";
            // 
            // UpdateDessertForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "UpdateDessertForm";
            Text = "UpdateDessert";
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