using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Zebra : Mammal
    {
        public Zebra(string name, string animalType, double weight, string livingRegion) :
           base(name, animalType, weight, livingRegion)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Woop woop woop");
        }

        public override bool Eat(Food food)
        {
            if (!(food is Vegetable))
            {
                Console.WriteLine("Zebras do not eat that type of food!");
                return false;
            }
            else
            {
                FoodEaten += food.Quantity;
                return true;
            }
        }
    }
}
