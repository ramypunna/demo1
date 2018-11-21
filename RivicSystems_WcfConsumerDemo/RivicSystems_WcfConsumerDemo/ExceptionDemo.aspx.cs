using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RivicSystems_WcfConsumerDemo
{
    public partial class ExceptionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            int numerator = Convert.ToInt32(txtNumerator.Text);
            int denominator = Convert.ToInt32(txtDenominator.Text);
            var client = new StudentServiceReference.StudentServiceClient();

            try
            {
                lblResult.Text = client.GenerateException(numerator, denominator).ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}