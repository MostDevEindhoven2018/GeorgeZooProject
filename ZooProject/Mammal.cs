using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Mammal : Animal
    {
        protected int TailLength { get; set; }
        public int ChildrenInWomb { get; set; }

        public Mammal(bool Alive, int CageNr, int Weight, int tailLength, int ChildrenNr)
            :base(Alive, CageNr, Weight)
        {
            TailLength = tailLength;
            ChildrenInWomb = ChildrenInWomb;
        }

        public virtual string GiveBirthToBaby()
        {
            return "A very beautiful mammal baby!";
        }

        public virtual int Run()
        {
            return 5;
        }

        public override string ToString()
        {
            return base.ToString() + " Specifically a mammal.";
        }
    }
}
