using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
             Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
             Console.WriteLine("Approximately "
                 + CalculateEnergyDrinkers(NumberedSurveyed, PurchasedEnergyDrinks) 
                 + " bought at least one energy drink");

             Console.WriteLine(CalculatePreferCitrus(NumberedSurveyed, PurchasedEnergyDrinks, PreferCitrusDrinks)
                 + " of those " + "prefer citrus flavored energy drinks.");

            Console.ReadKey();
        }

        static double CalculateEnergyDrinkers(int numberSurveyed, double purchasedEnergyDrinks)
        {
            return Math.Floor(numberSurveyed * purchasedEnergyDrinks);
        }

        static double CalculatePreferCitrus(int numberSurveyed, double purchasedEnergyDrinks, double preferCitrusDrinks)
        {
            return Math.Floor((numberSurveyed * purchasedEnergyDrinks) * preferCitrusDrinks);
        }
    }
}
