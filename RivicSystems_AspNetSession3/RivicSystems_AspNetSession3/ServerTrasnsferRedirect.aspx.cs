using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RivicSystems_AspNetSession3
{
    public partial class ServerTrasnsferRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExecute_Click(object sender, EventArgs e)
        {
            //Response.Redirect("ServerTrasnferRedirect_a");

            //Server.Transfer("~/ServerTrasnferRedirect_a");

            Server.Execute("~/ServerTrasnferRedirect_a");
            lblStatus.Text = "The call resturned after processing execute";

        }
    }
}