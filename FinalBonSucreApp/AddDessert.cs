using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalBonSucreApp
{
    public partial class AddDessert : Form
    {
        public AddDessert()
        {
            InitializeComponent();
        }

        private void BtnAddDessert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) ||
                string.IsNullOrWhiteSpace(TxtPrice.Text) ||
                string.IsNullOrWhiteSpace(TxtCategory.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!decimal.TryParse(TxtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }
            if (!int.TryParse(TxtCategory.Text, out int category) || category < 0 || category > 5)
            {
                MessageBox.Show("Please enter a valid category.");
                return;
            }
            Dessert newDessert = new Dessert
            {
                Name = TxtName.Text,
                Price = Convert.ToDouble(TxtPrice.Text),
                Category = Convert.ToInt32(TxtCategory.Text)
            };
            DessertDb.AddDessert(newDessert);
            MessageBox.Show($"Dessert {newDessert.Name} added successfully!");
        }
    }
}
