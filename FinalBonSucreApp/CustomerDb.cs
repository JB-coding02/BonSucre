using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace FinalBonSucreApp
{
    static class CustomerDb
    {
        public static SqlConnection GetConnection()
        {
            // Create and return a connection to the database
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BonSucre;Integrated Security=True;Connect Timeout=90;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }
        /// <summary>
        /// Adds a Customer to the database
        /// </summary>
        /// <param name="customer">The customer to be added</param>
        public static void AddCustomer(Customer customer)
        {
            // Establish connection to database
            SqlConnection con = GetConnection();
            
            // Prepare Insert Statement
            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = con;
            addCommand.CommandText = """
                INSERT INTO Customers (Name, Email, DateOfBirth)
                VALUES (@Name, @Email, @DateOfBirth)
                SELECT SCOPE_IDENTITY();
                """;
            addCommand.Parameters.AddWithValue("@CustomerId", customer.CustomerID);
            addCommand.Parameters.AddWithValue("@Name", customer.Name);
            addCommand.Parameters.AddWithValue("@Email", customer.Email);
            addCommand.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);

            // Open connection to the database
            con.Open();

            // Execute Insert Query
            addCommand.ExecuteNonQuery();

            // Close the connecction to the database
            con.Close();
        }

        public static List<Customer> GetAllCustomers()
        {
            // Get a database connection
            SqlConnection con = GetConnection();

            // Open connection
            con.Open();

            // Prepare SQL command
            // Raw string literal - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/raw-string
            string query = """
            SELECT CustomerId, Email, Name, DateOfBirth
            FROM Customers
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
            List<Customer> allDesserts = new();
            while (reader.Read())
            {
                Customer customer = new()
                {
                    Name = reader["Name"].ToString(),
                    CustomerID = Convert.ToInt32(reader["CustomerId"]),
                    Email = Convert.ToString(reader["Email"]),
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"])
                };

                //Make sure to add each product to the list so it gets returned.
                allDesserts.Add(customer);
            }

            // Close connection
            con.Close();

            return allDesserts;
        }

        public static void UpdateCustomer(int CustomerId, string? NewName, string? NewEmail, DateTime DateOfBirth)
        {
            // Get a database connection
            SqlConnection con = GetConnection();
            // Open connection
            con.Open();
            // Prepare SQL command
            string query = """
            UPDATE Customers
            SET Email = @NewEmail,
                Name = @NewName
            WHERE CustomerId = @CustomerId
            """;
            SqlCommand updateCommand = new()
            {
                Connection = con,
                CommandText = query
            };
            updateCommand.Parameters.AddWithValue("@NewEmail", NewEmail);
            updateCommand.Parameters.AddWithValue("@NewName", NewName);
            // Execute command on the db
            updateCommand.ExecuteNonQuery();
            // Close connection to database
            con.Close();
        }

        public static void DeleteCustomer(Customer customer)
        {
            DeleteCustomer(customer.CustomerID);
        }

        public static void DeleteCustomer(int CustomerId)
        {
            // Get a database connection
            SqlConnection con = GetConnection();
            // Open connection
            con.Open();
            // Prepare SQL command
            string query = """
            DELETE FROM Customers
            WHERE CustomerId = @CustomerId
            """;
            SqlCommand deleteCommand = new()
            {
                Connection = con,
                CommandText = query
            };
            deleteCommand.Parameters.AddWithValue("@CustomerId", CustomerId);
            // Execute command on the db
            deleteCommand.ExecuteNonQuery();
            // Close connection to database
            con.Close();
        }

        public static Customer GetCustomer(int CustomerId)
        {
            throw new NotImplementedException();
        }

        internal static void DeleteCustomerByName(string? customerName)
        {
            // Get a database connection
            SqlConnection con = GetConnection();
            // Open connection
            con.Open();
            // Prepare SQL command
            string query = """
            DELETE FROM Customers
            WHERE Name = @CustomerName
            """;
            SqlCommand deleteCommand = new()
            {
                Connection = con,
                CommandText = query
            };
            deleteCommand.Parameters.AddWithValue("@CustomerName", customerName);
            // Execute command on the db
            deleteCommand.ExecuteNonQuery();
            // Close connection to database
            con.Close();
        }
    }
}
