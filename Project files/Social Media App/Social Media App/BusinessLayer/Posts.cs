using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media_App.BusinessLayer
{
    public class Posts
    {
        private DatabaseConnection dbConnection;
        private string[] posts;

        public Posts(DatabaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public string[] GetUserPosts(string username)
        {
            posts = new string[0];

            SqlConnection connection = dbConnection.GetConnection();
            connection.Open();

            string query = $"SELECT PostContent FROM Posts WHERE username = '{username}'";
            SqlCommand command = new SqlCommand(query, connection);

            // Read sql query
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // resize the posts array for each record found in PostContent column
                Array.Resize(ref posts, posts.Length + 1);
                posts[posts.Length - 1] = reader["PostContent"].ToString();
            }
            connection.Close();

            return posts;
        }

        public void CreateNewPosts(string username, string PostContent)
        {
            SqlConnection connection = dbConnection.GetConnection();
            connection.Open();

            // Get the userID based on the username
            string getUserIDQuery = $"SELECT userID FROM Users WHERE username = '{username}'";
            SqlCommand getUserIDCommand = new SqlCommand(getUserIDQuery, connection);
            int userID = (int)getUserIDCommand.ExecuteScalar();


            string query = $"INSERT INTO Posts (userID, postContent, username) VALUES ({userID}, '{PostContent}', '{username}')";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void ClearPost()
        {
            posts = null;
        }


        public int GetPostId(string username, string postContent)
        {
                int postId = 0;

                SqlConnection connection = dbConnection.GetConnection();
                connection.Open();

                string query = $"SELECT PostID FROM Posts WHERE username = '{username}' AND PostContent = '{postContent}'";
               // MessageBox.Show($"Query: {query}"); // Print the query for debugging
                SqlCommand command = new SqlCommand(query, connection);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    postId = Convert.ToInt32(result);
                }

                connection.Close();

                return postId;
        }

        public int GetUserID(string username)
        {
            int userID = 0;

            SqlConnection connection = dbConnection.GetConnection();
            connection.Open();

            string query = $"SELECT userID FROM Users WHERE username = '{username}'";
            SqlCommand command = new SqlCommand(query, connection);

            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                userID = Convert.ToInt32(result);
            }

            connection.Close();

            return userID;
        }

    }
}
