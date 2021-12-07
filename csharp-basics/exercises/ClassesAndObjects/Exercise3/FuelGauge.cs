using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class FuelGauge
    {
        private int _liters;
        const int maxLiters = 70;

        public FuelGauge(int liters)
        {
            _liters = liters;
        }

        public int ShowFuel()
        {
            Console.WriteLine(_liters);
            return _liters;
        }

        public void IncreaseFuel()
        {
            if (_liters < maxLiters)
            {
                _liters++;
            }
        }

        public void DecreaseFuel()
        {
            if (_liters > 0)
            {
                _liters--;
            }
        }
    }
}
