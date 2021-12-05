using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            var cars = array.ToList();
            cars.ForEach(car => Console.WriteLine(car));

            var carsHash = array.ToHashSet();
            Console.WriteLine(String.Join(",", carsHash));

            var carsDictionary = new Dictionary<string, string>
            {
                { "Audi", "Germany" },
                {"BMW", "Germany"},
                {"Honda", "Japan"},
                {"Mercedes", "Germany"},
                {"Volkswagen", "Germany"},
                {"Tesla", "USA"},
            };

            foreach (KeyValuePair<string, string> car in carsDictionary)
            {
                Console.WriteLine(car.Key + " " + car.Value);
            }

            Console.ReadKey();
        }
    }
}
