using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string name, string animalType, double weight, string livingRegion) : 
            base(name, animalType, weight)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get => _livingRegion; set => _livingRegion = value; }
    }
}
