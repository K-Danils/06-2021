using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Odometer
    {
        int mileage;
        int startingMileage;
        const int maxMileage = 999999;
        const int consumption = 10;
        public FuelGauge fuelGauge;

        public Odometer(int fuel, int mileage)
        {
            this.mileage = mileage;
            startingMileage = mileage;
            fuelGauge = new FuelGauge(fuel);
        }

        public void ShowMileage()
        {
            Console.WriteLine(mileage);
        }

        public void IncreaseMileage()
        {
            if (mileage == maxMileage)
            {
                mileage = 0;
            }
            else
            {
                mileage++;
            }

            if (mileage - startingMileage >= consumption)
            {
                fuelGauge.DecreaseFuel();
                startingMileage = mileage;
            }
        }
    }
}
