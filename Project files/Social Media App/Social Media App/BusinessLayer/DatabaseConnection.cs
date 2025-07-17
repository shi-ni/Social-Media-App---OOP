using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Social_Media_App.BusinessLayer
{
    public class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection(string server, string databaseName)
        {
            connectionString = "Server= "+ server +";Database=" + databaseName + ";Integrated Security=True;";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public bool ValidateUser(string username, string password)
        {
            SqlConnection connection = GetConnection();
            connection.Open();
            string query = $"SELECT COUNT(1) FROM Users WHERE username='{username}' AND userPassword='{password}'";
            SqlCommand command = new SqlCommand(query, connection);
            int count = (int)command.ExecuteScalar();
            connection.Close();

            if (count == 1)
                return true;
            else
                return false;
        }

        public bool ValidateUser(string username)
        {
            SqlConnection connection = GetConnection();
            connection.Open();
            string query = $"SELECT COUNT(1) FROM Users WHERE username='{username}'";
            SqlCommand command = new SqlCommand(query, connection);
            int count = (int)command.ExecuteScalar();
            connection.Close();

            if (count == 1)
                return true;
            else
                return false;
        }

    }
}
