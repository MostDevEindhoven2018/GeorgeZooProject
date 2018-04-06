using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    public class Animal
    {
        public bool alive { get; set; }
        public int cageNr { get; set; }
        public int weight { get; set; }
        public int remainingFood { get; set; }

        public Animal()
        {

        }

        public Animal(bool a, int c, int w)
        {
            alive = a;
            cageNr = c;
            weight = w;
            remainingFood = 10;
        }
        
        public virtual string MakeSound()
        {
            return "Be more specific.";
        }

        protected bool Eat()
        {
            if (remainingFood > 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Just an animal.";
        }
    }
}
