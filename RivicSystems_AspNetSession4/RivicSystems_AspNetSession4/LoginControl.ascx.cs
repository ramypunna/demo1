using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RivicSystems_AspNetSession4
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSaveName_Click(object sender, EventArgs e)
        {
            //goes to DB and validates user
            Response.Write("User Validated, going to default page");
        }
    }
}