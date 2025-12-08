namespace FinalBonSucreApp
{
    public partial class BonSucreForm : Form
    {
        public BonSucreForm()
        {
            InitializeComponent();
        }

        private void ReloadAll()
        {
            ReloadCustomers();
            ReloadDesserts();
        }

        private void ReloadCustomers()
        {
            // Replace DisplayMember with the actual property your Customer uses for display.
            // If you have CustomerDb.GetAllCustomers(), use it; otherwise adapt accordingly.
            try
            {
                List<Customer> customers = CustomerDb.GetAllCustomers();
                CBoxCustomer.DataSource = null;
                CBoxCustomer.DisplayMember = "Name"; // adjust to real property (e.g., "Name")
                CBoxCustomer.ValueMember = "CustomerID";
                CBoxCustomer.DataSource = customers;
            }
            catch (Exception)
            {
                // If customer list isn't available yet, ensure the box is empty instead of null-binding.
                CBoxCustomer.DataSource = null;
            }
        }

        private void ReloadDesserts()
        {
            // Get desserts from DB and bind to ComboBox
            List<Dessert> desserts = DessertDb.GetAllDesserts();
            CBoxDessert.DataSource = null;
            CBoxDessert.DisplayMember = "Name";
            CBoxDessert.ValueMember = "DessertId";
            CBoxDessert.DataSource = desserts;
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
            addCustomerForm.FormClosed += (s, args) => ReloadCustomers();
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

        private void BtnAddDessert_Click(object sender, EventArgs e)
        {
            var addDessertForm = new AddDessertForm();
            addDessertForm.Show();
            addDessertForm.FormClosed += (s, args) => ReloadDesserts();
        }

        private void BtnShowAllReviews_Click(object sender, EventArgs e)
        {
            var showAllReviewsForm = new ReviewDisplayForm();
            showAllReviewsForm.Show();
            showAllReviewsForm.FormClosed += (s, args) => ReloadAll();
        }

        private void BtnDeleteDessert_Click(object sender, EventArgs e)
        {
            var deleteDessertForm = new DeleteDessertForm();
            deleteDessertForm.Show();
            deleteDessertForm.FormClosed += (s, args) => ReloadAll();
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var deleteCustomerForm = new DeleteCustomerForm();
            deleteCustomerForm.Show();
            deleteCustomerForm.FormClosed += (s, args) => ReloadAll();
        }

        private void BonSucreForm_Load(object sender, EventArgs e)
        {
            ReloadAll();
        }
    }
}
