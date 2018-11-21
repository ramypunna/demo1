using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLibrary
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        
        public int EvaluatePerformance()
        {
            this.ApplyLocalDiscount();
            //1. Validate Student Information
            //2.Connect to DB
            //3. Process Data
            return 1;
        }

        public virtual string ApplyLocalDiscount()
        {
            // Set 10% to all subjects
            return "2% to all students and all subjects";
        }

        //private void Validate()
        //{

        //}

        //private void GetdetaisFromDB()
        //{

        //}

        //private void CalcPerformance()
        //{

        //}

    }

    public class FultimeStudent : Student
    {

        public void processFulltimeFee()
        {
            //do some process..
        }

        public override string ApplyLocalDiscount()
        {
            // Set 10% to all subjects
            return "10% to all fulltime students and all subjects";
        }

        public string ApplyLocalDiscount(string subjectName)
        {
            // Set 10% to only that subject
            return "10% to all fulltime students but only for subject : " + subjectName;
        }

        public string ApplyLocalDiscount(string professorName, int discount)
        {
            // Set 10% to only that subject
            return String.Format("[{0} to all fulltime students but only for professor [{1}]", discount, professorName);
        }
    }

    public class ParttimeStudent : Student
    {
        public override string ApplyLocalDiscount()
        {
            return "5% to all part time students and all subjects";
        }

    }

}
