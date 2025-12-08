using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalBonSucreApp
{
    internal class DessertDb
    {

        public static SqlConnection GetConnection()
        {
            // Create and return a connection to the database
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BonSucre;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }
        public static void AddDessert(Dessert dessert)
        {
            // Establish connection to database
            SqlConnection con = GetConnection();

            // Prepare Insert Statement
            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = con;
            addCommand.CommandText = """
                INSERT INTO Desserts (Name, Price, Category)
                VALUES (@Name, @Price, @Category);
                SELECT SCOPE_IDENTITY();
                """;
            addCommand.Parameters.AddWithValue("@DessertId", dessert.Name);
            addCommand.Parameters.AddWithValue("@Name", dessert.Name);
            addCommand.Parameters.AddWithValue("@Price", dessert.Price);
            addCommand.Parameters.AddWithValue("@Category", dessert.Category);

            // Open connection to the database
            con.Open();

            // Execute Insert Query
            addCommand.ExecuteNonQuery();

            // Close the connection to the database
            con.Close();
        }

        public static List<Dessert> GetAllDesserts()
        {
            // Get a database connection
            SqlConnection con = GetConnection();

            // Open connection
            con.Open();

            // Prepare SQL command
            // Raw string literal - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/raw-string
            string query = """
            SELECT DessertId, Price, Name, Category
            FROM Desserts
            ORDER BY Name ASC
            """;
            SqlCommand selectCommand = new()
            {
                Connection = con,
                CommandText = query
            };

            // Execute command on the db
            SqlDataReader reader = selectCommand.ExecuteReader();

            // Store the results
            List<Dessert> allDesserts = new();
            while (reader.Read())
            {
                Dessert dessert = new()
                {
                    Name = reader["Name"].ToString(),
                    DessertId = Convert.ToInt32(reader["DessertId"]),
                    Price = Convert.ToDouble(reader["Price"]),
                    Category = Convert.ToString(reader["Category"])
                };

                //Make sure to add each product to the list so it gets returned.
                allDesserts.Add(dessert);
            }

            // Close connection
            con.Close();

            return allDesserts;
        }

        public static void UpdateDessert(string NewCategory, double NewPrice, int DessertId, string? NewName)
        {
            // Get a database connection
            SqlConnection con = GetConnection();
            // Open connection
            con.Open();
            // Prepare SQL command
            string query = """
            UPDATE Desserts
            SET Price = @NewPrice,
                Name = @NewName, 
                Category = @NewCategory
            WHERE DessertId = @DessertId
            """;
            SqlCommand updateCommand = new()
            {
                Connection = con,
                CommandText = query
            };
            updateCommand.Parameters.AddWithValue("@NewPrice", NewPrice);
            updateCommand.Parameters.AddWithValue("@DessertId", DessertId);
            updateCommand.Parameters.AddWithValue("@NewName", NewName);
            updateCommand.Parameters.AddWithValue("@NewCategory", NewCategory);
            // Execute command on the db
            updateCommand.ExecuteNonQuery();
            // Close connection to database
            con.Close();
        }

        public static void DeleteDessert(Dessert dessert)
        {
            DeleteDessert(dessert.DessertId);
        }

        public static void DeleteDessert(int DessertId)
        {
            // Get a database connection
            SqlConnection con = GetConnection();
            // Open connection
            con.Open();
            // Prepare SQL command
            string query = """
            DELETE FROM Desserts
            WHERE DessertId = @DessertId
            """;
            SqlCommand deleteCommand = new()
            {
                Connection = con,
                CommandText = query
            };
            deleteCommand.Parameters.AddWithValue("@DessertId", DessertId);
            // Execute command on the db
            deleteCommand.ExecuteNonQuery();
            // Close connection to database
            con.Close();
        }

        public static Dessert GetDessert(int dessertId)
        {
            throw new NotImplementedException();
        }
    }
}
