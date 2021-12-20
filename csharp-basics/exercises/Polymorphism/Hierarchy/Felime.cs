using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Felime : Mammal
    {
        public Felime(string name, string animalType, double weight, string livingRegion) :
            base(name, animalType, weight, livingRegion)
        {
        }
    }
}
