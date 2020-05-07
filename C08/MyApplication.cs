using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using MyANamespace;
using MyBNamespace;

namespace C08_ID04P03
{  
    class MyApplication
    {
        public void Run()
        {
            Main02();
            MyUtility.MyPause("Repetitio mater studiorum est ...");
        }
        private void Main01()
        {
            MyB myA = new MyB(5, 4);
            Console.WriteLine("myA: ({0})",myA.MyString());
            myA.X2 = 11;
            Console.WriteLine("myA: ({0})", myA.MyString());
            myA.X1 = 10;
            Console.WriteLine("myA: ({0})", myA.MyString());
            myA.X0 = 21;
            Console.WriteLine("myA: ({0})", myA.MyString());
        }
        private void Main02()
        {
            MyB myA = new MyB(5, 4);
            MyB myB;
            MyB myC;
            myB = myA.Copy();
            Console.WriteLine("myA: ({0})", myA.MyString());
            Console.WriteLine("myB: ({0})", myB.MyString());
            myA.X2 = 11;
            Console.WriteLine("myA: ({0})", myA.MyString());
            Console.WriteLine("myB: ({0})", myB.MyString());
            myC = new MyB(myB);
            Console.WriteLine("myC: ({0})", myC.MyString());


        }
    }
}
