using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyANamespace;

namespace MyCNamespace
{
    class MyC:MyA
    {
        public MyC(int x1, int x0, int cx0):base(x1, x0)
        {            
            this.x0 = cx0;
        }
        public override MyA Copy()
        {
            return new MyC(base.X1, base.X0, x0);
        }
        public override int X0
        {
            get { return x0; }
            set { x0 = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ", "  + x0;
        }
        private int x0;
    }
}
