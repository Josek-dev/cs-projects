using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilityNamespace
{
    delegate int MyEx(int x, int y);
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
        public static int MaxInt(int x, int y)
        {
            if (x > y) return x;
            return y;
        }
        public static int MinInt(int x, int y)
        {
            if (x < y) return x;
            return y;
        }
        public static int Extr(int x, int y, MyEx mX)
        {
            return mX(x, y);
        }
        public static MyEx MyMax = new MyEx(MaxInt);
        public static MyEx MyMin = new MyEx(MinInt);
        public static Random myFate = new Random();
    }
}
