using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;

namespace C03_ID04P03
{
    class MyApplication
    {
        public void Run()
        {
            Main04();
            MyUtility.MyPause("Życie jest ciężkie, a potem się umiera ...");
        }
        private void Main01()
        {
            int x = 3, y = 7;
            Console.WriteLine("x = {0}, y = {1}",x,y);
            MyUtility.SwapInt(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
        private void Main02()
        {
            int[,] myT;
            myT = new int[MyUtility.myFate.Next(5,11), MyUtility.myFate.Next(5, 11)];

            for (int i = 0; i < myT.GetLength(0); ++i)
                for (int j = 0; j < myT.GetLength(1); ++j)
                    myT[i, j] = MyUtility.myFate.Next(0, 100);

            for (int i = 0; i < myT.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < myT.GetLength(1); ++j)
                    Console.Write("[{0,2}]",myT[i,j]);
            Console.WriteLine("----------------------------------------------------------");
            for (int j = 0; j < myT.GetLength(1); ++j, Console.WriteLine())
                for (int i = 0; i < myT.GetLength(0); ++i)
                    Console.Write("[{0,2}]", myT[i, j]);
        }
        private void Main03()
        {
            int[][] myT;

            myT = new int[MyUtility.myFate.Next(11,16)][];

            int s = MyUtility.myFate.Next(5, 11);

            for (int i = 0; i < myT.Length; ++i)
                myT[i] = new int[s];

            for (int i = 0; i < myT.Length; ++i)
                for (int j = 0; j < s; ++j)
                    myT[i][j] = MyUtility.myFate.Next(0, 100);

            for (int i = 0; i < myT.Length; ++i, Console.WriteLine())
                for (int j = 0; j <s ; ++j)
                    Console.Write("[{0,2}]", myT[i][j]);
        }
        private void Main04()
        {
            int[][] myT;

            myT = new int[MyUtility.myFate.Next(11, 16)][];

            myT[0] =new int[MyUtility.myFate.Next(5, 11)];

            for (int i = 1; i < myT.Length; ++i)
                myT[i] = new int[myT[0].Length];

            for (int i = 0; i < myT.Length; ++i)
                for (int j = 0; j < myT[i].Length; ++j)
                    myT[i][j] = MyUtility.myFate.Next(0, 100);

            for (int i = 0; i < myT.Length; ++i, Console.WriteLine())
                for (int j = 0; j < myT[i].Length; ++j)
                    Console.Write("[{0,2}]", myT[i][j]);
        }
    }
}
//5, 4, 3, 2, 1