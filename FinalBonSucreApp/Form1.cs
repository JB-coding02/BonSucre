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
            Customer cus = new Customer();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }
    }
}
