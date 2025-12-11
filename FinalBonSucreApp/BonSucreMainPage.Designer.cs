namespace FinalBonSucreApp
{
    partial class BonSucreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAddCustomer = new Button();
            CBoxCustomer = new ComboBox();
            CBoxDessert = new ComboBox();
            GBoxAddReview = new GroupBox();
            BtnShowAllReviews = new Button();
            BtnAddReview = new Button();
            LblReviewScore = new Label();
            LblDessertName = new Label();
            LblCustomerName = new Label();
            TxtReviewScore = new TextBox();
            BtnAddDessert = new Button();
            BtnDeleteCustomer = new Button();
            BtnDeleteDessert = new Button();
            BtnUpdateDessert = new Button();
            BtnUpdateCustomer = new Button();
            GBoxAddReview.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAddCustomer
            // 
            BtnAddCustomer.Location = new Point(362, 27);
            BtnAddCustomer.Margin = new Padding(2, 2, 2, 2);
            BtnAddCustomer.Name = "BtnAddCustomer";
            BtnAddCustomer.Size = new Size(118, 34);
            BtnAddCustomer.TabIndex = 0;
            BtnAddCustomer.Text = "Add a Customer";
            BtnAddCustomer.UseVisualStyleBackColor = true;
            BtnAddCustomer.Click += BtnAddCustomer_Click;
            // 
            // CBoxCustomer
            // 
            CBoxCustomer.FormattingEnabled = true;
            CBoxCustomer.Location = new Point(89, 17);
            CBoxCustomer.Margin = new Padding(2, 2, 2, 2);
            CBoxCustomer.Name = "CBoxCustomer";
            CBoxCustomer.Size = new Size(129, 23);
            CBoxCustomer.TabIndex = 1;
            // 
            // CBoxDessert
            // 
            CBoxDessert.FormattingEnabled = true;
            CBoxDessert.Location = new Point(89, 48);
            CBoxDessert.Margin = new Padding(2, 2, 2, 2);
            CBoxDessert.Name = "CBoxDessert";
            CBoxDessert.Size = new Size(129, 23);
            CBoxDessert.TabIndex = 2;
            // 
            // GBoxAddReview
            // 
            GBoxAddReview.Controls.Add(BtnShowAllReviews);
            GBoxAddReview.Controls.Add(BtnAddReview);
            GBoxAddReview.Controls.Add(LblReviewScore);
            GBoxAddReview.Controls.Add(LblDessertName);
            GBoxAddReview.Controls.Add(LblCustomerName);
            GBoxAddReview.Controls.Add(TxtReviewScore);
            GBoxAddReview.Controls.Add(CBoxCustomer);
            GBoxAddReview.Controls.Add(CBoxDessert);
            GBoxAddReview.Location = new Point(8, 7);
            GBoxAddReview.Margin = new Padding(2, 2, 2, 2);
            GBoxAddReview.Name = "GBoxAddReview";
            GBoxAddReview.Padding = new Padding(2, 2, 2, 2);
            GBoxAddReview.Size = new Size(318, 174);
            GBoxAddReview.TabIndex = 3;
            GBoxAddReview.TabStop = false;
            GBoxAddReview.Text = "Add Review";
            // 
            // BtnShowAllReviews
            // 
            BtnShowAllReviews.Location = new Point(65, 145);
            BtnShowAllReviews.Margin = new Padding(2, 2, 2, 2);
            BtnShowAllReviews.Name = "BtnShowAllReviews";
            BtnShowAllReviews.Size = new Size(113, 20);
            BtnShowAllReviews.TabIndex = 8;
            BtnShowAllReviews.Text = "Show all Reviews";
            BtnShowAllReviews.UseVisualStyleBackColor = true;
            BtnShowAllReviews.Click += BtnShowAllReviews_Click;
            // 
            // BtnAddReview
            // 
            BtnAddReview.Location = new Point(65, 119);
            BtnAddReview.Margin = new Padding(2, 2, 2, 2);
            BtnAddReview.Name = "BtnAddReview";
            BtnAddReview.Size = new Size(113, 20);
            BtnAddReview.TabIndex = 7;
            BtnAddReview.Text = "Add Review";
            BtnAddReview.UseVisualStyleBackColor = true;
            BtnAddReview.Click += BtnAddReview_Click;
            // 
            // LblReviewScore
            // 
            LblReviewScore.AutoSize = true;
            LblReviewScore.Location = new Point(8, 86);
            LblReviewScore.Margin = new Padding(2, 0, 2, 0);
            LblReviewScore.Name = "LblReviewScore";
            LblReviewScore.Size = new Size(76, 15);
            LblReviewScore.TabIndex = 6;
            LblReviewScore.Text = "Review Score";
            // 
            // LblDessertName
            // 
            LblDessertName.AutoSize = true;
            LblDessertName.Location = new Point(8, 50);
            LblDessertName.Margin = new Padding(2, 0, 2, 0);
            LblDessertName.Name = "LblDessertName";
            LblDessertName.Size = new Size(45, 15);
            LblDessertName.TabIndex = 5;
            LblDessertName.Text = "Dessert";
            // 
            // LblCustomerName
            // 
            LblCustomerName.AutoSize = true;
            LblCustomerName.Location = new Point(8, 20);
            LblCustomerName.Margin = new Padding(2, 0, 2, 0);
            LblCustomerName.Name = "LblCustomerName";
            LblCustomerName.Size = new Size(59, 15);
            LblCustomerName.TabIndex = 4;
            LblCustomerName.Text = "Customer";
            // 
            // TxtReviewScore
            // 
            TxtReviewScore.Location = new Point(89, 84);
            TxtReviewScore.Margin = new Padding(2, 2, 2, 2);
            TxtReviewScore.Name = "TxtReviewScore";
            TxtReviewScore.PlaceholderText = "1 - 5";
            TxtReviewScore.Size = new Size(129, 23);
            TxtReviewScore.TabIndex = 3;
            // 
            // BtnAddDessert
            // 
            BtnAddDessert.Location = new Point(362, 101);
            BtnAddDessert.Margin = new Padding(2, 2, 2, 2);
            BtnAddDessert.Name = "BtnAddDessert";
            BtnAddDessert.Size = new Size(118, 34);
            BtnAddDessert.TabIndex = 4;
            BtnAddDessert.Text = "Add a Dessert";
            BtnAddDessert.UseVisualStyleBackColor = true;
            BtnAddDessert.Click += BtnAddDessert_Click;
            // 
            // BtnDeleteCustomer
            // 
            BtnDeleteCustomer.Location = new Point(362, 64);
            BtnDeleteCustomer.Margin = new Padding(2, 2, 2, 2);
            BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            BtnDeleteCustomer.Size = new Size(118, 34);
            BtnDeleteCustomer.TabIndex = 5;
            BtnDeleteCustomer.Text = "Delete a Customer";
            BtnDeleteCustomer.UseVisualStyleBackColor = true;
            BtnDeleteCustomer.Click += BtnDeleteCustomer_Click;
            // 
            // BtnDeleteDessert
            // 
            BtnDeleteDessert.Location = new Point(362, 139);
            BtnDeleteDessert.Margin = new Padding(2, 2, 2, 2);
            BtnDeleteDessert.Name = "BtnDeleteDessert";
            BtnDeleteDessert.Size = new Size(118, 34);
            BtnDeleteDessert.TabIndex = 6;
            BtnDeleteDessert.Text = "Delete a Dessert";
            BtnDeleteDessert.UseVisualStyleBackColor = true;
            BtnDeleteDessert.Click += BtnDeleteDessert_Click;
            // 
            // BtnUpdateDessert
            // 
            BtnUpdateDessert.Location = new Point(8, 185);
            BtnUpdateDessert.Margin = new Padding(2, 2, 2, 2);
            BtnUpdateDessert.Name = "BtnUpdateDessert";
            BtnUpdateDessert.Size = new Size(78, 43);
            BtnUpdateDessert.TabIndex = 7;
            BtnUpdateDessert.Text = "Update Dessert";
            BtnUpdateDessert.UseVisualStyleBackColor = true;
            BtnUpdateDessert.Click += BtnUpdateDessert_Click;
            // 
            // BtnUpdateCustomer
            // 
            BtnUpdateCustomer.Location = new Point(97, 185);
            BtnUpdateCustomer.Margin = new Padding(2, 2, 2, 2);
            BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            BtnUpdateCustomer.Size = new Size(78, 43);
            BtnUpdateCustomer.TabIndex = 8;
            BtnUpdateCustomer.Text = "Update Customer";
            BtnUpdateCustomer.UseVisualStyleBackColor = true;
            BtnUpdateCustomer.Click += BtnUpdateCustomer_Click;
            // 
            // BonSucreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(BtnUpdateCustomer);
            Controls.Add(BtnUpdateDessert);
            Controls.Add(BtnDeleteDessert);
            Controls.Add(BtnDeleteCustomer);
            Controls.Add(BtnAddDessert);
            Controls.Add(GBoxAddReview);
            Controls.Add(BtnAddCustomer);
            Margin = new Padding(2, 2, 2, 2);
            Name = "BonSucreForm";
            Text = "Bon Sucre";
            Load += BonSucreForm_Load;
            GBoxAddReview.ResumeLayout(false);
            GBoxAddReview.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAddCustomer;
        private ComboBox CBoxCustomer;
        private ComboBox CBoxDessert;
        private GroupBox GBoxAddReview;
        private TextBox TxtReviewScore;
        private Label LblReviewScore;
        private Label LblDessertName;
        private Label LblCustomerName;
        private Button BtnAddReview;
        private Button BtnAddDessert;
        private Button BtnDeleteCustomer;
        private Button BtnDeleteDessert;
        private Button BtnShowAllReviews;
        private Button BtnUpdateDessert;
        private Button BtnUpdateCustomer;
    }
}
