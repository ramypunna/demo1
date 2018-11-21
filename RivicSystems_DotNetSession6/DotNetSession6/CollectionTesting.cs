using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLibrary
{
    public class CollectionTesting
    {
        public static void TestArrayList()
        {

            ArrayList arr = new ArrayList();
            arr.Add(100);
            arr.Add(101);
            arr.Add("Ramesh");

            Student objStudent = new Student();
            objStudent.StudentId = 100;
            objStudent.StudentName = "Ramesh";
            objStudent.Gender = 1;
            objStudent.stuGender = StudentGender.Male;

            arr.Add(objStudent);

            foreach(object i in arr)
            {
                Console.WriteLine(i.ToString());
            }

            Console.ReadLine();
        }

        public static void TestHashTable()
        {

            Hashtable ht = new Hashtable();
            ht.Add(1, "Ramesh");
            ht.Add(2, "Vijay");
            ht.Add(1345, "boston Unuversity");

            
        }

    }
}
