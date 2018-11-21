using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RivicSystemsDotNetSession7
{
    public class GenericCollectionDemo
    {
        public static void TestGenericList()
        {
            List<int> arr = new List<int>();
            arr.Add(100);
            arr.Add(101);

            List<Student> objList = new List<Student>();
            Student s1 = new Student();
            s1.StudentId = 100;
            s1.StudentName = "Ramesh";
            objList.Add(s1);

            Student s2 = new Student();
            s2.StudentId = 100;
            s2.StudentName = "Vijay";
            objList.Add(s2);

            foreach(Student s in objList)
            {
                Console.WriteLine(s.StudentName);
            }

            Console.ReadLine();
        }

        public static void TestGenericDictionary()
        {
            Dictionary<int, Student> objStudentColl = new Dictionary<int, Student>();

            Student s1 = new Student();
            s1.StudentId = 100;
            s1.StudentName = "Ramesh";
          

            Student s2 = new Student();
            s2.StudentId = 200;
            s2.StudentName = "Vijay";

            objStudentColl.Add(s1.StudentId, s1);
            objStudentColl.Add(s2.StudentId, s2);


            foreach(KeyValuePair<int,Student> studentItem in objStudentColl)
            {
                Console.WriteLine("Key {0}", studentItem.Key);
                Student st = studentItem.Value;
                Console.WriteLine("ID {0} and Name {1}", st.StudentId, st.StudentName);
            }

            if (objStudentColl.ContainsKey(100))
                Console.WriteLine("This colleciton has 100");

          
            Console.ReadLine();
        }
    }
}
