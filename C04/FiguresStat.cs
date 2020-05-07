using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresStatNamespace
{
    class FiguresStat
    {
        public static void Line(int x, string myStr = " *")
        {
            for (int i = 0; i < x; Console.Write(myStr), ++i);
        }
        public static void TriangleDL(int x)
        {
            for (int i = 0; i < x;Line(x-i),Console.WriteLine(), ++i) ;
        }
        public static void TriangleIL(int x)
        {
            for (int i = 1; i <= x; Line(i), Console.WriteLine(), ++i) ;
        }
        public static void TriangleDR(int x)
        {
            for (int i = 0; i < x; Line(x - i), Console.WriteLine(), ++i)
                Line(i,"  ");
        }
        public static void TriangleIR(int x)
        {
            for (int i = 1; i <= x; Line(i), Console.WriteLine(), ++i)
                Line(x-i,"  ");
        }

    }
}
/*

Method: TriangleDL(x)

x ?= 5

* * * * *
* * * *
* * *
* *
*

Method: TriangleIL(x)

x ?= 5

*
* *
* * *
* * * *
* * * * *
Method: TriangleDR(x)

x ?= 5

* * * * *
  * * * *
    * * *
      * *
        *

Method: TriangleIR(x)

x ?= 5

        *
      * *
    * * *
  * * * *
* * * * *



*/
