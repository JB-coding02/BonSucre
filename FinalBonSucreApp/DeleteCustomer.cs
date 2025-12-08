using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalBonSucreApp
{
    public partial class DeleteCustomerForm : Form
    {
        public DeleteCustomerForm()
        {
            InitializeComponent();
        }

        private void LoadCustomersIntoGrid()
        {
            try
            {
                string query = """
                SELECT Name AS CustomerName
                FROM Customers
                ORDER BY Name ASC
                """;
                using SqlConnection con = CustomerDb.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, con);
                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                DGVCustomer.DataSource = table;

                // Optional: format columns
                if (DGVCustomer.Columns.Contains("CustomerId"))
                    DGVCustomer.Columns["CustomerId"]?.DefaultCellStyle.Format = "C2";

                // Make grid read-only and adjust sizing
                DGVCustomer.ReadOnly = true;
                DGVCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Customers: {ex.Message}");
            }
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomersIntoGrid();
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (DGVCustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }
            string customerName = DGVCustomer.SelectedRows[0].Cells["CustomerName"].Value.ToString();
            try
            {
                CustomerDb.DeleteCustomerByName(customerName);
                MessageBox.Show($"Customer '{customerName}' deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}");
            }
            LoadCustomersIntoGrid();
        }
    }
}
