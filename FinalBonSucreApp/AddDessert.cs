using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalBonSucreApp
{
    public partial class AddDessertForm : Form
    {
        public AddDessertForm()
        {
            InitializeComponent();
        }

        private void BtnAddDessert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) ||
                string.IsNullOrWhiteSpace(TxtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!decimal.TryParse(TxtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive number for Price.");
                return;
            }
            if (!TxtNewCategory.Text.IsNullOrEmpty())
            {
                Dessert dessert = new Dessert
                {
                    Name = TxtName.Text,
                    Price = Convert.ToDouble(TxtPrice.Text),
                    Category = Convert.ToString(TxtNewCategory.Text)
                };
                DessertDb.AddDessert(dessert);
                MessageBox.Show($"Successfully created {dessert.Category} and {dessert.Name} was also added successfully");
            }
            else
            {
                Dessert dessert = new Dessert
                {
                    Name = TxtName.Text,
                    Price = Convert.ToDouble(TxtPrice.Text),
                    Category = Convert.ToString(CBoxCategory.SelectedItem)
                };
                DessertDb.AddDessert(dessert);
                MessageBox.Show($"{dessert.Name} was successfully added to {dessert.Category}");
            }
            Close();
        }

    }
}
