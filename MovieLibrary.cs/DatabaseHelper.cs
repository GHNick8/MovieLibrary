using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MovieLibrary.cs
{
    internal class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            // Method in seperate cs file + added timeout
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rawap\Desktop\C#\MovieLibrary.cs\MovieLibrary.cs\MovieLibraryDB.mdf;Integrated Security=True; Connect Timeout=30";
            return new SqlConnection(connectionString);
        }
    }
}
