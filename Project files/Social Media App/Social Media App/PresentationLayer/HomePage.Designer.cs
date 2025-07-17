namespace Social_Media_App
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lbl_Social_Media = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Friends = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_home = new System.Windows.Forms.FlowLayoutPanel();
            this.label_home = new System.Windows.Forms.Label();
            this.lbl_homeUserName = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_homeUserName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Social_Media
            // 
            this.lbl_Social_Media.AutoSize = true;
            this.lbl_Social_Media.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Social_Media.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Social_Media.ForeColor = System.Drawing.Color.White;
            this.lbl_Social_Media.Location = new System.Drawing.Point(4, 7);
            this.lbl_Social_Media.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Social_Media.Name = "lbl_Social_Media";
            this.lbl_Social_Media.Size = new System.Drawing.Size(140, 16);
            this.lbl_Social_Media.TabIndex = 4;
            this.lbl_Social_Media.Text = "SOCIAL MEDIA APP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_Friends);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_Profile);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(43, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 42);
            this.panel2.TabIndex = 8;
            // 
            // btn_Friends
            // 
            this.btn_Friends.BackColor = System.Drawing.Color.Black;
            this.btn_Friends.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Friends.ForeColor = System.Drawing.Color.White;
            this.btn_Friends.Location = new System.Drawing.Point(561, 13);
            this.btn_Friends.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Friends.Name = "btn_Friends";
            this.btn_Friends.Size = new System.Drawing.Size(92, 29);
            this.btn_Friends.TabIndex = 6;
            this.btn_Friends.Text = "Friends";
            this.btn_Friends.UseVisualStyleBackColor = false;
            this.btn_Friends.Click += new System.EventHandler(this.btn_Friends_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(514, -1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 41);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Profile
            // 
            this.btn_Profile.BackColor = System.Drawing.Color.Black;
            this.btn_Profile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.Color.White;
            this.btn_Profile.Location = new System.Drawing.Point(326, 13);
            this.btn_Profile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(92, 29);
            this.btn_Profile.TabIndex = 5;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.UseVisualStyleBackColor = false;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(279, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 41);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Black;
            this.btn_Home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Location = new System.Drawing.Point(87, 13);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(92, 29);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_Social_Media);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(43, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 30);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label_UserName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 450);
            this.panel3.TabIndex = 9;
            // 
            // flowLayoutPanel_home
            // 
            this.flowLayoutPanel_home.AutoScroll = true;
            this.flowLayoutPanel_home.Controls.Add(this.label_home);
            this.flowLayoutPanel_home.Controls.Add(this.lbl_homeUserName);
            this.flowLayoutPanel_home.Controls.Add(this.label_homeUserName);
            this.flowLayoutPanel_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_home.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_home.Location = new System.Drawing.Point(43, 72);
            this.flowLayoutPanel_home.Name = "flowLayoutPanel_home";
            this.flowLayoutPanel_home.Size = new System.Drawing.Size(677, 378);
            this.flowLayoutPanel_home.TabIndex = 10;
            this.flowLayoutPanel_home.WrapContents = false;
            this.flowLayoutPanel_home.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.Location = new System.Drawing.Point(3, 0);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(107, 24);
            this.label_home.TabIndex = 0;
            this.label_home.Text = "User name:";
            // 
            // lbl_homeUserName
            // 
            this.lbl_homeUserName.AutoSize = true;
            this.lbl_homeUserName.Location = new System.Drawing.Point(3, 24);
            this.lbl_homeUserName.Name = "lbl_homeUserName";
            this.lbl_homeUserName.Size = new System.Drawing.Size(0, 13);
            this.lbl_homeUserName.TabIndex = 1;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(46, 109);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(35, 13);
            this.label_UserName.TabIndex = 2;
            this.label_UserName.Text = "label1";
            // 
            // label_homeUserName
            // 
            this.label_homeUserName.AutoSize = true;
            this.label_homeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_homeUserName.Location = new System.Drawing.Point(3, 37);
            this.label_homeUserName.Name = "label_homeUserName";
            this.label_homeUserName.Size = new System.Drawing.Size(44, 16);
            this.label_homeUserName.TabIndex = 2;
            this.label_homeUserName.Text = "label1";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.flowLayoutPanel_home);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel_home.ResumeLayout(false);
            this.flowLayoutPanel_home.PerformLayout();
            this.ResumeLayout(false);

        }

        //------------------------------------------------------------------------------------------
         /*           this.flowLayoutPanel_home = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_home
            // 
            this.flowLayoutPanel_home.AutoScroll = true;
            this.flowLayoutPanel_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_home.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_home.Name = "flowLayoutPanel_home";
            this.flowLayoutPanel_home.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel_home.TabIndex = 0;
            // 
            // HomePage
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel_home);
            this.Name = "HomePage";
            this.Text = "Home";
            this.ResumeLayout(false);


*/


        
        //----------------------------------------------------------------------------------------------------------
        #endregion

        private System.Windows.Forms.Label lbl_Social_Media;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Friends;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_home;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Label lbl_homeUserName;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_homeUserName;
    }
}