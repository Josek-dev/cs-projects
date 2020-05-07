using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFiguresStatNamespace
{
    delegate void AllTr(int x);
    class MyFiguresStat
    {
        public static void Line(int x, string myStr = " *")
        {
            for (int i = 0; i < x; ++i)
                Console.Write(myStr);
        }
        public static void TriangleDL(int x)
        {
            for (int i = 0; i < x; ++i, Console.WriteLine())
                Line(x - i);
        }
        public static void TriangleIL(int x)
        {
            for (int i = 1; i < x+1; ++i, Console.WriteLine())
                Line(i);
        }
        public static void TriangleDR(int x)
        {
            for (int i = 0; i < x; Line(x - i), Console.WriteLine(),++i)
                Line(i,"  ");
        }
        public static void TriangleIR(int x)
        {
            for (int i = 0; i < x; ++i, Line(i), Console.WriteLine())
                Line(x-i,"  ");
        }
        public static void SawInc(int x, AllTr tr)
        {
            for(int i=0;i< x;++i)
                tr(x+i);
        }
        public static AllTr IL = new AllTr(TriangleIL);
        public static AllTr IR = new AllTr(TriangleIR);
        public static AllTr DL = new AllTr(TriangleDL);
        public static AllTr DR = new AllTr(TriangleDR);
    }
}
/*
Funkcja: SawInc(x, DelTriangleIL);

x ?= 4
*
* *
* * *
*
* *
* * *
* * * *
*
* *
* * *
* * * *
* * * * *
*
* *
* * *
* * * *
* * * * *
* * * * * *

*/
//4