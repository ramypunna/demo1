using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RivicSystemsDotNetSession7
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Gender { get; set; }

    }

    public partial class Student
    {
        public string getStudentName()
        {
            return "Hello " + StudentName;
        } 

        //public int getStudentInfo(int stid, string stname="Ramesh")
        //{
        //    return 10;
        //}
        public int getStudentInfo(int stid, string stname ="", string classname="")
        {
            return 10;
        }
    }
}
