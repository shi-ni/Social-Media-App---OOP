using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media_App.BusinessLayer
{
    public static class PostUtils
    {
        public static void AddPostToPanel(string postContent, FlowLayoutPanel flowLayoutPanel_posts, Posts post, Reactions reacts, Comments comments, string username, string UserName)
        {

            // panel for each post
            Panel postPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Width = flowLayoutPanel_posts.ClientSize.Width - 20,
                Padding = new Padding(10),
                Margin = new Padding(210, 30, 50, 10),
                AutoSize = true,
                Dock = DockStyle.Top
            };

            // Table layout
            TableLayoutPanel containerPanel = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 1,
                Width = flowLayoutPanel_posts.ClientSize.Width,
                Height = flowLayoutPanel_posts.ClientSize.Height,
                AutoSize = true,
                Dock = DockStyle.Top,
                Padding = new Padding(0),
                Margin = new Padding(0),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 5,
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
            // Add the panel to the flow layout panel
            flowLayoutPanel_posts.Controls.Add(postPanel);


            //label for username
            Label usernameLabel = new Label
            {
                Text = "by: " + username,
                AutoSize = true,
                Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold),
                ForeColor = Color.Black
            };


            // COMMENTS SECTION:
            string[] commentsArray = comments.GetComments(post.GetPostId(username, postContent));

            // Button for comments
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

            // ADD COMMENT SECTION:
            TextBox commentTextBox = new TextBox
            {
                Width = postPanel.Width - 20,
                Margin = new Padding(0, 10, 0, 0)
            };
            Button addCommentButton = new Button
            {
                Text = "Add Comment",
                AutoSize = true,
                Margin = new Padding(0, 10, 0, 0)
            };
            addCommentButton.Click += (s, e) =>
            {
                string commentContent = commentTextBox.Text;
                if (!string.IsNullOrWhiteSpace(commentContent))
                {
                    int postId = post.GetPostId(username, postContent);

                    if (postId != 0)
                    {
                        int userId = post.GetUserID(username);
                        comments.AddComment(postId, UserName, commentContent);
                        commentTextBox.Clear();

                        // Refresh comments display
                        commentsMenu.Items.Clear();
                        string[] updatedCommentsArray = comments.GetComments(postId);
                        foreach (var comment in updatedCommentsArray)
                        {
                            commentsMenu.Items.Add(comment);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Post not found.");
                    }

                }
            };



            // REACTION SECTION:
            ContextMenuStrip reactionsMenu = new ContextMenuStrip();

            // Button for reactions
            Button reactionsButton = new Button
            {
                Text = "Reacts",
                AutoSize = true,
                Margin = new Padding(0, 50, 0, 0)
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


            Button addReactionButton = new Button
            {
                Text = "Like", 
                AutoSize = true,
                Margin = new Padding(0, 10, 0, 0)
            };
            addReactionButton.Click += (s, e) =>
            {

                int postId = post.GetPostId(username, postContent);
                int userId = post.GetUserID(UserName);

                reacts.AddReaction(postId, userId, UserName, "Like"); 
                                                             
                reactionsMenu.Items.Clear();
                string[] updatedReactionsArray = reacts.GetReactions(postId);
                foreach (var reaction in updatedReactionsArray)
                {
                    reactionsMenu.Items.Add(reaction);
                }
            };

            // TO SHOW BUTTONS AND INPUTS
            postPanel.Controls.Add(reactionsButton);
            postPanel.Controls.Add(commentsButton);
            postPanel.Controls.Add(commentTextBox);
            postPanel.Controls.Add(addCommentButton);
            postPanel.Controls.Add(addReactionButton);
            flowLayoutPanel_posts.Controls.Add(postPanel);
            postPanel.Controls.Add(tableLayout);
            tableLayout.Controls.Add(postLabel, 0, 0);
            tableLayout.Controls.Add(reactionsButton, 0, 1);
            tableLayout.Controls.Add(commentsButton, 0, 2);
            tableLayout.Controls.Add(commentTextBox, 0, 3);
            tableLayout.Controls.Add(addCommentButton, 0, 4);
            tableLayout.Controls.Add(addReactionButton, 0, 5);
            tableLayout.Controls.Add(usernameLabel, 0, 6);

        }
    }

}
