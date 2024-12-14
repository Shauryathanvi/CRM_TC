using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using SoftwareEngineering_2024.utilities;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SoftwareEngineering_2024.DB_connect
{
    public class userDAL
    {

        private db_connect db = new db_connect();



        public void TestDatabaseConnection()
        {
            db.TestConnection();
        }


        /* id can be used in any method */
        private int id = UserContext.Memberid;


        //  ===== REGISTER MEMBER IN "TEST" DATABSE IN "MEMBER" TABLE =====
        public bool RegisterMember(string Email, string Password, string Firstname, string Lastname, string Phonenumber, string Housenumber, string Street , string City , string State , string Country, string Citycode)
        {
            // Hash the password before storing it
            string hashedPassword = HashPassword(Password);

            // Check if the user with the given email already exists
            using (MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM members WHERE email = @Email", db.GetConnection()))
            {
                checkCmd.Parameters.AddWithValue("@Email", Email);

                try
                {
                    db.OpenConnection();
                    var result = checkCmd.ExecuteScalar();
                    db.CloseConnection();

                    if (result != null && Convert.ToInt32(result) > 0)
                    {
                        // User already exists, show an alert box
                        MessageBox.Show("A user with this email already exists. Please use a different email.",
                                        "Registration Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error checking user existence: " + ex.Message);
                    db.CloseConnection();
                    return false;
                }
            }

            // User doesn't exist, proceed with insertion
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.RegisterMember, db.GetConnection()))
            {
                registerCmd.Parameters.AddWithValue("@first_name", Firstname);
                registerCmd.Parameters.AddWithValue("@last_name", Lastname);
                registerCmd.Parameters.AddWithValue("@Email", Email);
                registerCmd.Parameters.AddWithValue("@phone_no", Phonenumber);
                registerCmd.Parameters.AddWithValue("@password", hashedPassword);
                registerCmd.Parameters.AddWithValue("@house_no", Housenumber);
                registerCmd.Parameters.AddWithValue("@street", Street);
                registerCmd.Parameters.AddWithValue("@city", City);
                registerCmd.Parameters.AddWithValue("@state", State);
                registerCmd.Parameters.AddWithValue("@city_code", Citycode);
                registerCmd.Parameters.AddWithValue("@country", Country);


                registerCmd.Parameters.AddWithValue("@member_id", id); /* this will save member id in table*/
                try
                {
                    db.OpenConnection();
                    registerCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error registering user: " + ex.Message);
                    db.CloseConnection();
                    return false;
                }
            }
        }

        //  =====REGISTER MEMBER INTEREST AND TAGS MEMBERSHIP TYPE=====
        public bool SaveInterestToDatabase(List<string> INTEREST)
        {

            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.INTEREST_query, db.GetConnection()))
            {
                //// Prepare parameters for interests
                //registerCmd.Parameters.AddWithValue("@userId", GetUserId());  // Replace with your user ID retrieval logic

                // For the 5 interest columns (interest_1, interest_2, etc.)
                for (int i = 0; i < 5; i++)
                {
                    if (i < INTEREST.Count)
                    {
                        // If the interest exists, assign it to the corresponding column
                        registerCmd.Parameters.AddWithValue($"@interest_{i + 1}", INTEREST[i]);
                    }
                    else
                    {
                        // If there's no interest, set it as NULL
                        registerCmd.Parameters.AddWithValue($"@interest_{i + 1}", DBNull.Value);
                    }
                }


                registerCmd.Parameters.AddWithValue("@member_id", id); /* this will save member id in table*/

                try
                {
                    db.OpenConnection();
                    registerCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return true;
                }
                catch (Exception ex)
                {
                    // Optionally log or handle exception
                    throw new Exception("Database operation failed: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }


        public bool SaveTagToDatabase(List<string> TAG)
        {
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.TAG_query, db.GetConnection()))
            {

                // For the 5 interest columns (interest_1, interest_2, etc.)
                for (int i = 0; i < 12; i++)
                {
                    if (i < TAG.Count)
                    {
                        // If the interest exists, assign it to the corresponding column
                        registerCmd.Parameters.AddWithValue($"@tag_{i + 1}", TAG[i]);
                    }
                    else
                    {
                        // If there's no interest, set it as NULL
                        registerCmd.Parameters.AddWithValue($"@tag_{i + 1}", DBNull.Value);
                    }
                }

                registerCmd.Parameters.AddWithValue("@member_id", id); /* this will save member id in table*/

                try
                {
                    db.OpenConnection();
                    registerCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return true;
                }
                catch (Exception ex)
                {
                    // Optionally log or handle exception
                    throw new Exception("Database operation failed: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

       


        public bool SaveMem_TypeToDatabase(int membership_id, int member_id )
        {
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.MemInfo_query, db.GetConnection()))
            {
                registerCmd.Parameters.AddWithValue("@membership_id", membership_id);
                registerCmd.Parameters.AddWithValue("@member_id", member_id);



                try
                {
                    db.OpenConnection();
                    int rowsAffected = registerCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        public bool SaveisRegisToDatabase(int member_id)
        {
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.IsRegisteredUpdate, db.GetConnection()))
            {
                registerCmd.Parameters.AddWithValue("@is_registered", 1);
                registerCmd.Parameters.AddWithValue("@member_id", member_id);



                try
                {
                    db.OpenConnection();
                    int rowsAffected = registerCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }



        //public bool InsertMemberInterests(CheckBox checkBox1, CheckBox checkBox2, CheckBox checkBox3, CheckBox checkBox4, CheckBox checkBox5)
        //{
        //    // List to hold the interest IDs of checked checkboxes
        //    List<int> checkedInterestIds = new List<int>();

        //    // Array of checkboxes to iterate through
        //    CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };

        //    // Iterate through the checkboxes and add the Tag values of checked ones to the list
        //    foreach (CheckBox checkBox in checkBoxes)
        //    {
        //        if (int.TryParse(checkBox.Tag?.ToString(), out int interest_id))
        //        {
        //            checkedInterestIds.Add(interest_id); // Add the parsed interest_id to the list
        //        }
        //        else
        //        {
        //            // Handle the case where the Tag is not a valid integer
        //            Console.WriteLine($"Invalid interest_id in Tag for checkbox {checkBox.Name}");
        //        }
        //    }

        //    // If no interest IDs are checked, return false
        //    if (checkedInterestIds.Count == 0)
        //    {
        //        return false;
        //    }

        //    // Now use the db connection and query logic to insert the values
        //    foreach (int interestId in checkedInterestIds)
        //    {
        //        using (MySqlCommand insertCmd = new MySqlCommand(SqlQueries.InsertInterestQuery, db.GetConnection()))
        //        {
        //            // Clear existing parameters to avoid duplicate definitions
        //            insertCmd.Parameters.Clear();

        //            // Add parameters for the insert query
        //            insertCmd.Parameters.AddWithValue("@interest_id", interestId);
        //            insertCmd.Parameters.AddWithValue("@member_id", id);

        //            try
        //            {
        //                // Open the connection, execute the insert command, and close the connection
        //                db.OpenConnection();
        //                int rowsAffected = insertCmd.ExecuteNonQuery();
        //                db.CloseConnection();

        //                // If rows are affected, it means the insert was successful
        //                if (rowsAffected <= 0)
        //                {
        //                    return false;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                // Handle any errors that occur during the insert
        //                Console.WriteLine("Error: " + ex.Message);
        //                db.CloseConnection();
        //                return false;
        //            }
        //            finally
        //            {
        //                // Ensure the connection is closed
        //                db.CloseConnection();
        //            }
        //        }
        //    }

        //    return true;
        //}

        public bool DeleteMembersWithNullRegistration()
        {
            // Define the SQL query to delete rows where is_registered is NULL
            string deleteQuery = "DELETE FROM `members` WHERE `is_registered` IS NULL;";

            // Using MySQLCommand for database interaction
            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, db.GetConnection()))
            {
                try
                {
                    // Open the connection
                    db.OpenConnection();

                    // Execute the delete query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Close the connection
                    db.CloseConnection();

                    // If rows were deleted, return true, else false
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the delete operation
                    Console.WriteLine("Error deleting members: " + ex.Message);
                    db.CloseConnection();
                    return false;
                }
                finally
                {
                    // Ensure the connection is always closed
                    db.CloseConnection();
                }
            }
        }




        public bool Payment_infoToDatabse(string CardHolder_name, string Card_no, string Cvv, string House_no, string City, string State, string Country, string Street, string Citycode, string Exp_date)
        {


          
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.Payment_query, db.GetConnection()))
            {



                registerCmd.Parameters.AddWithValue("@cardHolder_name", CardHolder_name);
                registerCmd.Parameters.AddWithValue("@card_no", Card_no);
                registerCmd.Parameters.AddWithValue("@cvv", Cvv);
                registerCmd.Parameters.AddWithValue("@house_no", House_no);
                registerCmd.Parameters.AddWithValue("@city", City);
                registerCmd.Parameters.AddWithValue("@state", State);
                registerCmd.Parameters.AddWithValue("@country", Country);
                registerCmd.Parameters.AddWithValue("@street", Street);
                registerCmd.Parameters.AddWithValue("@citycode", Citycode);
                registerCmd.Parameters.AddWithValue("@exp_date", Exp_date);

                registerCmd.Parameters.AddWithValue("@member_id", id); //* this will save member id in table*/


                try
                {
                    db.OpenConnection();
                    registerCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error registering user: " + ex.Message);
                    db.CloseConnection();
                    return false;
                }
            }
        }




        /* This method is called when user press the prvious button and this method will delete thw last entered data from the databse*/
        public bool DeleteUserByMEmid()
        {

            int id = UserContext.Memberid;
            string Delete_query = "DELETE FROM members WHERE member_id = @member_id";

            using (MySqlCommand command = new MySqlCommand(Delete_query, db.GetConnection()))
            {
                command.Parameters.AddWithValue("@member_id", id);


                try
                {
                    db.OpenConnection();
                    command.ExecuteNonQuery();
                    db.CloseConnection();
                    return true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error registering user: " + ex.Message);
                    db.CloseConnection();
                    return false;
                }


            }


        }




        //This method will authentic the user at the time of login
        public bool AuthenticateUser(string Email, string Password, out bool isRegistered)
        {
            string hashedPassword = HashPassword(Password); // Hash the input password
            isRegistered = false; // Default value for isRegistered

            using (MySqlCommand cmd = new MySqlCommand(SqlQueries.AuthenticateUser, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@Email", Email);

                try
                {
                    db.OpenConnection();
                    var result = cmd.ExecuteScalar();
                    db.CloseConnection();

                    if (result != null)
                    {
                        // Assuming the query returns the hashed password
                        string storedHashedPassword = result.ToString();
                        Console.WriteLine($"Stored Hashed Password: {storedHashedPassword}");
                        Console.WriteLine($"Input Hashed Password: {hashedPassword}");

                        // Check if passwords match
                        if (storedHashedPassword == hashedPassword)
                        {
                            // Now check the user's registration status (is_registered)
                            string query = "SELECT is_registered FROM members WHERE email = @Email";
                            using (MySqlCommand registrationCmd = new MySqlCommand(query, db.GetConnection()))
                            {
                                registrationCmd.Parameters.AddWithValue("@Email", Email);

                                db.OpenConnection();
                                var regResult = registrationCmd.ExecuteScalar();
                                db.CloseConnection();

                                if (regResult != null)
                                {
                                    // Convert to boolean (assuming 1 for registered, 0 for not)
                                    isRegistered = Convert.ToBoolean(regResult);
                                }
                            }

                            return true; // Successful authentication
                        }
                    }

                    return false; // Failed authentication
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    db.CloseConnection();
                    return false;
                }
            }
        }

        

        public bool SaveQueryFeedbackToDatabase(string queryType, string description, int? memberId)
        {
            using (MySqlCommand queryCmd = new MySqlCommand(SqlQueries.QUERY_FEEDBACK_query, db.GetConnection()))
            {
                queryCmd.Parameters.AddWithValue("@query_type", queryType);
                queryCmd.Parameters.AddWithValue("@description", description);
                queryCmd.Parameters.AddWithValue("@member_id", memberId);

                try
                {
                    db.OpenConnection();
                    queryCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.CloseConnection();
                    return false;
                }


            }
        }





        // Helper method to hash passwords
        private static string HashPassword(string Password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
            
        
        }

        


    }
}


