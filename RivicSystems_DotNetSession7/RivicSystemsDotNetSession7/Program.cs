using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RivicSystemsDotNetSession7
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenericCollectionDemo.TestGenericList();
            // GenericCollectionDemo.TestGenericDictionary();
            //TestAnonmousMethods();
            Student s = new Student();
            s.StudentId = 100;
            s.StudentName = "Naveesh";
 
            Console.WriteLine(s.getStudentInfo(10,));

            Console.ReadLine();
        }

        private static void TestAnonmousMethods()
        {
            
            // AnonmousMethodsDemo.CalculateDelegate p = new AnonmousMethodsDemo.CalculateDelegate(Square);

            // old way of using delegate
            //AnonmousMethodsDemo.Transform(new int[] { 5, 6, 7, 8 }, p);


            //AnonmousMethodsDemo.Transform(new int[] { 5, 6, 7, 8 }, delegate (int i)
            //    {
            //        return i * i;
            //});

            int[] results = AnonmousMethodsDemo.Transform(new int[] { 5, 6, 7, 8 }, x => x * x);

            int[] results1 = AnonmousMethodsDemo.Transform(new int[] { 5, 6, 7, 8 }, x => x + x);

            foreach (int i in results)
            {
                Console.WriteLine("Result is {0}", i);
            }

            foreach (int i in results1)
            {
                Console.WriteLine("Result is {0}", i);
            }

            //public delegate bool testDelegate(int num);

            Expression<Func<int, bool>> lamdaexObj = x => x < 5;
            lamdaexObj.Compile()(10);
        }

    }
}
