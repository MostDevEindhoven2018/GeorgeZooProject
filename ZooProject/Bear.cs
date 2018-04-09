using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Bear : Mammal, ICarnivore
    {
        public double ToothLength { get; set; }
        public string Name { get; set; }

        public Bear(bool Alive, int CageNr, int Weight, int TailLength, int ChildrenNr, double ToothLenth, string itsName)
            : base(Alive, CageNr, Weight, TailLength, ChildrenNr)
        {
            ToothLength = ToothLenth;
            Name = itsName;
        }

        public override string GiveBirthToBaby()
        {
            return base.GiveBirthToBaby() + " A bear's baby!";
        }

        public override string MakeSound()
        {
            return "GRRRRRR";
        }

        public override string ToString()
        {
            return base.ToString() + " More specifically, a bear named " + Name;
        }

        public void EatMeat()
        {
            if (RemainingFood > 0)
            {
                this.RemainingFood--;
                Console.WriteLine("Bear has eaten. Food remaining: " + RemainingFood);
            }
            else
            {
                Random rnd = new Random();
                int chance = rnd.Next(2);
                if (chance == 1)
                {
                    Console.WriteLine("Due to hunger, the bear used berZerker and killed a herbivore.");
                }
                else if (chance==0)
                {
                    this.Alive = false;
                    Console.WriteLine("Due to hunger and boredom, the bear died.");
                }
            }
        }

        public override int Run()
        {
            return base.Run() + 5;
        }
    }
}
