using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string name, string animalType, double weight, string livingRegion) :
            base(name, animalType, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("*squeal*");
        }

        public override bool Eat(Food food)
        {
            if (!(food is Vegetable))
            {
                Console.WriteLine("Mice do not eat that type of food!");
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
