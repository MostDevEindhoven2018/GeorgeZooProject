using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Bear : Mammal
    {
        public double toothLength { get; set; }
        public string name { get; set; }

        public Bear(bool a, int c, int w, int t, int ch, double n, string na)
            : base(a, c, w, t, ch)
        {
            toothLength = n;
            name = na;
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
            return base.ToString() + " More specifically, a bear named " + name;
        }

        public override int Run()
        {
            return base.Run() + 5;
        }
    }
}
