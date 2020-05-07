using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyANamespace;

namespace MyBNamespace
{
    class MyB:MyA
    {
        public MyB(int x1, int x0, int bx1, int bx0):base(x1, x0)
        {
            this.x1 = bx1;
            this.x0 = bx0;
        }
        public override MyA Copy()
        {
            return new MyB(base.X1, base.X0, x1, x0);
        }
        public override int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public override int X0
        {
            get { return x0; }
            set { x0 = value; }
        }
        public override string ToString()
        {
            return base.ToString() + ", " + x1 + ", " + x0;
        }
        
        private int x1;
        private int x0;
    }
}
//9, 8, 7, 6