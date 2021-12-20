using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Cat : Felime
    {
        private string _breed;
        public Cat(string name, string animalType, double weight, string breed, string livingRegion) :
           base(name, animalType, weight, livingRegion)
        {
            _breed = breed;
        }

        public string Breed { get => _breed;}

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public override bool Eat(Food food)
        {
            FoodEaten += food.Quantity;
            return true;
        }
    }
}
