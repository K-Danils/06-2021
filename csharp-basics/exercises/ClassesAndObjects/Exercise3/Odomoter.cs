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
        int maxMileage = 999999;
        int consumption = 10;
        public FuelGauge fuelGauge;

        public Odometer(int fuel, int mileage)
        {
            this.mileage = mileage;
            startingMileage = mileage;
            fuelGauge = new FuelGauge(fuel);
        }

        public void ShowMileage()
        {
            Console.WriteLine(this.mileage);
        }

        public void IncreaseMileage()
        {
            if (this.mileage == this.maxMileage)
            {
                this.mileage = 0;
            }
            else
            {
                this.mileage++;
            }

            if (mileage - startingMileage >= consumption)
            {
                fuelGauge.DecreaseFuel();
                startingMileage = mileage;
            }
        }
    }
}
