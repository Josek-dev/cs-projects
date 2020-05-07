using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using MyANamespace;
using MyBNamespace;
using MyCNamespace;

namespace C09_ID04P03
{  
    class MyApplication
    {
        public void Run()
        {
            Main03();
            MyUtility.MyPause("Dobrze wstać ? skoro świt :(");
        }
        private void Main01()
        {
            MyA mB = new MyB(1, 2, 3, 4);
            MyA mC = new MyC(1, 2, 3);
            Console.WriteLine("mB: ({0})", mB.ToString());
            Console.WriteLine("mB: ({0})", mB);
            Console.WriteLine("mC: ({0})", mC);
        }
        private void Main02()
        {
            MyA mB = new MyB(1, 2, 3, 4);
            MyA mC = mB.Copy();
            
            Console.WriteLine("mB: ({0})", mB);
            Console.WriteLine("mC: ({0})", mC);
            mC.X1 = 123;
            Console.WriteLine("mB: ({0})", mB);
            Console.WriteLine("mC: ({0})", mC);
        }
        private void Main03()
        {
            MyA mB = new MyB(1, 2, 3, 4);
            MyA mC = new MyC(11,12,13);
            MyA mX;
            for (int i = 0; i < 10; ++i)
            {
                if (MyUtility.myFate.Next(0, 2) == 0)
                    mX = mB.Copy();
                else
                    mX = mC.Copy();
                Console.WriteLine("mX: ({0})", mX);
            }
        }
    }
}
