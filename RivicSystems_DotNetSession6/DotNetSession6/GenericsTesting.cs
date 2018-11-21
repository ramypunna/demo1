using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLibrary
{
    public class GenericsTesting
    {
        public static void TestGenericsMethods()
        {
            bool retVal1 = AretheySameGenerics(2, 3);
            

            if (retVal1)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Not matching");

            bool retVal2 = AretheySameGenerics("Ramesh", "Ramesh");

            if (retVal2)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Not matching");

        }

        public static bool AretheySame(int v1, int v2)
        {
            if (v1== v2)
                return true;
            else
                return false;
        }

        public static bool AretheySameGenerics<T>(T v1, T v2)
        {
            if (v1.Equals(v2))
                return true;
            else
                return false;
        }
    }

}
