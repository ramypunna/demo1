using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RivicSystemsDotNetSession7
{
    public class AnonmousMethodsDemo
    {
        public delegate int CalculateDelegate(int num);

        //Func<int, int> funcDel;
        //Action<int> actDel;
        //Predicate<int> preDel;


        public static int[] Transform(int[] values, CalculateDelegate objDelegate )
        {
             for(int i = 0; i<values.Length;i++)
            {
                values[i] = objDelegate(values[i]);
            }
            return values;
        }

        public int square(int num)
        {
            return num * num;
        }

        public int addionation(int num)
        {
            return num + num;
        }
    }
}
