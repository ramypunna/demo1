using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLibrary
{
    public enum StudentGender
    {
        Unknown =0,
        Male = 1,
        Female =2
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Gender { get; set; }

        public StudentGender stuGender { get; set; }
       

    }

    public class StudentManager<T> where T : Student
    {

    }
}
