using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_ID04P03
{
    class MyApplication
    {
        public void Run()
        {
            Main06();
            Console.WriteLine("T H E   E N D.\nPress any key but POWER or RESET !!!");
            Console.ReadKey();            
        }
        private void Main01()
        {
            int x = 8;
            Console.WriteLine(x);
        }
        private void Main02()
        {
            int x;
            string myStr;
            Console.Write("x ?= ");
            myStr = Console.ReadLine();
            Console.WriteLine(myStr);

            x = Convert.ToInt32(myStr);
            Console.WriteLine(x);
        }
        private void Main03()
        {
            int x;            
            Console.Write("x ?= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = " + x);
        }
        private void Main04()
        {
            int x, y;
            Console.Write("x ?= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y ?= ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + y);
            Console.WriteLine(x + y.ToString());
            Console.WriteLine(x + y + "qq");
        }
        private void Main05()
        {
            int x, y;
            Console.Write("x ?= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y ?= ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = {0}, y ={1}", x, y);
            Console.WriteLine("x = {1}, y ={0}", y, x);
        }
        private void Main06()
        {
            int x;
            Console.Write("x ?= ");
            x = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<x;i+=23)
                Console.WriteLine("i = {0,3}", i);
        }
    }
}
