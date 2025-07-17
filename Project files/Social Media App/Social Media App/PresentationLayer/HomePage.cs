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

namespace Social_Media_App
{
    public partial class HomePage : Form
    {
        private string username;
        private DatabaseConnection dbConnection;
        private Friends friends;
        private Posts posts;
        private Comments comments;
        private Reactions reactions;

        public HomePage(string username)
        {
            InitializeComponent();
            this.username = username;
            dbConnection = new DatabaseConnection("SHINI\\SQLEXPRESS05", "SocialMediaApp_database"); 
            friends = new Friends(dbConnection);
            posts = new Posts(dbConnection);
            comments = new Comments(dbConnection);
            reactions = new Reactions(dbConnection);
            LoadFriendPosts();
            ShowUserName(username);
        }

        private void ShowUserName(string username)
        {
            label_homeUserName.Text = username;
        }



        private void LoadFriendPosts()
        {
            string[] friendList = friends.GetFriends(username);
            foreach (string friend in friendList)
            {
                string[] friendPosts = posts.GetUserPosts(friend);
                foreach (string post in friendPosts)
                {
                    PostUtils.AddPostToPanel(post, flowLayoutPanel_home, posts, reactions, comments, friend, username);
                }
            }
        }







        // home, profile and friendship click functionalities
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

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
