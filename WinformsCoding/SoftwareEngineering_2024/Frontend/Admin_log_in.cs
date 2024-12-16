using SoftwareEngineering_2024.DB_connect;
using SoftwareEngineering_2024.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_2024
{
    public partial class Admin_log_in : Form
    {

        private adminDAL adminDAL = new adminDAL();
        public Admin_log_in()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
        }

        private void AdminLoginBt_Click(object sender, EventArgs e)
        {

            string Email = email_txt?.Text ?? string.Empty;
            string Password = password_txt?.Text ?? string.Empty;

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter both email and password.", "Login Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Authenticate the user
            bool isAuthenticated = adminDAL.AuthenticateAdmin(Email, Password);

            if (isAuthenticated)
            {
                // Navigate to UserHomeForm1 if authentication is successful
                FormOpener.OpenUserForm(this, typeof(AdminHomeForm));

            }
            else
            {
                // Show error message if authentication fails
                MessageBox.Show("Invalid email or password. Please try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }




        }

        private void Admin_log_in_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormOpener.OpenUserForm(this, typeof(LoginForm));
        }
    }
}
