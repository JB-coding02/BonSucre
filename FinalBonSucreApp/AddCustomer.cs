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
            if (!DateTime.TryParse(TxtDateOfBirth.Text, out _))
            {
                MessageBox.Show("Please enter a valid date for Date of Birth.");
                return;
            }
            if (!TxtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            if (DateTime.Parse(TxtDateOfBirth.Text) > DateTime.Now)
            {
                MessageBox.Show("Date of Birth cannot be in the future.");
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
