using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;

namespace C02_ID04P03
{
    class MyApplication
    {
        public void Run()
        {
            Main02();
            MyUtility.MyPause("No good deed will go unpunished ...");
        }
        private void Main01()
        {
            Console.WriteLine("x = {0}",MyUtility.ReadInt());
            Console.WriteLine("rnd = {0}", MyUtility.myFate.Next(10, 21));
        }
        private void Main02()
        {
            int[] myT1;
            myT1 = new int[20];
            int s;
            int e;
            for (int i = 0; i < myT1.Length; ++i)
            {
                myT1[i] = MyUtility.myFate.Next(0, 21);
            }
            for (int i = 0; i < myT1.Length; ++i)
            {
                Console.WriteLine("T[{0,2}] = {1,2}",  i, myT1[i]);
            }
            Console.WriteLine("Distance = {0}, s = {1}, e = {2}", Distance(myT1,out s,out e),s,e);
        }

        private int Distance(int[] myT,out int s,out  int e)
        {
            s = e = 0;
            for (int i = 1; i < myT.Length; ++i)
            {
                if (myT[s] < myT[i]) s = i;
                if (myT[s] == myT[i]) e = i;
            }
            return e - s;
        }

    }
}
