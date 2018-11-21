using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqClassLibrary
{
    public class BestProfessor
    {
        public string ProfessorName { get; set; }
        public string ProfessorCountry { get; set; }
        public int AwardedYear { get; set; }

        public BestProfessor(string name, string country, int year)
        {
            ProfessorName = name;
            ProfessorCountry = country;
            AwardedYear = year;
        }


    }
}
