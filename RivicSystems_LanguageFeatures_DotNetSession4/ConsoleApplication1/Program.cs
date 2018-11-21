using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeviceManager;
using StudentLibrary;

namespace LanguageFeatures_DotNetSession5
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAbstractMethods obj = new TestAbstractMethods();
            obj.DisplayStudentTotalFee();
        }


    }

    public class TestAbstractMethods
    {
        public void DisplayStudentTotalFee()
        {
            StudentManager objManager = new HarvardStudentManager();
            Student objStudent = new Student();
            objStudent.StudentId = 100;
            objStudent.StudentName = "Naveesh";
            double result = objManager.GetStudentTotalFeePaid(objStudent);

            Console.WriteLine("Student total Fee Paid {0} ", result);

            // Console.WriteLine("Student total Fee Paid {0} ", getTotalPaid(objManager));

            StudentManager objMITManager = new MITStudentManager();
            Console.WriteLine("Student total Fee Paid {0} ", getTotalPaid(objMITManager));

        }

        private double getTotalPaid(StudentManager mgr)
        {
            Student objStudent = new Student();
            objStudent.StudentId = 100;
            objStudent.StudentName = "Naveesh";
            return mgr.GetStudentTotalFeePaid(objStudent);

        }
    }

    public class TestInterfaces
    {
        public void CallDeviceMethods()
        {
            IRivicDevice objrivicDevice = new AppleDevice();
            objrivicDevice.DisplayStatus();
        }
        
    }
}
