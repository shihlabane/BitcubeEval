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
    public partial class ViewDegree : System.Web.UI.Page
    {
        //string connection to database
        string connection = @"Data Source=ISHMAEL;Initial Catalog=LecturerMgmtDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            lbllecturerName.Text = Session["lectureName"].ToString();
            lbllecturerEmail.Text = Session["lectureEmail"].ToString();
        }

        protected void btnViewDegree_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            //Selecting data from degree to be populated to gridview
            string queryString = "SELECT degreeName,degreeDurationInYear FROM DEGREE WHERE emailAddress_Lecturer = @lectureEmail";
       
            SqlDataAdapter sqldata = new SqlDataAdapter(queryString, sqlcon);
            sqldata.SelectCommand.Parameters.AddWithValue("@lectureEmail", lbllecturerEmail.Text);
            DataTable dataset = new DataTable();


            sqldata.Fill(dataset);
            gvdDegree.Visible = true;
            gvdDegree.DataSource = dataset;
            gvdDegree.DataBind();
            sqlcon.Close();

        }

        protected void gvdDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow selRow = gvdDegree.SelectedRow;
            string degreeName = selRow.Cells[1].Text;

            Lbldegree.Text = degreeName.ToString();
            //checking if the select data is not null
            if (degreeName != "")
            {
                SqlConnection sqlcon = new SqlConnection(connection);
                sqlcon.Open();

                //selecting data that has been selected from  gridview
                string queryString = "SELECT courseName,courseDurationInMonths FROM COURSE WHERE degreeName = @degree";

                SqlDataAdapter sqldata = new SqlDataAdapter(queryString, sqlcon);
                sqldata.SelectCommand.Parameters.AddWithValue("@degree", degreeName);
                DataTable dataset = new DataTable();


                sqldata.Fill(dataset);
                gvdCourse.Visible = true;
                gvdCourse.DataSource = dataset;
                gvdCourse.DataBind();
                sqlcon.Close();
            }



                

        }

        protected void btnstudent_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            string queryStrig = "INSERT INTO DEGREE(degreeName,degreeDurationInYear,emailAddress_Student,emailAddress_Lecturer) values(@degree,3,@Semail,@lemail)";
            SqlCommand commond = new SqlCommand(queryStrig, sqlcon);
            commond.Parameters.AddWithValue("@degree", Lbldegree.Text);
            commond.Parameters.AddWithValue("@Semail", TxtStudentEmail.Text);
            commond.Parameters.AddWithValue("@Lemail", lbllecturerEmail.Text);
            int result = commond.ExecuteNonQuery();
            sqlcon.Close();

            //Checking if data was add successfully or not
            if (result < 0)
            {
                Response.Write("<script language=javascript> alert('Student not add.')</script>");
            }
            else
            {
                Response.Write("<script language=javascript> alert('Student add succesfully')</script>");
            }

        }
    }
}