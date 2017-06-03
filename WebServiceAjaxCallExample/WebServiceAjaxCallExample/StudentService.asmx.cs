using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WebServiceAjaxCallExample
{
    /// <summary>
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class StudentService : System.Web.Services.WebService
    {

        [WebMethod]
        public Student GetStudentInformation(int ID)
        {

            string cs = ConfigurationManager.ConnectionStrings["STUDENTCONNECTION"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd=new SqlCommand("SP_GETSTUDENTSBY_ID", con);
                cmd.CommandType=CommandType.StoredProcedure;
                SqlParameter parameter=new SqlParameter("@ID",ID);
                cmd.Parameters.Add(parameter);
                Student student=new Student();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    student.ID = Convert.ToInt32(reader["ID"]);
                    student.NAME = reader["NAME"].ToString();
                    student.GENDER = reader["GENDER"].ToString();
                }

                return student;
            }
            

        }
    }
}
