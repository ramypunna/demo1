using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RivicSystems_WcfServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in both code and config file together.
    public class StudentService : IStudentService
    {
       
        public string Enroll()
        {
            return "You are enrolled";
        }

        public int GenerateException(int num1, int num2)
        {
            return num1 / num2;
        }

        public string RegisterForCourse(string courseId)
        {
            return string.Format("you are registered for course[{0}]", courseId);
        }
    }
}
