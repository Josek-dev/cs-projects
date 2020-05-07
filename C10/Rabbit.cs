using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNamespace
{
    class Rabbit:Animal
    {
        public Rabbit(int age, double weight, string sex, double earLength) 
            :base(age, weight, sex)
        {
            this.earLength = earLength;
        }
        public Rabbit(Rabbit Bugs)
            : base(Bugs.age, Bugs.weight, Bugs.sex)
        {
            this.earLength = Bugs.earLength;
        }
        public override Animal Copy()
        {
            return new Rabbit(this);
        }
        public override string ToString()
        {
            return base.ToString() + "\nlength of ear: " + earLength + " cm";
        }
        public override string Test()
        {
            return "Rabbit";
        }
        public override string Voice()
        {
            return "Kic, kic i kici kici ...";
        }


        double earLength;
    }
}
