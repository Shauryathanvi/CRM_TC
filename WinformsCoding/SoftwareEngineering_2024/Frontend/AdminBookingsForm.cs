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

    public partial class AdminBookingsForm : Form
    {

        private showTables ShowTables = new showTables();

        public AdminBookingsForm()
        {
            InitializeComponent();
            FormOpener.OpenAdminDashboardPages(AdminHomeBt, MembersBt, StaffEventsBt, AdminBookingsBt, EngagementBt, AdminQueryBt, Attendance_log_bt);
        }


        private void AdminBookingForm_Load(object sender, EventArgs e)
        {

            string query = "SELECT \r\n    b.Booking_id AS `Booking ID`,\r\n    b.Payment_id AS `Payment ID`,\r\n    CONCAT(m.first_name, ' ', m.last_name) AS `Member Name`,\r\n    e.event_name AS `Event Name`,\r\n    e.member_price AS `Member Price`\r\nFROM \r\n    bookings AS b\r\nJOIN \r\n    members AS m\r\nON \r\n    b.member_id = m.member_id\r\nJOIN \r\n    events AS e\r\nON \r\n    b.event_id = e.event_id;\r\n";
            ShowTables.GRIDVIEW(BookingsTableDg, query);

        }

        private void LogOutBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(AdminBookingsForm));
        }

        
    }

}


