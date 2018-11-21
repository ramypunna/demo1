using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RivicSystems_AspNetSession1
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page load fired");
            Response.Write("<\br>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page init fired");
            Response.Write("<\br>");
        }

        protected void Page_Preload(object sender, EventArgs e)
        {
            Response.Write("Page preload fired");
            Response.Write("<\br>");
        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
            Session["CollegeName"] = "Boston University1";
            Response.Write("Page prerender fired");
            Response.Write("<\br>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write("Page Unload fired");
        }



    }
}