using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyANamespace;

namespace MyBNamespace
{
    class MyB
    {
        public MyB(MyA x1, MyA x0)
        {
            this.x1 = x1;
            this.x0 = x0;
        }
        public MyB(MyB myB)
        {
            this.x1 = myB.x1.Copy();
            this.x0 = myB.x0.Copy();
        }
        public MyB Copy()
        {
            return new MyB(this);
        }
        public string MyString()
        {
            return "[" + x1.MyString() + ", " + x0.MyString() + "]";
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
        public static bool operator <(MyB a1, MyB a0)
        {
            if (a1.x1 > a0.x1) return false;
            if (a1.x1 < a0.x1) return true;
            if (a1.x0 < a0.x0) return true;
            return false;
        }
        public static bool operator >(MyB a1, MyB a0)
        {
            if (a1.x1 < a0.x1) return false;
            if (a1.x1 > a0.x1) return true;
            if (a1.x0 > a0.x0) return true;
            return false;
        }
        private int CrC()
        {
            return 4 * x1.CRC + x0.CRC;
        }

        private void SetCrC()
        {
            cRc = CrC();
        }

        public MyA x1;
        public MyA x0;

        private int cRc;
    }
}
