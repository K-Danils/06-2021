using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Tiger : Felime
    {
        public Tiger(string name, string animalType, double weight, string livingRegion) :
           base(name, animalType, weight, livingRegion)
        {
            LivingRegion = livingRegion;
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAR");
        }

        public override bool Eat(Food food)
        {
            if (!(food is Meat))
            {
                Console.WriteLine("Tigers do not eat that type of food!");
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
