using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalBonSucreApp
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtDateOfBirth.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            Customer newCustomer = new Customer
            {
                Name = TxtName.Text,
                Email = TxtEmail.Text,
                DateOfBirth = DateTime.Parse(TxtDateOfBirth.Text)
            };
            CustomerDb.AddCustomer(newCustomer);
            MessageBox.Show($"Customer {newCustomer.Name} added successfully!");
        }
    }
}
