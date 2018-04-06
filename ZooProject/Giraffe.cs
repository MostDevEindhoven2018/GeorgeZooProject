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

        public Giraffe(bool a, int c, int w, int t, int ch, double n)
            : base(a, c, w, t, ch)
        {
            NeckLength = n;
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
    }
}
