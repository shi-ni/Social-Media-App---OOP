using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Social_Media_App.BusinessLayer
{
    public class Friends
    {
        public int userID { get; set; }
        public string username { get; set; }

        private string[] friends;
        private DatabaseConnection dbConnection;

        public Friends(DatabaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }
        public Friends()
        {

        }
        //----------------------
        //   Add Friend Method
        //----------------------
        public void AddFriend(string username1, string username2)
        {
            SqlConnection connection = dbConnection.GetConnection();
            connection.Open();

            // Get userID for username1
            string query1 = $"SELECT userID FROM Users WHERE username = '{username1}'";
            SqlCommand command1 = new SqlCommand(query1, connection);
            int userID1 = (int)command1.ExecuteScalar();

            // Get userID for username2
            string query2 = $"SELECT userID FROM Users WHERE username = '{username2}'";
            SqlCommand command2 = new SqlCommand(query2, connection);
            int userID2 = (int)command2.ExecuteScalar();

            string insertQuery = $"INSERT INTO Friends (UserID1, UserID2, Username1, Username2) VALUES ({userID1}, {userID2}, '{username1}', '{username2}')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.ExecuteNonQuery();

            connection.Close();
        }

        //---------------------
        // Delete Friend Method
        //---------------------
        public void DeleteFriend(string username1, string username2)
        {
            SqlConnection connection = dbConnection.GetConnection();
            connection.Open();

            // Delete the friendship relationship from the Friends table
            string deleteQuery = $"DELETE FROM Friends WHERE (Username1 = '{username1}' AND Username2 = '{username2}') OR (Username1 = '{username2}' AND Username2 = '{username1}')";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.ExecuteNonQuery();

            connection.Close();
        }


        //----------------------
        // Get Friend Method
        //----------------------
        public string[] GetFriends(string username)
        {
            friends = new string[0];

            SqlConnection connection = dbConnection.GetConnection();
            connection.Open();

            string query = $"SELECT Username2 FROM Friends WHERE Username1 = '{username}'";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // Resize the friends array for each record found
                Array.Resize(ref friends, friends.Length + 1);
                friends[friends.Length - 1] = reader["Username2"].ToString();
            }

            connection.Close();
            return friends;
        }

    }
}