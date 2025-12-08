namespace FinalBonSucreApp
{
    partial class DeleteDessertForm
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
            DGVDessert = new DataGridView();
            BtnDeleteDessert = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVDessert).BeginInit();
            SuspendLayout();
            // 
            // DGVDessert
            // 
            DGVDessert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDessert.Location = new Point(12, 12);
            DGVDessert.Name = "DGVDessert";
            DGVDessert.RowHeadersWidth = 62;
            DGVDessert.Size = new Size(303, 244);
            DGVDessert.TabIndex = 0;
            // 
            // BtnDeleteDessert
            // 
            BtnDeleteDessert.Location = new Point(12, 262);
            BtnDeleteDessert.Name = "BtnDeleteDessert";
            BtnDeleteDessert.Size = new Size(303, 34);
            BtnDeleteDessert.TabIndex = 1;
            BtnDeleteDessert.Text = "Delete Dessert";
            BtnDeleteDessert.UseVisualStyleBackColor = true;
            BtnDeleteDessert.Click += BtnDeleteDessert_Click;
            // 
            // DeleteDessertForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 307);
            Controls.Add(BtnDeleteDessert);
            Controls.Add(DGVDessert);
            Name = "DeleteDessertForm";
            Text = "Delete Dessert";
            Load += DeleteDessert_Load;
            ((System.ComponentModel.ISupportInitialize)DGVDessert).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVDessert;
        private Button BtnDeleteDessert;
    }
}