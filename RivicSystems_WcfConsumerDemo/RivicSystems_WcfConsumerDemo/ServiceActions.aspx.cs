using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RivicSystems_WcfConsumerDemo
{
    public partial class ServiceActions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentServiceReference.StudentServiceClient obj = new StudentServiceReference.StudentServiceClient();
            Response.Write(obj.RegisterForCourse("Computers"));

            
        }
    }
}