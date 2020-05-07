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
            SetCrC();
        }
        public MyA(MyA myA)
        {
            this.x1 = myA.x1;
            this.x0 = myA.x0;
            SetCrC();
        }
        public MyA Copy()
        {
            return new MyA(this);
        }
        public string MyString()
        {
            return "(" + X1 + ", " + X0 + ") -> " + CRC;
        }
        public int X1
        {
            get
            {
                return x1;
            }
            set
            {
                x1 = value;
                SetCrC();
            }
        }
        public int X0
        {
            get
            {
                return x0;
            }
            set
            {
                x0 = value;
                SetCrC();
            }
        }
        public int CRC
        {
            get
            {
                return cRc;
            }
        }
        private int CrC()
        {
            return 2 * (x1 % 2) + x0 % 2;
        }
        private void SetCrC()
        {
            cRc = CrC();
        }

        private int x1;
        private int x0;

        private int cRc;
    }
}
//8, 6, 4, 2, 1