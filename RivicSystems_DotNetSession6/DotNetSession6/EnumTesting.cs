using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLibrary
{
    [Obsolete("Please use new method bla bla bla")]
    public class EnumTesting
    {
        public static void TestEnums()
        {
            Student objStudent = new Student();
            objStudent.StudentId = 100;
            objStudent.StudentName = "Ramesh";
            objStudent.Gender = 1;
            objStudent.stuGender = StudentGender.Male;

            Student objStudent2 = new Student();
            objStudent2.StudentId = 200;
            objStudent2.StudentName = "Bindu";
            objStudent2.Gender = 2;
            objStudent2.stuGender = StudentGender.Female;

            Student[] objStudents = new Student[2];
            objStudents[0] = objStudent;
            objStudents[1] = objStudent2;

            foreach(Student obj in objStudents)
            {
                Console.WriteLine("Name ={0} && Gender = {1}", obj.StudentName, getGender(obj.stuGender));
            }

            Console.ReadLine();

        }

        private static string getGender(int gender)
        {
            switch(gender)
            {
                case 0:
                    return "Uknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data for Gender";
            }

        }

        private static string getGender(StudentGender stgender)
        {
            switch (stgender)
            {
                case StudentGender.Unknown:
                    return "We do not have value in database";
                case StudentGender.Male:
                    return "Hey, I am Male";
                case StudentGender.Female:
                    return "I am Female";
                default:
                    return "Invalid data for Gender";
            }

        }
    }
}
