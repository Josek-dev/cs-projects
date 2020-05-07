using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyANamespace;

namespace MyBNamespace
{
    class MyB: MyA
    {
        public MyB(int x1, int x0):base(x1, x0)
        {
            this.x2 = x1 + x0;
            this.x1 = x1 - x0;
            this.x0 = x0 - x1;
        }
        public MyB(MyB myB):base(myB.AX1, myB.AX0)
        {
            this.x2 = myB.X1 + myB.X0;
            this.x1 = myB.X1 - myB.X0;
            this.x0 = myB.X0 - myB.X1;
        }
        public MyB Copy()
        {
            //return new MyB(base.X1, base.X0);
            return new MyB(this);
        }
        public int X2
        {
            get { return x2; }
            set
            {
                this.x2 = value;
                base.X1 = this.x2 - base.X0;
                this.x1 = base.X1 - base.X0;
                this.x0 = base.X0 - base.X1;
            }
        }
        public new int X1
        {
            get { return x1; }
            set
            {
                this.x1 = value;
                base.X1 = this.x1 + base.X0;
                this.x2 = base.X1 + base.X0;
                this.x0 = base.X0 - base.X1;
            }
        }
        public new int X0
        {
            get { return x0; }
            set
            {
                this.x0 = value;
                base.X0 = this.x0 + base.X1;
                this.x1 = base.X1 - base.X0;
                this.x2 = base.X0 + base.X1;
            }
        }
        protected int AX1
        {
            get { return base.X1; }
        }
        protected int AX0
        {
            get { return base.X0; }
        }

        public new string MyString()
        {
            return x2 + ", " + x1 + ", " + x0 + ", " + base.MyString();
        }

        private int x2;
        private int x1;
        private int x0;
    }
}
//5, 4, 3