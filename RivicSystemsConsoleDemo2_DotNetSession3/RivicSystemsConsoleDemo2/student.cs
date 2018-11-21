using System;

namespace RivicSystemsConsoleDemo2
{
    public class student
    {
        public static int callCounter;
        public int Marks;
        public readonly int MaxnumberofsubjectsHeCanTake;
        public string StudentAddress;
        public int StudentId;
        public string StudentName;
        private string v;

        public student(string v)
        {
            callCounter++;
            MaxnumberofsubjectsHeCanTake = 100;
            this.v = v;
        }

        public int StudentPhone { get; set; }

        public void setMarks(int v)
        {
            Marks = v;
        }

        public static string getCollegeName()
        {
            return "boston University";
        }
    }
}