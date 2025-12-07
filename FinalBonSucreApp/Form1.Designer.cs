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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            TxtReviewScore = new TextBox();
            groupBox1.SuspendLayout();
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
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(77, 81);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtReviewScore);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 227);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // TxtReviewScore
            // 
            TxtReviewScore.Location = new Point(77, 141);
            TxtReviewScore.Name = "TxtReviewScore";
            TxtReviewScore.Size = new Size(182, 31);
            TxtReviewScore.TabIndex = 3;
            // 
            // BonSucreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(BtnAddCustomer);
            Name = "BonSucreForm";
            Text = "Bon Sucre";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAddCustomer;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private TextBox TxtReviewScore;
    }
}
