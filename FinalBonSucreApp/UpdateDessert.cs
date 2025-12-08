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
    public partial class UpdateDessertForm : Form
    {
        public UpdateDessertForm()
        {
            InitializeComponent();
            this.Load += UpdateDessert_Load;
        }

        private void UpdateDessert_Load(object? sender, EventArgs e)
        {
            LoadDessertsIntoGrid();
            // Ensure we don't double-subscribe
            DGVDesserts.SelectionChanged -= DGVDesserts_SelectionChanged;
            DGVDesserts.SelectionChanged += DGVDesserts_SelectionChanged;

            // Populate text boxes for the initial selection (if any)
            UpdateTxtBoxes();
        }

        private void DGVDesserts_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateTxtBoxes();
        }

        private void UpdateTxtBoxes()
        {
            // Guard: no current row or no data bound item
            if (DGVDesserts?.CurrentRow == null)
                return;

            DataRowView? rowView = DGVDesserts?.CurrentRow?.DataBoundItem as DataRowView;
            if (rowView == null)
                return;

            // Extract values from the selected DataRowView using the column names used in the query.
            string customerName = Convert.ToString(rowView["CustomerName"]) ?? string.Empty;

            // If your form contains a TextBox named "TxtName", set its Text.
            // This uses Controls["controlName"] so it is safe even if the control isn't present.
            if (this.Controls.ContainsKey("TxtName") && this.Controls["TxtName"] is TextBox txtName)
            {
                txtName.Text = customerName;
            }

            // Example: if you also selected DessertId in the query and have a TextBox named "TxtDessertId".
            if (rowView.Row.Table.Columns.Contains("DessertId") &&
                this.Controls.ContainsKey("TxtDessertId") &&
                this.Controls["TxtDessertId"] is TextBox txtCustomerId)
            {
                txtCustomerId.Text = Convert.ToString(rowView["CustomerId"]) ?? string.Empty;
            }
        }

        private void LoadDessertsIntoGrid()
        {
            try
            {
                string query = """
                SELECT DessertId, Name, Price, Category
                FROM Desserts
                ORDER BY Name ASC
                """;
                using SqlConnection con = DessertDb.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, con);
                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DGVDesserts.DataSource = table;
                // Optional: format columns
                if (DGVDesserts.Columns.Contains("Price"))
                    DGVDesserts.Columns["Price"]?.DefaultCellStyle.Format = "C2";
                // Make grid read-only and adjust sizing
                DGVDesserts.ReadOnly = true;
                DGVDesserts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVDesserts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Desserts: {ex.Message}");
            }
        }

        private void BtnUpdateDessert_Click(object sender, EventArgs e)
        {
            DessertDb.UpdateDessert(
                NewCategory: TxtDessertCategory.Text,
                NewPrice: Convert.ToDouble(TxtDessertPrice.Text),
                DessertId: Convert.ToInt32(TxtDessertId.Text),
                NewName: TxtDessertName.Text
            );
        }
    }
}
