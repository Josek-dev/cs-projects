using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using MyANamespace;

namespace C06_ID04P03
{
    class MyApplication
    {
        public void Run()
        {
            Main03();
            MyUtility.MyPause("Puk, puk ...\nKto tam ?\nTo ja wirus - szukam towarzystwa ...");
        }
        private void Main01()
        {
            MyA myA01;
            myA01 = new MyA(MyUtility.ReadInt("x1 ?= "), MyUtility.ReadInt("x0 ?= "));
            Console.WriteLine("myA01={0}",myA01.MyString());
            Console.WriteLine("x1 = {0}", myA01.X1);
            myA01.X1 = 4;
            Console.WriteLine("myA01={0}", myA01.MyString());
        }
        private void Main02()
        {
            MyA myA01, myA02;
            myA01 = new MyA(MyUtility.ReadInt("x1 ?= "), MyUtility.ReadInt("x0 ?= "));
            myA02 = myA01.Copy();
            Console.WriteLine("myA01={0}", myA01.MyString());
            Console.WriteLine("myA02={0}", myA02.MyString());
            myA02.X1 = 4;
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("myA01={0}", myA01.MyString());
            Console.WriteLine("myA02={0}", myA02.MyString());
        }
        private void Main03()
        {
            MyA[] mT = new MyA[20];
            for (int i = 0; i < mT.Length; ++i)
                if (0 == MyUtility.myFate.Next(0, 3))
                    mT[i] = new MyA(MyUtility.myFate.Next(10, 51),
                                    MyUtility.myFate.Next(10, 51));
            else
                mT[i] = new MyA(MyUtility.myFate.Next(51, 100),
                                MyUtility.myFate.Next(51, 100));
            for (int i = 0; i < mT.Length; ++i)
                Console.WriteLine("mT[{0}] = {1}",i, mT[i].MyString());
        }
    }
}

/*
p = 1/3   - [10, 50]
p = 2/3   - [51, 99]


8, 6, 4, 3, 2

*/
