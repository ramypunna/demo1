using System;


namespace RivicSystemsConsoleDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delcaring variables
            int x= 0;
            int[] y = new int[5];

            //Setting values to variables
            y[0] = 1;
            y[1] = 4;
            x = 20;

            //Initializing arrays
            string[] file = new string[1000];

            //Setting values to arrays
            file[0] = "1001	Ramesh	Developer";
            file[1] = "1002	Venkat	Developer";
            file[3] = "12345.456";

            //Printing values to Console
            Console.WriteLine(file[3]);
            //Console.WriteLine(x);

            // Type conversions
            double dblSalary = Convert.ToDouble(file[3]);

            //Boxing/Unboxing
            int val = 100;
            object obj = val;

            Console.WriteLine("10% of salary is [{0}]", dblSalary * .10);
            

            // Creating objects, constructors
            student s = new student("PartTime");

            //Initializging class members
            s.StudentId = 1;
            s.StudentName = "Ramesh";
            s.StudentAddress = "Boston";
            s.Marks = 60;
            s.setMarks(100);
            //Passing objects to other methods as parameters
            StudentManager mgr = new StudentManager();
            int studentLevel = mgr.EstimateStudentLevel(s);

            Console.WriteLine("Student Level:{0} ", studentLevel);

            //Calling read only/static/constants

            Console.WriteLine("Maximum number of subjects a student can take:{0} ", s.MaxnumberofsubjectsHeCanTake);
            Console.WriteLine("College Name:{0} ", student.getCollegeName());
            
            Console.ReadLine();

            student s1 = new student("FullTime");
            s1.StudentId = 2;
            s1.StudentName = "Vijay";
            s1.StudentAddress = "Philly";
            s1.setMarks(200);

            Console.WriteLine("Student mark counter is [{0}]", student.callCounter);


            student s2 = new student("Parttime");
            s2.StudentId = 3;
            s2.StudentName = "Naveesh";
            s2.StudentAddress = "Oklahama";
            s2.setMarks(300);

            Console.WriteLine("Student mark counter is [{0}]", student.callCounter);

            Console.WriteLine("Maximum number of subjects a student can take:{0} ", s1.MaxnumberofsubjectsHeCanTake);
            Console.ReadLine();

            Console.WriteLine("Student id is [{0}]", s.StudentId);
            Console.WriteLine("Student name is [{0}]", s.StudentName);
            Console.WriteLine("Student address is [{0}]", s.StudentAddress);
            Console.WriteLine("Student Phone number is [{0}]", s.StudentPhone);
            Console.ReadLine();

         
        }


    }

   
}
