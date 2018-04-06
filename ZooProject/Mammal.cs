using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Mammal : Animal
    {
        protected int tailLength { get; set; }
        public int childrenInWomb { get; set; }

        public Mammal(bool a, int c, int w, int t, int ch)
        {
            tailLength = t;
            childrenInWomb = ch;
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
