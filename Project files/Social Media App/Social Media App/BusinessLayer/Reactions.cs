using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_App.BusinessLayer
{
    public class Reactions
    {

        private DatabaseConnection dbConnection;

        public Reactions(DatabaseConnection dbConnection) 
        { 
            this.dbConnection = dbConnection;
        }


        public void AddReaction(int postId, int userID,string username, string reactionContent)
        {
            SqlConnection connection = dbConnection.GetConnection();
            connection.Open();

            string query = $"INSERT INTO Reactions (PostID, UserID, Username, Reaction) VALUES ({postId}, {userID},'{username}', '{reactionContent}')";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PostID", postId);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@ReactionContent", reactionContent);

            command.ExecuteNonQuery();
            connection.Close();
        }



        public string[] GetReactions(int postId)
        {
            string[] reactionsArray = new string[0]; 

            SqlConnection connection = dbConnection.GetConnection();
            connection.Open();

            string query = @"SELECT u.username + ': ' + r.Reaction AS ReactionWithUsername
                    FROM Reactions r
                    JOIN Users u ON r.UserID = u.UserID
                    WHERE r.PostID = @PostID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PostID", postId);

            SqlDataReader reader = command.ExecuteReader();
            int count = 0; // Initialize a count variable to track the number of reactions

            while (reader.Read())
            {
                // Resize the array for each reaction found
                Array.Resize(ref reactionsArray, count + 1);
                reactionsArray[count] = reader["ReactionWithUsername"].ToString();
                count++;
            }

            connection.Close();

            return reactionsArray;

        }







    }
}
