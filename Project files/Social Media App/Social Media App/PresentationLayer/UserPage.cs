using Login_Page;
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
    public partial class UserPage : Form
    {
        private DatabaseConnection dbConnection;
        private Posts post;
        private Reactions reacts;
        private Comments comments;
       // private int userID = 2;
        private string username;
        public UserPage(string username)
        {
            InitializeComponent();
            this.username = username;
            dbConnection = new DatabaseConnection("SHINI\\SQLEXPRESS05", "SocialMediaApp_database");
            post = new Posts(dbConnection);
            reacts = new Reactions(dbConnection);
            comments = new Comments(dbConnection);
            LoadUserPosts();
            // To reset posts array if needed
            //post.ClearPost();

            // flow layout properties
            flowLayoutPanel_posts.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_posts.WrapContents = false;
            flowLayoutPanel_posts.AutoScroll = true;
        }

        private void LoadUserPosts()
        {
            string[] posts = post.GetUserPosts(username);
            flowLayoutPanel_posts.Controls.Clear();

            foreach (var postContent in posts)
            {
                AddPostToPanel(postContent);
            }

        }

        private void AddPostToPanel(string postContent)
        {

            // panel for each post
            Panel postPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Width = flowLayoutPanel_posts.ClientSize.Width - 20,
                Padding = new Padding(10),
                Margin = new Padding(0, 0, 0, 10), 
                AutoSize = true,
                Dock = DockStyle.Top
            };


            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 3,
                Dock = DockStyle.Fill,
                AutoSize = true
            };


            // label for the post content
            Label postLabel = new Label
            {
                Text = postContent,
                AutoSize = true,
                MaximumSize = new Size(postPanel.Width - 20, 0) 
            };
            postPanel.Controls.Add(postLabel);
            // add the panel to the flow layout panel
            flowLayoutPanel_posts.Controls.Add(postPanel);



            // REACTS BUTTON :
            ContextMenuStrip reactionsMenu = new ContextMenuStrip();

            Button reactionsButton = new Button
            {
                Text = "Reacts",
                AutoSize = true,
                Margin = new Padding(0, 50, 0,0)
            };
            reactionsButton.Click += (s, e) =>
            {
                reactionsMenu.Items.Clear();
                int postId = post.GetPostId(username, postContent);
                string[] reactions = reacts.GetReactions(postId);

                for (int i = 0; i < reactions.Length; i++)
                {
                    reactionsMenu.Items.Add(reactions[i]);
                }

                // Show the ContextMenuStrip below the button
                reactionsMenu.Show(reactionsButton, new Point(0, reactionsButton.Height));
            };


            //COMMENTS BUTTON :
            string[] commentsArray = comments.GetComments(post.GetPostId(username, postContent));

            Button commentsButton = new Button
            {
                Text = "View Comments",
                AutoSize = true,
                Margin = new Padding(0, 10, 0, 0)
            };
            ContextMenuStrip commentsMenu = new ContextMenuStrip();

            // Event handler for comments button click
            commentsButton.Click += (s, e) =>
            {              
                commentsMenu.Items.Clear();
                int postId = post.GetPostId(username, postContent);
                commentsArray = comments.GetComments(postId);

                foreach (var comment in commentsArray)
                {
                    commentsMenu.Items.Add(comment);
                }

                // Show the ContextMenuStrip below the button
               commentsMenu.Show(commentsButton, new Point(0, commentsButton.Height));
            };

           
            //TO SHOW BUTTONS
            postPanel.Controls.Add(reactionsButton);
            flowLayoutPanel_posts.Controls.Add(postPanel);
            postPanel.Controls.Add(tableLayout);
            tableLayout.Controls.Add(postLabel, 0, 0);
            tableLayout.Controls.Add(reactionsButton, 0, 1);
            tableLayout.Controls.Add(commentsButton, 0, 3);

        }


        private void btn_post_Click(object sender, EventArgs e)
        {
           
            // Add post to panel
            string content = rtxtbox_postContent.Text;

            if (!string.IsNullOrWhiteSpace(content))
            {
                post.CreateNewPosts(username, content); 
                AddPostToPanel(content); 
                rtxtbox_postContent.Clear(); 
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            post.ClearPost();
            rtxtbox_postContent.Clear();
        }


    }
}
