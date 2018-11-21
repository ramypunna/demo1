using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLibrary
{
    public class MITStudentManager : StudentManager
    {
        protected override int ApplyStateTaxes(Student objStudent)
        {
            return 10;
        }

        public new void setInfo()
        {
            //do some thing;
        }
    }
}
