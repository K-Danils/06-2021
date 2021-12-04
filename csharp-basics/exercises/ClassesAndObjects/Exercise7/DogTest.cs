using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class DogTest
    {
        public DogTest()
        {
            Dog max = new Dog("Max", "male", "Lady", "Rocky");
            Dog rocky = new Dog("Rocky", "male", "Molly", "Sam");
            Dog coco = new Dog("Coco", "female", "Molly", "Buster");
            Dog buster = new Dog("Buster", "male", "Lady", "Sparky");
            Dog sparky = new Dog("Sparky", "male");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");

            Console.WriteLine(coco.FathersName());
            Console.WriteLine(sparky.FathersName());
            Console.WriteLine(coco.HasSameMotherAs(rocky));

            Console.ReadKey();
        }
    }
}
