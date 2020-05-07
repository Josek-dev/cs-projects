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
        public string MyString()
        {
            return x1 + ", " + x0;
        }
        protected int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        protected int X0
        {
            get { return x0; }
            set { x0 = value; }
        }

        private int x1;
        private int x0;
    }
}
