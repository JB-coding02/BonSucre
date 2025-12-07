using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace FinalBonSucreApp
{
    static class CustomerDb
    {
        /// <summary>
        /// Adds a Customer to the database
        /// </summary>
        /// <param name="customer">The customer to be added</param>
        public static void AddCustomer(Customer customer)
        {
            // Establish connection to database
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BonSucre;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30")

            // Prepare Insert Statement
            SqlCommand InsertCmd = new SqlCommand();
            InsertCmd.Connection = con;
            InsertCmd.CommandText = """
                INSERT INTO Customers (CustomerId, Name, Email, DateOfBirth)
                VALUES (@CustomerId, @Name, @Email, @DateOfBirth)
                """;
            InsertCmd.Parameters.AddWithValue("@CustomerId", customer.CustomerID);
            InsertCmd.Parameters.AddWithValue("@Name", customer.Name);
            InsertCmd.Parameters.AddWithValue("@Email", customer.Email);
            InsertCmd.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);

            // Open connection to the database
            con.Open();

            // Execute Insert Query
            InsertCmd.ExecuteNonQuery();

            // Close the connecction to the database
            con.Close();
        }

        public static List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public static void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public static void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public static void DeleteCustomer(int CustomerId)
        {
            throw new NotImplementedException();
        }

        public static Customer GetCustomer(int CustomerId)
        {
            throw new NotImplementedException();
        }
    }
}
