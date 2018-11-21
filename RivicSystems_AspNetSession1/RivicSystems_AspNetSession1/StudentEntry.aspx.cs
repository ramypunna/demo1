using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RivicSystems_AspNetSession1
{
    public partial class StudentEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Application["CollegeName"] = "Boston University";
            Session["CollegeName"] = "Boston University";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Redirect.aspx?stuName=" + TextBox1.Text);
        }
    }
}