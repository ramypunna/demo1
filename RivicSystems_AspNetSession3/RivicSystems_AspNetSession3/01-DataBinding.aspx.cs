using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RivicSystems_AspNetSession3
{
    public partial class _01_DataBinding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDown();
                BindRepeater();
                BindDataList();
            }
        }

        private void BindDataList()
        {
            string ConnString = ConfigurationManager.ConnectionStrings["RivicDBConnString"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter("select * from Student", ConnString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataList1.DataSource = dt;
            DataList1.DataBind();
        }

        private void BindRepeater()
        {
            string ConnString = ConfigurationManager.ConnectionStrings["RivicDBConnString"].ConnectionString;
            SqlDataAdapter da = new SqlDataAdapter("select * from Student", ConnString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }

        private void BindDropDown()
        {
            //get data from DB
            // Load the drop down

            string ConnString = ConfigurationManager.ConnectionStrings["RivicDBConnString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                SqlCommand cmd = new SqlCommand("Select StudentId, StudentName from Student", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                DropDownList1.DataTextField = "StudentName";
                DropDownList1.DataValueField = "StudentId";

                DropDownList1.DataSource = rdr;
                DropDownList1.DataBind();
            }

        }
    }
}