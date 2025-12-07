using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalBonSucreApp
{
    internal class ReviewDb
    {
        public static SqlConnection GetConnection()
        {
            // Create and return a connection to the database
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BonSucre;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }

        public static void AddReview(Review review)
        {
            // Establish connection to database
            SqlConnection con = GetConnection();
            // Prepare Insert Statement
            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = con;
            addCommand.CommandText = """
                INSERT INTO Reviews (ReviewId, CustomerId, DessertId, Score)
                VALUES (@ReviewId, @CustomerId, @DessertId, @Score);
                SELECT SCOPE_IDENTITY();
                """;
            addCommand.Parameters.AddWithValue("@ReviewId", review.ReviewId);
            addCommand.Parameters.AddWithValue("@CustomerId", review.CustomerId);
            addCommand.Parameters.AddWithValue("@DessertId", review.DessertId);
            addCommand.Parameters.AddWithValue("@Score", review.Score);
            // Open connection to the database
            con.Open();
            // Execute Insert Query
            addCommand.ExecuteNonQuery();
            // Close the connecction to the database
            con.Close();
        }

        public static List<Review> GetAllReviews()
        {
            // Get a database connection
            SqlConnection con = GetConnection();
            // Open connection
            con.Open();
            // Prepare SQL command
            // Raw string literal - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/raw-string
            string query = """
            SELECT ReviewId, CustomerId, DessertId, Score
            FROM Reviews
            ORDER BY ReviewId ASC
            """;
            SqlCommand selectCommand = new()
            {
                Connection = con,
                CommandText = query
            };
            SqlDataReader reader = selectCommand.ExecuteReader();
            List<Review> reviews = new List<Review>();
            while (reader.Read())
            {
                Review review = new Review()
                {
                    ReviewId = Convert.ToInt32(reader["ReviewId"]),
                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                    DessertId = Convert.ToInt32(reader["DessertId"]),
                    Score = Convert.ToInt32(reader["Score"])
                };
                reviews.Add(review);
            }
            // Close connection to database
            con.Close();
            return reviews;
        }

        public static void UpdateReviewScore(int reviewId, int newScore)
        {
            // Get a database connection
            SqlConnection con = GetConnection();
            // Open connection
            con.Open();
            // Prepare SQL command
            string query = """
            UPDATE Reviews
            SET Score = @NewScore
            WHERE ReviewId = @ReviewId
            """;
            SqlCommand updateCommand = new()
            {
                Connection = con,
                CommandText = query
            };
            updateCommand.Parameters.AddWithValue("@NewScore", newScore);
            updateCommand.Parameters.AddWithValue("@ReviewId", reviewId);
            // Execute command on the db
            updateCommand.ExecuteNonQuery();
            // Close connection to database
            con.Close();
        }

        public static void DeleteReview(Review review)
        {
            DeleteReview(review.ReviewId);
        }

        public static void DeleteReview(int reviewId)
        {
            // Get a database connection
            SqlConnection con = GetConnection();
            // Open connection
            con.Open();
            // Prepare SQL command
            string query = """
            DELETE FROM Reviews
            WHERE ReviewId = @ReviewId
            """;
            SqlCommand deleteCommand = new()
            {
                Connection = con,
                CommandText = query
            };
            deleteCommand.Parameters.AddWithValue("@ReviewId", reviewId);
            // Execute command on the db
            deleteCommand.ExecuteNonQuery();
            // Close connection to database
            con.Close();
        }
    }
}
