using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RivicSystems_AspNetSession1
{
    public partial class _Default : Page
    {
        int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox1.Text = HiddenField1.Value;

            

            if (!IsPostBack)
            {
                Response.Write("Initial load");
                TextBox1.Text = "0";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ClicksCount = Convert.ToInt32(HiddenField1.Value);

            //ClicksCount = ClicksCount + 1;
            //TextBox1.Text = ClicksCount.ToString();
            //HiddenField1.Value = ClicksCount.ToString();

            //ViewState["counter"] = TextBox1.Text;
            //ViewState["counter"] = Convert.ToInt32(ViewState["counter"]) + 1;
            //TextBox1.Text = Convert.ToString(ViewState["counter"]);

            HttpCookie cookie = new HttpCookie("counterCookie", TextBox1.Text);
            ClicksCount = 0;
            ClicksCount = ClicksCount + 1;
            cookie.Value = Convert.ToString(ClicksCount);
            TextBox1.Text = cookie.Value;

            
        }
    }
}