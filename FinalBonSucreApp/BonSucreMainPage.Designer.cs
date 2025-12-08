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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtReviewScore = new TextBox();
            BtnAddReview = new Button();
            GBoxAddReview.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAddCustomer
            // 
            BtnAddCustomer.Location = new Point(521, 61);
            BtnAddCustomer.Name = "BtnAddCustomer";
            BtnAddCustomer.Size = new Size(168, 90);
            BtnAddCustomer.TabIndex = 0;
            BtnAddCustomer.Text = "Add Customer";
            BtnAddCustomer.UseVisualStyleBackColor = true;
            BtnAddCustomer.Click += BtnAddCustomer_Click;
            // 
            // comboBox1
            // 
            CBoxCustomer.FormattingEnabled = true;
            CBoxCustomer.Location = new Point(230, 30);
            CBoxCustomer.Name = "comboBox1";
            CBoxCustomer.Size = new Size(182, 33);
            CBoxCustomer.TabIndex = 1;
            // 
            // comboBox2
            // 
            CBoxDessert.FormattingEnabled = true;
            CBoxDessert.Location = new Point(230, 81);
            CBoxDessert.Name = "comboBox2";
            CBoxDessert.Size = new Size(182, 33);
            CBoxDessert.TabIndex = 2;
            // 
            // GBoxAddReview
            // 
            GBoxAddReview.Controls.Add(BtnAddReview);
            GBoxAddReview.Controls.Add(label3);
            GBoxAddReview.Controls.Add(label2);
            GBoxAddReview.Controls.Add(label1);
            GBoxAddReview.Controls.Add(TxtReviewScore);
            GBoxAddReview.Controls.Add(CBoxCustomer);
            GBoxAddReview.Controls.Add(CBoxDessert);
            GBoxAddReview.Location = new Point(12, 12);
            GBoxAddReview.Name = "GBoxAddReview";
            GBoxAddReview.Size = new Size(455, 290);
            GBoxAddReview.TabIndex = 3;
            GBoxAddReview.TabStop = false;
            GBoxAddReview.Text = "Add Review";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 6;
            label3.Text = "Review Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 5;
            label2.Text = "Dessert";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 4;
            label1.Text = "Customer";
            // 
            // TxtReviewScore
            // 
            TxtReviewScore.Location = new Point(230, 141);
            TxtReviewScore.Name = "TxtReviewScore";
            TxtReviewScore.PlaceholderText = "1 - 5";
            TxtReviewScore.Size = new Size(182, 31);
            TxtReviewScore.TabIndex = 3;
            // 
            // BtnAddReview
            // 
            BtnAddReview.Location = new Point(93, 198);
            BtnAddReview.Name = "BtnAddReview";
            BtnAddReview.Size = new Size(161, 34);
            BtnAddReview.TabIndex = 7;
            BtnAddReview.Text = "Add Review";
            BtnAddReview.UseVisualStyleBackColor = true;
            BtnAddReview.Click += BtnAddReview_Click;
            // 
            // BonSucreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GBoxAddReview);
            Controls.Add(BtnAddCustomer);
            Name = "BonSucreForm";
            Text = "Bon Sucre";
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
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnAddReview;
    }
}
