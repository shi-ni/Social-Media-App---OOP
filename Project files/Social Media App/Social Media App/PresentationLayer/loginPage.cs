using Social_Media_App;
using Social_Media_App.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class loginPage : Form
    {
        private DatabaseConnection dbConnection;

        public loginPage()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection("SHINI\\SQLEXPRESS05", "SocialMediaApp_database");
            //this.username = username;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

                if (dbConnection.ValidateUser(username, password))
                {                    
                    HomePage nextPage = new HomePage(username);
                    nextPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
        }
      
    }
}
