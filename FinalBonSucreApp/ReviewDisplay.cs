using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FinalBonSucreApp
{
    public partial class ReviewDisplayForm : Form
    {
        public ReviewDisplayForm()
        {
            InitializeComponent();
        }

        private void ReviewDisplay_Load(object sender, EventArgs e)
        {
            LoadReviewsIntoGrid();
        }

        private void LoadReviewsIntoGrid()
        {
            try
            {
                string query = """
                SELECT r.ReviewId,
                c.Name AS CustomerName,
                d.Name AS DessertName,
                d.Price,
                r.Score
                FROM Reviews r
                JOIN Customers c ON r.CustomerId = c.CustomerId
                JOIN Desserts d ON r.DessertId = d.DessertId
                ORDER BY r.ReviewId ASC
                """;
                using SqlConnection con = ReviewDb.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, con);
                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                // Optional: format columns
                if (dataGridView1.Columns.Contains("Price"))
                    dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C2";

                // Make grid read-only and adjust sizing
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reviews: {ex.Message}");
            }
        }
    }
}
