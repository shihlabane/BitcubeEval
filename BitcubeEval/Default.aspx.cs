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
    public partial class _Default : System.Web.UI.Page
    {
        //string connection to the database
        string connection = @"Data Source=ISHMAEL;Initial Catalog=LecturerMgmtDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            
            using(SqlConnection sqlcon = new SqlConnection(connection)){

                sqlcon.Open();

                // Selecting data from Degree and student table
                string queryString = "SELECT surname,forename,degreeName FROM STUDENT S INNER JOIN DEGREE D ON S.emailAddress_Student = D.emailAddress_Student WHERE emailAddress_Lecturer = @lectureEmail ";
               
                SqlDataAdapter sqldata = new SqlDataAdapter(queryString,sqlcon);
                sqldata.SelectCommand.Parameters.AddWithValue("@lectureEmail", TxtLecturerEmail.Text);
                DataTable dataset = new DataTable();
                
               
                sqldata.Fill(dataset);
                gvdStudent.Visible = true;
                gvdStudent.DataSource = dataset;
                gvdStudent.DataBind();
                sqlcon.Close();

            }
            //Saving credential to session to be used on other pages
            Session["lectureName"] = TxtLecturerName.Text;
            Session["lectureEmail"] = TxtLecturerEmail.Text;

        }

        protected void gvdStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
