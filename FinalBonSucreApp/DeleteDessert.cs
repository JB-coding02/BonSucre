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
    public partial class DeleteDessertForm : Form
    {
        public DeleteDessertForm()
        {
            InitializeComponent();
        }

        private void BtnDeleteDessert_Click(object sender, EventArgs e)
        {
            if (DGVDessert.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a dessert to delete.");
                return;
            }
            int dessertId = Convert.ToInt32(DGVDessert.SelectedRows[0].Cells["DessertId"].Value);
            DessertDb.DeleteDessert(dessertId);
            MessageBox.Show("Dessert deleted successfully.");
            LoadDessertsIntoGrid();
        }

        private void DeleteDessert_Load(object sender, EventArgs e)
        {
            LoadDessertsIntoGrid();
        }

        private void LoadDessertsIntoGrid()
        {
            try
            {
                string query = """
                SELECT Name AS DessertName
                FROM Desserts
                ORDER BY Name ASC
                """;
                using SqlConnection con = DessertDb.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, con);
                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                DGVDessert.DataSource = table;

                // Optional: format columns
                if (DGVDessert.Columns.Contains("DessertId"))
                    DGVDessert.Columns["DessertId"]?.DefaultCellStyle.Format = "C2";

                // Make grid read-only and adjust sizing
                DGVDessert.ReadOnly = true;
                DGVDessert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVDessert.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Customers: {ex.Message}");
            }
        }
    }
}
