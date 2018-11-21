using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentLibrary;

namespace LanguageFeatures_DotNetSession4
{

    
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            string str = "Welcome to Rivic Systems";
            str = "Hi";

            string[] strArr;
            string finalName;
            TestStringType(out strArr, out finalName);
            Console.WriteLine("Final Name [{0}] after changes ", finalName);

            StringBuilder sb = TestStringBuilder(strArr);
            Console.WriteLine("Final Name [{0}] after changes ", sb.ToString());

           
           
            Student s1 = new Student();
            s1.StudentId = 200;
            s1.StudentName = "Bindu";
            s1.EvaluatePerformance();

            TestValRef obj = new TestValRef();
            string str1 = obj.EvaluateValueType(s1, i);
            Console.WriteLine("Student Name [{0}] and Int value [{1}] after changes ", s1.StudentName, i);

            string retVal = obj.EvaluateStringType(str);
            Console.WriteLine("String type [{0}] after changes ", retVal);
            Console.ReadLine();

            // Polymorphism testing
            FultimeStudent fs = new FultimeStudent();
            string rval1 = fs.ApplyLocalDiscount();
            Console.WriteLine("ApplyLocalDiscount [{0}] after changes ", rval1);

            string rval2 = fs.ApplyLocalDiscount("Computers");
            Console.WriteLine("ApplyLocalDiscount [{0}] after changes ", rval2);

            Student partSt = new ParttimeStudent();
            Console.WriteLine("Student ApplyLocalDiscount [{0}] after changes ", partSt.ApplyLocalDiscount());


            // create objects array
            Student[] stuArr = new Student[5];
            stuArr[0] = fs;
            stuArr[1] = partSt;
            stuArr[2] = fs;
            stuArr[3] = partSt;
            stuArr[4] = fs;


            // loop through array ti display list of diffrent students
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("Student ApplyLocalDiscount [{0}] after changes ", stuArr[k].ApplyLocalDiscount());
            }



            Console.ReadLine();

        }

        private static StringBuilder TestStringBuilder(string[] strArr)
        {
            StringBuilder sb = new StringBuilder(5);
            for (int k = 0; k < 5; k++)
            {
                sb = sb.Append(strArr[k] + ",");
            }

            return sb;
        }

        private static void TestStringType(out string[] strArr, out string finalName)
        {
            // String and ting builder samples
            strArr = new string[5];
            strArr[0] = "Ramesh";
            strArr[1] = "Vijay";
            strArr[2] = "Bindu";
            strArr[3] = "Venkat";
            strArr[4] = "Jyo";

            finalName = string.Empty;
            for (int k = 0; k < 5; k++)
            {
                finalName = finalName + strArr[k] + ",";
            }

        }
    }

    // passing by ref and by val parameters
    public  class TestValRef
    {
        public string EvaluateValueType(Student obj, int intVal)
        {
            string retVal = string.Empty;

            obj.StudentName = "Vijay";
          
            intVal = 20;

            return retVal;
        }


        // passing string parameters
        public string EvaluateStringType(string objString)
        {
            objString = "See you";
            return objString;
        }


    }
}
