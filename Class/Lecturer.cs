using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace test1
{
    public class Lecturer
    {

        //database connection string
        string connection = @"Data Source=ISHMAEL;Initial Catalog=LecturerMgmtDB;Integrated Security=True";

        //class member
        public string foreNames { get; set; }
        public string surname { get; set; }
        public string emailAddress { get; set; }
        public DateTime dateOfBirth { get; set; }

        //method to return degree list from database
        public SqlDataReader getDegreeList()
        {
            SqlConnection sqlconn = new SqlConnection(connection);
            string sqlquery = "SELECT degreeName from DEGREE where emailAddress_Lecturer = @email)";
            SqlCommand commad = new SqlCommand(sqlquery, sqlconn);
            commad.Parameters.Add("@email", SqlDbType.Char).Value = emailAddress;
            sqlconn.Open();
            SqlDataReader read;
            read = commad.ExecuteReader();
            sqlconn.Close();
            return read;
        }

    }
}