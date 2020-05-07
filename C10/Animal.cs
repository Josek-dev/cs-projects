using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNamespace
{
    class Animal
    {
        public Animal(int age, double weight, string sex)
        {
            this.age = age;
            this.weight = weight;
            this.sex = sex;
        }
        public Animal(Animal an)
        {
            this.age = an.age;
            this.weight = an.weight;
            this.sex = an.sex;
        }

        public virtual Animal Copy()
        {
            return new Animal(this);
        }

        public override string ToString()
        {
            return "age: "+age + " years\nweight: "+ weight + " kg\n" + sex;
        }
        public virtual string Test()
        {
            return "Animal";
        }

        public virtual string Voice()
        {
            return "Silence";
        }


        protected int age;
        protected double weight;
        protected string sex;
    }
}
