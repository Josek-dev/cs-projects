using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
using AnimalNamespace;

namespace C10_ID04P03
{  
    class MyApplication
    {
        public void Run()
        {
            Main03();
            MyUtility.MyPause("I'm programming in the rain ...\nI'm happy again ...");
        }
        private void Main01()
        {
            Animal an1 = new Dinosaur(6, 16, "male", 55);
            Animal an2 = new Rabbit(2, 6, "female", 25);
            Console.WriteLine(an1.Test());
            Console.WriteLine(an2.Test());
        }
        private void Main02()
        {
            Animal an1 = new Dinosaur(6, 16, "male", 55);
            Animal an2 = new Rabbit(2, 6, "female", 25);
            Console.WriteLine((an1 as Dinosaur).Voice());
            Console.WriteLine((an2 as Rabbit).Voice());
        }
        private void Main03()
        {
            Animal an1 = new Dinosaur(6, 16, "male", 55);
            Animal an2 = new Rabbit(2, 6, "female", 25);
            Console.WriteLine(an1.Voice());
            Console.WriteLine(an2.Voice());
            Animal cn1, cn2;
            cn1 = an1.Copy();
            cn2 = an2.Copy();
            Console.WriteLine(cn1);
            Console.WriteLine(cn2);
            Rabbit bn2 = (Rabbit)an2.Copy();
        }
    }
}
