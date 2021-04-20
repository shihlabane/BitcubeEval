using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace test1
{
    public class Degree
    {
        //database connection string
        public string connection = @"Data Source=ISHMAEL;Initial Catalog=LecturerMgmtDB;Integrated Security=True";

        //class member
        public string degreeName { get; set; }
        public int degreeDurationInYeasr { get; set; }
        public int degreeID { get; set; }
        public string courseName { get; set; }
        public SqlDataReader getCourses()
        {

            SqlConnection sqlconn = new SqlConnection(connection);
            string sqlquery = "SELECT courseName from COURSE where(degreeName = @degreename)";
            SqlCommand commad = new SqlCommand(sqlquery, sqlconn);
            commad.Parameters.Add("@degreename", SqlDbType.Char).Value = degreeName;
            sqlconn.Open();
            SqlDataReader read ;
            read = commad.ExecuteReader();
            sqlconn.Close();

            return read;
        }

    }
    public class Course : Degree
    {
    

        public SqlDataReader getDegree()
        {

            SqlConnection sqlconn = new SqlConnection(connection);
            string sqlquery = "SELECT degreeName from DEGREE where(courseName = @coursename)";
            SqlCommand commad = new SqlCommand(sqlquery, sqlconn);
            commad.Parameters.Add("@coursename", SqlDbType.Int).Value = courseName;
            sqlconn.Open();
            SqlDataReader read ;
            read = commad.ExecuteReader();
            sqlconn.Close();

            return read;
        }



    }
}