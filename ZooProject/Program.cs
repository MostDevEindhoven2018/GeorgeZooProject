using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Animal(true, 12, 200));
            animalList.Add(new Mammal(false, 5, 55, 38, 0));
            animalList.Add(new Bear(true, 10, 300, 4, 3, 12.3, "George."));
            animalList.Add(new Giraffe(true, 2, 435, 45, 1, 7.3));

            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.ToString());
                if (a.GetType() == typeof(Mammal))
                {
                    Console.WriteLine("----------");

                    Mammal m = (Mammal) a;
                    Console.WriteLine("This mammal has " + m.childrenInWomb + " children.");                    
                }
            }

            Console.WriteLine(string.Join("-", 10));

            Console.ReadKey();
        }
    }
}
