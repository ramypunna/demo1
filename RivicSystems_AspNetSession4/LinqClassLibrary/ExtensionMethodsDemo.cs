using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqClassLibrary
{
    public static class ExtensionMethodsDemo
    {
        public static string WishMe(this string txt)
        {
            return "Hey, Welcome to Rivic systems: " + txt;
        }

        public static double GetTipAmount(this double amount)
        {
            return amount * 0.15;
        }
    }
}
