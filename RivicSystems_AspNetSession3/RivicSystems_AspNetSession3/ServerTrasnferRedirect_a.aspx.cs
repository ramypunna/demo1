using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RivicSystems_AspNetSession3
{
    public partial class ServerTrasnferRedirect_a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Collections.Specialized.NameValueCollection previousFormcollection = Request.Form;
            lblName.Text = previousFormcollection["txtName"];
            lblEmail.Text = previousFormcollection["txtEmail"];
        }
    }
}