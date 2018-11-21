using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LinqClassLibrary;

namespace RivicSystems_AspNetSession4
{
    public partial class LinqFeatures : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var str = "Ramesh";
            //Response.Write(str.WishMe());

            //var billamount = 234.56;
            //Response.Write(String.Format("tip Amount for {0} is {1}", billamount, billamount.GetTipAmount()));

            //var strAddress = "TExas";

            //var anonType = new { empId = 100, empName = "Ramesh" };
            //Response.Write(anonType.empName);

            if (!IsPostBack)
            {
                string ConnString = ConfigurationManager.ConnectionStrings["RivicDBConnString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnString))
                {
                    SqlCommand cmd = new SqlCommand("Select * from BestProfessors", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    var pros = new List<BestProfessor>();
                    while (rdr.Read())
                    {
                        var item = new BestProfessor(Convert.ToString(rdr[0]), Convert.ToString(rdr[1]), Convert.ToInt32(rdr[2]));
                        pros.Add(item);
                    }

                    //ListProfessors(pros);
                    ListByCountry(pros);
                }
            }
        }


        private void ListProfessors(IEnumerable<BestProfessor> pros)
        {
            var result = from item in pros
                         orderby item.ProfessorName ascending
                         select new { item.ProfessorName, item.ProfessorCountry };


            foreach(var item in result)
            {
                Response.Write("<br>");
                Response.Write(item.ProfessorName);
            }

        }

        public void ListByCountry(IEnumerable<BestProfessor> lstBestProfessor)
        {

            var result = from pro in lstBestProfessor
                         group pro by pro.ProfessorCountry into countries
                         orderby countries.ToList().Count descending,
                         countries.Key
                         select countries;

            var result1 = lstBestProfessor
                .GroupBy(x => x.ProfessorCountry).
                OrderBy(x => x.ToList().Count).
                ThenBy(x => x.Key).
                Select(x => x);

            foreach (var item in result)
            {
                Response.Write("<br>");
                Response.Write(string.Format("{0}: {1}", item.Key, item.ToList().Count));
                Response.Write("<br>");
                foreach (BestProfessor professor in item.ToList())
                {
                    Response.Write("<br>");
                    Response.Write(string.Format("{0}:{1}", professor.AwardedYear, professor.ProfessorName));
                }
            }
        }
    }
}