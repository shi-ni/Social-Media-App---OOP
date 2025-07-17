using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_App.BusinessLayer
{
    public class Comments
    {
        private DatabaseConnection dbConnection;

        public Comments(DatabaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }


        public void AddComment(int postId, string username, string commentContent)
        {
            SqlConnection connection = dbConnection.GetConnection();
            connection.Open();

            string query = $"INSERT INTO Comments (PostID, CommentContent, Username) VALUES ({postId} ,'{commentContent}', '{username}')";
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            connection.Close();
        }


        public string[] GetComments(int postId)
        {
            string[] commentsArray = new string[0];

            SqlConnection connection = dbConnection.GetConnection();
            connection.Open();

            string query = @"SELECT u.username + ': ' + c.CommentContent AS CommentWithUsername
                     FROM Comments c
                     JOIN Users u ON c.username = u.username
                     WHERE c.PostID = @PostID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PostID", postId);

            SqlDataReader reader = command.ExecuteReader();
            int count = 0; // Initialize a count variable to track the number of comments

            while (reader.Read())
            {
                // Resize the array for each comment found
                Array.Resize(ref commentsArray, count + 1);
                commentsArray[count] = reader["CommentWithUsername"].ToString();
                count++;
            }

            connection.Close();

            return commentsArray;
        }


    }
}
