using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using FiguresStatNamespace;

namespace C04_ID04P03
{
    class MyApplication
    {
        public void Run()
        {
            Main01();
            MyUtility.MyPause("Koronazajęcia ... ");
        }
        private void Main01()
        {
            int x = MyUtility.ReadInt();
            FiguresStat.TriangleDL(x);
            FiguresStat.TriangleIL(x);
            FiguresStat.TriangleDR(x);
            FiguresStat.TriangleIR(x);
        }
    }
}
