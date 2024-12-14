using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareEngineering_2024.DB_connect;
using SoftwareEngineering_2024.utilities;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SoftwareEngineering_2024
{
    public partial class InterestDptForm : Form
    {

        private db_connect db = new db_connect();
        private userDAL userDAL = new userDAL();

        public InterestDptForm()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
            ProceedTagBt.Click += ProceedTagBt_Click;


        }

        private void ProceedTagBt_Click(object? sender, EventArgs e)
        {

            List<string> INTEREST = GetSelectedInterest(); // Ensure you are calling the correct method

            if (INTEREST != null && INTEREST.Count > 0) // Check if the list is not null and contains items
            {
                try
                {
                    // Use the UserDAL instance to save the interests to the database
                    bool Registered = userDAL.SaveInterestToDatabase(INTEREST);

                    MessageBox.Show("Interests saved successfully!");
                    FormTracker.StepsCompleted[1] = true;  //this will count this form if the form is completed then it will store true
                    Opener.OpenForm(this, typeof(TagsForm));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one interest.");
            }


        }




        private List<string> GetSelectedInterest()
        {
            List<string> INTEREST = new List<string>();

            // Check each radio button and add the corresponding interest to the list if it's checked
            if (Learning.Checked) INTEREST.Add("Learning");
            if (Happening.Checked) INTEREST.Add("Happening");
            if (Helping.Checked) INTEREST.Add("Helping");
            if (Working.Checked) INTEREST.Add("Working");
            if (Sharing.Checked) INTEREST.Add("Sharing");

            return INTEREST;
        }

        private void PreviousPageBt_Click(object sender, EventArgs e)
        {
            Opener.GoBack(this);
            FormTracker.StepsCompleted[1] = false;
            FormTracker.StepsCompleted[0] = false;
            userDAL.DeleteUserByMEmid();
        }

        

    }
}
