using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Reptile : Animal
    {
        protected double length { get; set; }
        protected int nrOfEggs { get; set; }

        protected virtual string Move()
        {
            return "Crawling through grasssssss......";
        }
    }
}
