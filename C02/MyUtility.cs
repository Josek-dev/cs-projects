using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilityNamespace
{
    class MyUtility
    {
        public static void MyPause(string myStr="")
        {
            Console.Write(myStr);
            Console.ReadKey();
        }
        public static int ReadInt(string myStr = "x ?= ")
        {
            Console.Write(myStr);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static Random myFate = new Random();
    }
}
