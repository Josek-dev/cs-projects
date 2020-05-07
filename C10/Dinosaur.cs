using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNamespace
{
    class Dinosaur:Animal
    {
        public Dinosaur(int age, double weight, string sex, double speed) 
            :base(age, weight, sex)
        {
            this.speed = speed;
        }
        public Dinosaur(Dinosaur dino)
            : base(dino.age, dino.weight, dino.sex)
        {
            this.speed = dino.speed;
        }

        public override Animal Copy()
        {
            return new Dinosaur(this);
        }
        public override string ToString()
        {
            return base.ToString() + "\nspeed: " + speed + " km/h";
        }
        public override string Test()
        {
            return "Dinosaur";
        }

        public override string Voice()
        {
            return "U ha ha hau ...";
        }

        double speed;
    }
}
