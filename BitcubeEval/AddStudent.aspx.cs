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
    public partial class AddStudent : System.Web.UI.Page
    {
        string connection = @"Data Source=ISHMAEL;Initial Catalog=LecturerMgmtDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            lbllecturerName.Text = Session["lectureName"].ToString();
            lbllecturerEmail.Text = Session["lectureEmail"].ToString();

        }

        protected void btnSubmitStudent_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            string queryString = "INSERT INTO STUDENT VALUES(@forename,@surname,@email,@dateOfBirth)";
            SqlCommand commnd = new SqlCommand(queryString, sqlcon);
            commnd.Parameters.AddWithValue("@email", TxtEmail.Text);
            commnd.Parameters.AddWithValue("@forename", Txtforename.Text);
            commnd.Parameters.AddWithValue("@surname", TxtSurname.Text);
            commnd.Parameters.AddWithValue("@dateOfBirth", TxtDateOfBirth.Text);

            int result = commnd.ExecuteNonQuery();
            if (result < 0)
            {
                Response.Write("<script language=javascript> alert('Student not add.')</script>");
            }
            else
            {
                Response.Write("<script language=javascript> alert('Student add succesfully')</script>");
            }
            sqlcon.Close();
        }
    }
}