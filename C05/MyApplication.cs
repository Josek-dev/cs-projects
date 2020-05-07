using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using MyFiguresStatNamespace;
using MyFiguresNamespace;

namespace C05_ID04P03
{
    delegate void DelTest();
    delegate void DelTest02(int x);
    delegate int DelMax(int x, int y);
    delegate int DelMin(int x, int y);
    delegate int DelEx(int x, int y);
    class MyApplication
    {
        public void Run()
        {
            Main09();
            MyUtility.MyPause("Koronazajęcia ...");
        }
        private void Main01()
        {
            MyFigures mF = new MyFigures();
            mF.Test01();
            Console.WriteLine("<<<<<<<<<<<<<<---------------------->>>>>>>>>>>>>>>>>");
        }
        private void Main02()
        {
            DelTest dT = new DelTest((new MyFigures()).Test01);
            dT();
            Console.WriteLine("<<<<<<<<<<<<<<---------------------->>>>>>>>>>>>>>>>>");
            dT += (new MyFigures()).Test02;
            dT();
            Console.WriteLine("<<<<<<<<<<<<<<---------------------->>>>>>>>>>>>>>>>>");
            dT += (new MyFigures()).Test02;
            dT += (new MyFigures()).Test02;
            dT += (new MyFigures()).Test02;
            dT += (new MyFigures()).Test01;
            dT += (new MyFigures()).Test01;
            dT += (new MyFigures()).Test02;
            dT += (new MyFigures()).Test02;
            dT();
            Console.WriteLine("<<<<<<<<<<<<<<---------------------->>>>>>>>>>>>>>>>>");
        }
        private void Main03()
        {
            MyFigures mF = new MyFigures();
            DelTest dT = new DelTest(mF.Test01);
            dT += mF.Test02;
            dT += mF.Test02;
            dT += mF.Test02;
            dT += mF.Test02;
            dT += mF.Test01;
            dT += mF.Test01;
            dT += mF.Test02;
            dT += mF.Test02;
            dT();
            Console.WriteLine("<<<<<<<<<<<<<<---------------------->>>>>>>>>>>>>>>>>");
            dT -= mF.Test02;
            dT -= mF.Test02;
            dT -= mF.Test02;
            dT -= mF.Test02;
            dT -= mF.Test02;
            dT -= mF.Test02;
            dT -= mF.Test02;
            dT -= mF.Test02;
            dT -= mF.Test02;
            dT();
            Console.WriteLine("<<<<<<<<<<<<<<---------------------->>>>>>>>>>>>>>>>>");
        }
        private void Main04()
        {
            MyFigures mF = new MyFigures();
            DelTest02 dT = new DelTest02(mF.Test03);
            dT += mF.Test04;
            dT(5);
            Console.WriteLine("<<<<<<<<<<<<<<---------------------->>>>>>>>>>>>>>>>>");
        }
        private void Main05()
        {
            int x = MyUtility.ReadInt();
            int y = MyUtility.ReadInt("y ?= ");
            Console.WriteLine("Max({0}, {1}) = {2}", x, y, MyUtility.MaxInt(x, y));
            Console.WriteLine("Min({0}, {1}) = {2}", x, y, MyUtility.MinInt(x, y));
        }
        private void Main06()
        {
            DelMax dMx = new DelMax(MyUtility.MaxInt);
            DelMin dMn = new DelMin(MyUtility.MinInt);
            int x = MyUtility.ReadInt();
            int y = MyUtility.ReadInt("y ?= ");
            Console.WriteLine("Max({0}, {1}) = {2}", x, y, dMx(x, y));
            Console.WriteLine("Min({0}, {1}) = {2}", x, y, dMn(x, y));
        }
        private void Main07()
        {
            DelEx dMx = new DelEx(MyUtility.MaxInt);
            DelEx dMn = new DelEx(MyUtility.MinInt);
            int x = MyUtility.ReadInt();
            int y = MyUtility.ReadInt("y ?= ");
            Console.WriteLine("Max({0}, {1}) = {2}", x, y, dMx(x, y));
            Console.WriteLine("Min({0}, {1}) = {2}", x, y, dMn(x, y));
        }
        private void Main08()
        {
            int x = MyUtility.ReadInt();
            int y = MyUtility.ReadInt("y ?= ");
            Console.WriteLine("Max({0}, {1}) = {2}", x, y, MyUtility.Extr(x, y, MyUtility.MyMax));
            Console.WriteLine("Min({0}, {1}) = {2}", x, y, MyUtility.Extr(x, y, MyUtility.MyMin));
        }
        private void Main09()
        {
            int x = MyUtility.ReadInt();
            MyFiguresStat.SawInc(x, MyFiguresStat.IL);
        }
    }
}
