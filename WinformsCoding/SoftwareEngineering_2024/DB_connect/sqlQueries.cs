using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering_2024.DB_connect
{

    public static class SqlQueries
    {

        // Member/User-related queries
        public const string RegisterMember = "INSERT INTO members ( first_name, last_name, email, phone_no, password, house_no, street, city, state, city_code, country) VALUES (@first_name, @last_name, @Email, @phone_no, @password,  @house_no, @street, @city, @state, @city_code, @country)";
        public const string AuthenticateUser = "SELECT password FROM members WHERE email = @Email";
        public const string INTEREST_query = "INSERT INTO interests (interest_1, interest_2, interest_3, interest_4, interest_5, member_id) VALUES (@interest_1, @interest_2, @interest_3, @interest_4, @interest_5, @member_id)";
        public const string TAG_query = "INSERT INTO tags (tag_1, tag_2, tag_3, tag_4, tag_5, tag_6, tag_7, tag_8, tag_9, tag_10, tag_11, tag_12, member_id) VALUES (@tag_1, @tag_2, @tag_3, @tag_4, @tag_5, @tag_6, @tag_7, @tag_8, @tag_9, @tag_10, @tag_11, @tag_12, @member_id)";
        public const string MemInfo_query = "UPDATE members\r\nSET membership_id = @membership_id\r\nWHERE member_id = @member_id;\r\n ";
        
        public const string Payment_query = "INSERT INTO payments (cardHolder_name, card_no, cvv, house_no, city, state, country, street , citycode, exp_date , member_id) VALUES (@cardHolder_name, @card_no, @cvv, @house_no, @city, @state, @country, @street, @citycode, @exp_date, @member_id )";
        public const string IsRegisteredUpdate = "UPDATE members \r\nSET is_registered = 1\r\nWHERE member_id = @member_id;";


        public const string QUERY_FEEDBACK_query = "INSERT INTO queries_feedback (Query_Type, Queries_Feedback_description, member_id) VALUES (@query_type, @description, @member_id)";

        // Member/User-related queries
        public const string AuthenticateAdmin= "SELECT password FROM members WHERE email = @Email";


        //public const string CheckUserExist = "SELECT 1 FROM Users WHERE Username = @Username OR Email = @Email LIMIT 1";

        

       
    }





}
