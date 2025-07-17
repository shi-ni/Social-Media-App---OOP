using Social_Media_App.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Social_Media_App
{
    
    public partial class FriendshipPage : Form
    {
        private Friends friends;
        private DatabaseConnection dbConnection;
        private string username;
        public FriendshipPage(string username)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection("SHINI\\SQLEXPRESS05", "SocialMediaApp_database");
            friends = new Friends(dbConnection);
            this.username = username;
            LoadFriends();
        }



        private void LoadFriends()
        {
            string[] friendsList = friends.GetFriends(username);

            listBox_friends.Items.Clear();
            foreach (string friend in friendsList)
            {
                listBox_friends.Items.Add(friend);
            }
        }


        //AddFriend Button
        private void btn_AddFriend_Click(object sender, EventArgs e)
        {
            string newFriendUsername = txt_username.Text;
            if (dbConnection.ValidateUser(newFriendUsername))
            {
                friends.AddFriend(username, newFriendUsername);
                LoadFriends(); 
                //listBox_friends.Items.Add(newFriendUsername);
                txt_username.Clear();
                MessageBox.Show($"{newFriendUsername} has been added to your friends list.");
            }
            else
            {
                MessageBox.Show("Please enter a valid username.");
            }
        }

        //DeleteFriend Button
        private void button1_Click(object sender, EventArgs e)
        {
            string friendToDelete = txt_username.Text;

            if (dbConnection.ValidateUser(friendToDelete))
            {
                friends.DeleteFriend(username, friendToDelete);
                MessageBox.Show("Friend deleted!");
                LoadFriends();
                listBox_friends.Items.Remove(friendToDelete);
                txt_username.Clear();
            }
            else
                MessageBox.Show("User not found.");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        //SearchFriend Button
        private void btn_search_Click(object sender, EventArgs e)
        {

        }


        //Friendlist button
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadFriends();
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(username);
            homePage.Show();
            this.Hide();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage(username);
            userPage.Show();
            this.Hide();
        }

        private void btn_Friends_Click(object sender, EventArgs e)
        {
            FriendshipPage friendshipPage = new FriendshipPage(username);
            friendshipPage.Show();
            this.Hide();
        }



    }
}
