using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fuel = 20;
            Odometer odometer = new Odometer(fuel, 100);

            while (odometer.fuelGauge.ShowFuel() > 0)
            {
                odometer.IncreaseMileage();

                Console.Write("Mileage: ");
                odometer.ShowMileage();

                Console.Write("Fuel: ");
                odometer.fuelGauge.ShowFuel();
            }

            Console.ReadKey();
        }
    }
}
