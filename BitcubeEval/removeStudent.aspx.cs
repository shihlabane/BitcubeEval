using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace BitcubeEval
{
    public partial class removeStudent : System.Web.UI.Page
    {
        //string connection to database
        string connection = @"Data Source=ISHMAEL;Initial Catalog=LecturerMgmtDB;Integrated Security=True";
     
        protected void Page_Load(object sender, EventArgs e)
        {
            lbllecturerName.Text = Session["lectureName"].ToString();
            lbllecturerEmail.Text = Session["lectureEmail"].ToString();
        }

        protected void BtnRemoveStudent_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            string queryString = "DELETE FROM DEGREE WHERE emailAddress_Student = @Semail and degreeName=@degree";
            SqlCommand command = new SqlCommand(queryString,sqlcon);
            command.Parameters.AddWithValue("@Semail", txtstudentEmail.Text);
            command.Parameters.AddWithValue("@degree", txtdegree.Text);

            int result = command.ExecuteNonQuery();
            //Checking if data was deleted successfully or not
            if (result < 0)
            {
                Response.Write("<script language=javascript> alert('Student not removed/ does not exits.')</script>");
            }
            else
            {
                Response.Write("<script language=javascript> alert('Student removed succesfully')</script>");
            }


        }
    }
}