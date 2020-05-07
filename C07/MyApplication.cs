using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using MyANamespace;
using MyBNamespace;

namespace C07_ID04P03
{  
    class MyApplication
    {
        public void Run()
        {
            Main06();
            MyUtility.MyPause("Od poniedziałku do lasu ...");
        }
        private void Main01()
        {
            MyA myA = new MyA(MyUtility.ReadInt("x1 ?= "), MyUtility.ReadInt("x0 ?= "));
            Console.WriteLine(myA.MyString());
            Console.WriteLine(myA.AllString());
        }
        private void Main02()
        {
            MyA a1 = new MyA(2, 3);
            MyA a0 = new MyA(5, 6);
            MyB b1 = new MyB(a1, a0);
            Console.WriteLine(b1.MyString());
            Console.WriteLine(b1.AllString());
        }
        private void Main03()
        {
            MyA a1 = new MyA(2, 3);
            MyA a0 = new MyA(5, 6);
            MyB b1 = new MyB(a1.Copy(), a0.Copy());
            MyB b0 = new MyB(a1.Copy(), a0.Copy());
            Console.WriteLine("b1: " + b1.MyString());
            Console.WriteLine("b0: " + b0.MyString());
            b1.x1.x1 = 123;
            Console.WriteLine("b1: " + b1.MyString());
            Console.WriteLine("b0: " + b0.MyString());
        }
        private void Main04()
        {
            MyB b1 = new MyB(new MyA(2, 3), new MyA(5, 6));
            MyB b0 = new MyB(new MyA(2, 3), new MyA(5, 6));
            Console.WriteLine("b1: " + b1.MyString());
            Console.WriteLine("b0: " + b0.MyString());
            b1.x1.x1 = 123;
            Console.WriteLine("b1: " + b1.MyString());
            Console.WriteLine("b0: " + b0.MyString());
        }
        private void Main05()
        {
            MyB b1 = new MyB(new MyA(2, 3), new MyA(5, 6));
            MyB b0 = b1.Copy();
            Console.WriteLine("b1: " + b1.MyString());
            Console.WriteLine("b0: " + b0.MyString());
            b1.x1.x1 = 123;
            Console.WriteLine("b1: " + b1.MyString());
            Console.WriteLine("b0: " + b0.MyString());
        }
        private void Main06()
        {
            MyA a1 = new MyA(MyUtility.ReadInt("x1 ?= "), MyUtility.ReadInt("x0 ?= "));
            MyA a0 = new MyA(MyUtility.ReadInt("x1 ?= "), MyUtility.ReadInt("x0 ?= "));

            if (a1 < a0) Console.WriteLine(a1.MyString() + " < " + a0.MyString());
            if (a1 > a0) Console.WriteLine(a1.MyString() + " > " + a0.MyString());
        }
    }
}
