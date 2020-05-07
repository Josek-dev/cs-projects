using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyANamespace
{
    class MyA
    {
        public MyA(int x1, int x0)
        {
            this.x1 = x1;
            this.x0 = x0;
        }
        public MyA(MyA myA)
        {
            this.x1 = myA.x1;
            this.x0 = myA.x0;
        }
        public MyA Copy()
        {
            return new MyA(this);
        }
        public string MyString()
        {
            return "(" + x1 + ", " + x0 + ")";
        }
        public string AllString()
        {
            return MyString() + " -> " + CRC;
        }
        public int CRC
        {
            get
            {
                SetCrC();
                return cRc;
            }
        }
        public static bool operator <(MyA a1, MyA a0)
        {
            if (a1.x1 > a0.x1) return false;
            if (a1.x1 < a0.x1) return true;
            if (a1.x0 < a0.x0) return true;
            return false;
        }
        public static bool operator >(MyA a1, MyA a0)
        {
            if (a1.x1 < a0.x1) return false;
            if (a1.x1 > a0.x1) return true;
            if (a1.x0 > a0.x0) return true;
            return false;
        }
        private int CrC()
        {
            return 2 * (x1 % 2) + x0 % 2;
        }
        private void SetCrC()
        {
            cRc = CrC();
        }

        public int x1;
        public int x0;

        private int cRc;
    }
}
