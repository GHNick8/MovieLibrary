using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MovieLibrary.cs
{
    internal class MovieService
    {
        // Method in seperate cs file using Databasehelper to fill table with movie data
        public static DataTable GetAllMovies()
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM MovieDB";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Method in seperate cs file to add movie with new SqlCommand
        public static void AddMovie(Movie movie)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO MovieDB (Title, Genre, Directors, Writers, Stars, ReleaseYear, Rating)" +
                            "VALUES (@title, @genre, @director, @writer, @stars, @releaseYear, @rating)";
                SqlCommand command = new SqlCommand(query, connection);

                // Add values to Sql commands 
                command.Parameters.AddWithValue("@title", movie.Title);
                command.Parameters.AddWithValue("@genre", movie.Genre);
                command.Parameters.AddWithValue("@director", movie.Director);
                command.Parameters.AddWithValue("@writer", movie.Writer);
                command.Parameters.AddWithValue("@stars", movie.Stars);
                command.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
                command.Parameters.AddWithValue("@rating", movie.Rating);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Method to update movie with Sql Command update 
        public static void UpdateMovie(Movie movie)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE MovieDB SET Title = @title, Genre = @genre, Directors = @director, " +
                               "Writers = @writer, Stars = @stars, ReleaseYear = @releaseYear, Rating = @rating " +
                               "WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", movie.Id);
                command.Parameters.AddWithValue("@title", movie.Title);
                command.Parameters.AddWithValue("@genre", movie.Genre);
                command.Parameters.AddWithValue("@director", movie.Director);
                command.Parameters.AddWithValue("@writer", movie.Writer);
                command.Parameters.AddWithValue("@stars", movie.Stars);
                command.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
                command.Parameters.AddWithValue("@rating", movie.Rating);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Method to delete movie with Sql command delete 
        public static void DeleteMovie(int id)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM MovieDB WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Method to search movie with Sql command select 
        public static DataTable SearchMovies(string searchTerm)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM MovieDB WHERE Title LIKE @search OR Genre LIKE @search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", $"%{searchTerm}%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Method in seperate cs file using DatabaseHelper to open and test Sql connection
        public static bool TestDatabaseConnection()
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                return connection.State == ConnectionState.Open;
            }
        }
    }
}
