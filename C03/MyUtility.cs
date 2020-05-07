using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilityNamespace
{
    class MyUtility
    {
        public static void MyPause(string myStr = "")
        {
            Console.WriteLine(myStr);
            Console.ReadKey();
        }

        public static int ReadInt(string myStr="x ?= ")
        {
            Console.Write(myStr);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void SwapInt(ref int x, ref int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
        }

        public static Random myFate = new Random();
    }
}
