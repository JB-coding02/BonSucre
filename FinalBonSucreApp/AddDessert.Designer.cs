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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtName = new TextBox();
            TxtPrice = new TextBox();
            CBoxCategory = new ComboBox();
            TxtNewCategory = new TextBox();
            BtnAddDessert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 73);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(120, 27);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(150, 31);
            TxtName.TabIndex = 3;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(120, 70);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(150, 31);
            TxtPrice.TabIndex = 4;
            // 
            // CBoxCategory
            // 
            CBoxCategory.FormattingEnabled = true;
            CBoxCategory.Location = new Point(120, 113);
            CBoxCategory.Name = "CBoxCategory";
            CBoxCategory.Size = new Size(150, 33);
            CBoxCategory.TabIndex = 5;
            // 
            // TxtNewCategory
            // 
            TxtNewCategory.Location = new Point(120, 152);
            TxtNewCategory.Name = "TxtNewCategory";
            TxtNewCategory.Size = new Size(150, 31);
            TxtNewCategory.TabIndex = 6;
            // 
            // BtnAddDessert
            // 
            BtnAddDessert.Location = new Point(60, 203);
            BtnAddDessert.Name = "BtnAddDessert";
            BtnAddDessert.Size = new Size(141, 34);
            BtnAddDessert.TabIndex = 7;
            BtnAddDessert.Text = "Add Dessert";
            BtnAddDessert.UseVisualStyleBackColor = true;
            BtnAddDessert.Click += BtnAddDessert_Click;
            // 
            // AddDessertForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 263);
            Controls.Add(BtnAddDessert);
            Controls.Add(TxtNewCategory);
            Controls.Add(CBoxCategory);
            Controls.Add(TxtPrice);
            Controls.Add(TxtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddDessertForm";
            Text = "Add Dessert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtName;
        private TextBox TxtPrice;
        private ComboBox CBoxCategory;
        private TextBox TxtNewCategory;
        private Button BtnAddDessert;
    }
}