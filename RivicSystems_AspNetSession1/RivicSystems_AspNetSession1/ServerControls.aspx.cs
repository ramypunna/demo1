using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RivicSystems_AspNetSession1
{
    public partial class ServerControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Write("Page is post back" + "<br/>");
            }
            else
                Response.Write("Page is first time load" + "<br/>");

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed" + "<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}