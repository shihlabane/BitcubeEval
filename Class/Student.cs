using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace test1
{
    public class Student
    {
        //database connection string
        string connection = @"Data Source=ISHMAEL;Initial Catalog=LecturerMgmtDB;Integrated Security=True";

        //class member
        public string forename { get; set; }
        public string surname { get; set; }
        public string emailAdress { get; set; }
        public string dateOfBirth { get; set; }

        public SqlDataReader getDegree()
        {

            SqlConnection sqlconn = new SqlConnection(connection);
            string sqlquery = "SELECT forename,surname,degreeName from STUDENT INNER JOIN DEGREE ON STUDENT.emailAddress_Student = DEGREE.emailAddress_Student where forename = @foreName";
            SqlCommand commad = new SqlCommand(sqlquery, sqlconn);
            commad.Parameters.Add("@foreName", SqlDbType.Char).Value = forename;
            SqlDataReader read ;
            sqlconn.Open();
            read = commad.ExecuteReader();
            
            return read;
        }
    }
}