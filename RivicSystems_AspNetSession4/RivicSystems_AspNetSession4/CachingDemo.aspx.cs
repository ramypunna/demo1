using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RivicSystems_AspNetSession4
{
    public partial class CachingDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = String.Format("Loading the page....{0}", DateTime.Now);
            //string ConnString = ConfigurationManager.ConnectionStrings["RivicDBConnString"].ConnectionString;


            //using (SqlConnection con = new SqlConnection(ConnString))
            //{
            //    SqlCommand cmd = new SqlCommand("exec spGetStudents", con);

            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    DropDownList1.DataTextField = "StudentName";
            //    DropDownList1.DataValueField = "StudentId";
            //    DropDownList1.DataSource = rdr;
            //    DropDownList1.DataBind();
            //}

            //Label2.Text = String.Format("Load completed for the page....{0}", DateTime.Now);



        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            List<string> lstString = new List<string>();
            string ConnString = ConfigurationManager.ConnectionStrings["RivicDBConnString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(ConnString))
            {
                SqlCommand cmd = new SqlCommand("SELECT STUDENTNAME FROM STUDENT", con);
                con.Open();
                SqlDataReader rdr1 = cmd.ExecuteReader();
                if (Cache["StudentNames"] == null)
                  {
                    Response.Write("Cache is empty, so getting frm DB");
                    while (rdr1.Read())
                    {
                        string name = Convert.ToString(rdr1[0]);
                        lstString.Add(name);
                    }
                    Response.Write("Inserting into cache");
                    Cache.Insert("StudentNames", lstString, null, DateTime.Now.AddSeconds(300), TimeSpan.Zero);
                }
                else
                {
                    Response.Write("Reading from cache");
                    lstString = (List<string>)Cache["StudentNames"];
                }

                lstString.ForEach(x => Response.Write(x + "<br>"));
            }
        }
    }
}