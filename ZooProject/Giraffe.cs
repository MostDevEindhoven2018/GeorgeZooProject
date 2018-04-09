using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Giraffe : Mammal
    {
        public double NeckLength { get; set; }

        public Giraffe(bool Alive, int CageNr, int Weight, int TailLength, int ChildrenNr, double NeckLenth)
            : base(Alive, CageNr, Weight, TailLength, ChildrenNr)
        {
            NeckLength = NeckLenth;
        }

        public override string MakeSound()
        {
            return "*Giraffe's sound*";
        }

        public override string ToString()
        {
            return base.ToString() + " More specifically, a giraffe!";
        }

        public override string GiveBirthToBaby()
        {
            return base.GiveBirthToBaby() + " A giraffe's baby!!";
        }

        public override int Run()
        {
            return base.Run() + 10;
        }

        public void EatGrass()
        {
            if (RemainingFood > 0)
            {
                this.RemainingFood--;
                Console.WriteLine("Giraffe has eaten. Food remaining: " + RemainingFood);
            }
            else
            {
                Alive = false;
                Console.WriteLine("No more food, giraffe died. Long Live Giraffe.");
            }
        }
    }
}
