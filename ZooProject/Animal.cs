using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    public class Animal
    {
        protected bool Alive { get; set; }
        public int CageNr { get; set; }
        public int Weight { get; set; }
        public int RemainingFood { get; set; }

        public Animal()
        {

        }

        public Animal(bool alive, int cageNr, int weight)
        {
            Alive = alive;
            CageNr = cageNr;
            Weight = weight;
            RemainingFood = 2;
        }
        
        public virtual string MakeSound()
        {
            return "Be more specific.";
        }

        protected bool Eat()
        {
            if (RemainingFood > 0)
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
