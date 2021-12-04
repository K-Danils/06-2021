using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class FuelGauge
    {
        int liters;
        int maxLiters = 70;

        public FuelGauge(int liters)
        {
            this.liters = liters;
        }

        public int ShowFuel()
        {
            Console.WriteLine(liters);
            return liters;
        }

        public void IncreaseFuel()
        {
            if (liters < maxLiters)
            {
                liters++;
            }
        }

        public void DecreaseFuel()
        {
            if (liters > 0)
            {
                liters--;
            }
        }
    }
}
