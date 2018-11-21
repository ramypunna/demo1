using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLibrary
{
    public class HarvardStudentManager : StudentManager
    {
        protected override int ApplyStateTaxes(Student objStudent)
        {
            return 5;
        }
   
    }
}
