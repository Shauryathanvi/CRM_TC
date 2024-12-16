using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SoftwareEngineering_2024.DB_connect;
using SoftwareEngineering_2024.utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SoftwareEngineering_2024
{

    public partial class LoginForm : Form
    {
        // Initialize userDAL to ensure it's not null when used
        private userDAL userDAL = new userDAL();
        private UserContext userContext = new UserContext();



        public LoginForm()
        {
            InitializeComponent();

            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);

            AccountCreateLink.Click += SignUpLinkClicked;
        }

        private void SignUpLinkClicked(object sender, EventArgs e)
        {
            FormOpener.OpenUserForm(this, typeof(SignUpForm));
            userDAL.DeleteUser();
        }





        private void LoginBt_Click(object sender, EventArgs e)
        {
            // Retrieve email and password from form inputs
            string Email = email_txt?.Text ?? string.Empty;
            string Password = password_txt?.Text ?? string.Empty;

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter both email and password.", "Login Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Declare a variable to store the registration status
            bool isRegistered;

            // Authenticate the user and get the registration status
            bool isAuthenticated = userDAL.AuthenticateUser(Email, Password, out isRegistered);

            if (isAuthenticated)
            {
                if (isRegistered)
                {
                    // Set the email in UserContext after successful login
                    UserContext.EMAIL = Email;  // Now the email is available globally in UserContext

                    // Now you can retrieve the MemberID (This is optional, depending on your design)
                    int? memberId = userContext.RetrieveMemberID();  // Store memberId if needed

                    // Navigate to UserHomeForm1 if authentication is successful and registration is complete
                    Opener.OpenForm(this, typeof(UserHomeForm1));
                }
                else
                {
                    MessageBox.Show("Please complete the registration process before logging in.",
                                     "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show error message if authentication fails
                MessageBox.Show("Invalid email or password. Please try again.",
                                 "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int? Give_Id()
        {
            // Ensure the email is set in UserContext
            if (string.IsNullOrEmpty(UserContext.EMAIL))
            {
                throw new Exception("Email is not set in UserContext.");
            }

            // Retrieve the Member ID based on the email stored in UserContext
            return userContext.RetrieveMemberID();  // This will use the email to retrieve MemberID
        }





        private void AdminLoginLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormOpener.OpenUserForm(this, typeof(Admin_log_in));
        }
    }
}
