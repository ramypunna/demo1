using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RivicSystems_AspNetSession4
{
    public partial class _01_UserControlDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebCustomControl1.Text = "Custom Control demo for .Net Experts";
        }
    }
}