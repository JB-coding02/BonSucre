namespace FinalBonSucreApp
{
    public partial class BonSucreForm : Form
    {
        public BonSucreForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        private void BtnAddReview_Click(object sender, EventArgs e)
        {
            if (CBoxCustomer.SelectedItem == null 
             || CBoxDessert.SelectedItem == null 
             || string.IsNullOrWhiteSpace(TxtReviewScore.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!int.TryParse(TxtReviewScore.Text, out int score) || score < 1 || score > 5)
            {
                MessageBox.Show("Please enter a valid score between 1 and 5.");
                return;
            }
            Review newReview = new Review
            {
                CustomerId = ((Customer)CBoxCustomer.SelectedItem).CustomerID,
                DessertId = ((Dessert)CBoxDessert.SelectedItem).DessertId,
                Score = int.Parse(TxtReviewScore.Text)
            };
            ReviewDb.AddReview(newReview);
            MessageBox.Show("Review added successfully!");
        }
    }
}
