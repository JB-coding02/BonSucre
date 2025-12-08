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
    public partial class UpdateCustomerForm : Form
    {
        public UpdateCustomerForm()
        {
            InitializeComponent();
            this.Load += UpdateCustomer_Load;
        }

        private void UpdateCustomer_Load(object? sender, EventArgs e)
        {
            LoadCustomersIntoGrid();

            // Ensure we don't double-subscribe
            DGVCustomers.SelectionChanged -= DGVCustomers_SelectionChanged;
            DGVCustomers.SelectionChanged += DGVCustomers_SelectionChanged;

            // Populate text boxes for the initial selection (if any)
            UpdateTxtBoxes();
        }

        private void DGVCustomers_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateTxtBoxes();
        }

        private void UpdateTxtBoxes()
        {
            // Guard: no current row or no data bound item
            if (DGVCustomers.CurrentRow == null)
                return;

            DataRowView? rowView = DGVCustomers.CurrentRow.DataBoundItem as DataRowView;
            if (rowView == null)
                return;

            // Extract values from the selected DataRowView using the column names used in the query.
            string customerName = Convert.ToString(rowView["CustomerName"]);

            // If your form contains a TextBox named "TxtName", set its Text.
            // This uses Controls["controlName"] so it is safe even if the control isn't present.
            if (this.Controls.ContainsKey("TxtName") && this.Controls["TxtName"] is TextBox txtName)
            {
                txtName.Text = customerName;
            }

            // Example: if you also selected CustomerId in the query and have a TextBox named "TxtCustomerId".
            if (rowView.Row.Table.Columns.Contains("CustomerId") &&
                this.Controls.ContainsKey("TxtCustomerId") &&
                this.Controls["TxtCustomerId"] is TextBox txtCustomerId)
            {
                txtCustomerId.Text = Convert.ToString(rowView["CustomerId"]) ?? string.Empty;
            }
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

                DGVCustomers.DataSource = table;

                // Optional: format columns
                if (DGVCustomers.Columns.Contains("CustomerId"))
                    DGVCustomers.Columns["CustomerId"]?.DefaultCellStyle.Format = "C2";

                // Make grid read-only and adjust sizing
                DGVCustomers.ReadOnly = true;
                DGVCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Customers: {ex.Message}");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CustomerDb.UpdateCustomer(
                DGVCustomers.CurrentRow?.Cells["CustomerId"].Value as int? ?? 0,
                TxtCustomerName.Text,
                TxtCustomerEmail.Text,
                Convert.ToDateTime(TxtCustomerDateOfBirth.Text)
            );
        }
    }
}
