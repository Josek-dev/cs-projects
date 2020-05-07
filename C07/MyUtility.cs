using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilityNamespace
{
    delegate int MxTR(int x, int y);
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
        public static int MxInt(int x, int y)
        {
            if (x > y) return x;
            return y;
        }
        public static int MnInt(int x, int y)
        {
            if (x < y) return x;
            return y;
        }
        public static int Extr(int x, int y, MxTR mTr)
        {
            return mTr(x, y);
        }
        public static MxTR MaxInt = new MxTR(MxInt);
        public static MxTR MinInt = new MxTR(MnInt);

        public static Random myFate = new Random();
    }
}
