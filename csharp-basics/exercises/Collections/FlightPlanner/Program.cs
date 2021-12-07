using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = @"E:/codelex/CODELEX_UZDEVUMI/06-2021/csharp-basics/exercises/Collections/FlightPlanner/flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            var flights = new Dictionary<string, string>();
            var cities = new List<string>();
            string startingCity;
            string destination;

            ConvertFlightsToDictionary(readText, flights);

            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("To display list of cities press 1: ");
            Console.WriteLine("To exit program press #");

            bool runLoop = Console.ReadLine() == "1";

            ShowAllAvailableFlights(flights);

            Console.WriteLine();
            Console.Write("Input the city you wish to start from: ");

            startingCity = Console.ReadLine();

            Console.WriteLine("Available Cities: " + flights[startingCity].Remove(flights[startingCity].Length - 2));

            while (runLoop)
            {
                Console.WriteLine();
                Console.Write("Input the city you wish to go to: ");
                destination = Console.ReadLine();

                if (destination == startingCity) { break; }

                cities.Add(destination);
                Console.WriteLine("Available cities: " + flights[destination].Remove(flights[destination].Length - 2));
            }

            Console.WriteLine();
            Console.Write("Your flight route: " + startingCity + " -> ");

            cities.ForEach(city => Console.Write(city + " -> "));

            Console.Write(startingCity);
            Console.ReadKey();
        }

        private static void ConvertFlightsToDictionary(string[] readText, Dictionary<string, string> flights)
        {
            string startingCity;
            string destination;

            for (int i = 0; i < readText.Length; i++)
            {
                readText[i] = readText[i].Replace(" -> ", ".");
                startingCity = readText[i].Split('.')[0];
                destination = readText[i].Split('.')[1] + ", ";

                if (flights.ContainsKey(startingCity)) { flights[startingCity] += destination; }
                else { flights.Add(startingCity, destination); }
            }
        }

        private static void ShowAllAvailableFlights(Dictionary<string, string> flights)
        {
            foreach (KeyValuePair<string, string> flight in flights)
            {
                var destinations = flight.Value.Remove(flight.Value.Length - 2).Trim();
                Console.WriteLine(flight.Key + " -> " + destinations + "\b");
            }
        }
    }
}
