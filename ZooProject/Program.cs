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
            animalList.Add(new Mammal(false, 5, 55, 38, 2));
            animalList.Add(new Bear(true, 10, 300, 4, 3, 12.3, "George."));
            animalList.Add(new Giraffe(true, 2, 435, 45, 1, 7.3));

            foreach (Animal a in animalList)
            {
                if (a.GetType() == typeof(Mammal))
                {
                    Console.WriteLine("----------");

                    Mammal m = (Mammal)a;
                    Console.WriteLine(m.ToString());
                    Console.WriteLine("This mammal has " + m.ChildrenInWomb + " children.");     
                    Console.Write(Environment.NewLine);               
                }

                if (a.GetType() == typeof(Bear))
                {
                    Console.Write(Environment.NewLine);
                    Bear b = (Bear)a;
                    Console.WriteLine(b.ToString());
                    Console.WriteLine("Bear is asking to eat. Write 'y' for yes or 'n' for no.");
                    if (Console.ReadKey(true).Key == ConsoleKey.Y)
                    {
                        b.EatMeat();
                    }
                    if (Console.ReadKey(true).Key == ConsoleKey.N)
                    {
                        Console.WriteLine("You heartless bear murderer!!");
                    }
                    b.EatMeat();
                    b.EatMeat();
                    b.EatMeat();
                }
            }

            Console.ReadKey();
        }
    }
}
