using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class Flights
    {

        private Dictionary<string, string> _flights = new Dictionary<string, string>();
        private List<string> _visitedCities = new List<string>();

        public Dictionary<string, string> FlightsDict { get => _flights; }
        public List<string> VisitedCities { get => _visitedCities; }

        public Flights()
        {
        }

        public void VisitCity(string destination)
        {
            if (String.IsNullOrEmpty(destination))
            {
                throw new ArgumentNullException();
            }
            _visitedCities.Add(destination);
        }

        public string GetAllAvailableFlights()
        {
            string res = "";
            foreach (KeyValuePair<string, string> flight in _flights)
            {
                res += flight.Key + " -> " + flight.Value +"\n";
            }

            return res;
        }

        public string GetAvailableCities(string destination)
        {
            if (String.IsNullOrEmpty(destination))
            {
                throw new ArgumentNullException();
            }

            return _flights.ContainsKey(destination) ? FlightsDict[destination] : throw new Exception("Non defined city given");
        }

        public string GetVisitedCities()
        {
            return String.Join(" -> ", VisitedCities);
        }

        public void ConvertFlightsToDictionary(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException();
            }

            string[] readText = text.Replace("\r", "").Split('\n');
            string startingCity;
            string destination;

            for (int i = 0; i < readText.Length; i++)
            {
                if (!readText[i].Contains(" -> "))
                {
                    throw new Exception("Incorrect flight text format was given");
                }
                readText[i] = readText[i].Replace(" -> ", ".");
                startingCity = readText[i].Split('.')[0];
                destination = readText[i].Split('.')[1] + ", ";

                if (_flights.ContainsKey(startingCity))
                {
                    if (!_flights[startingCity].Equals(destination))
                    {
                        _flights[startingCity] += destination;
                    }
                }
                else { _flights.Add(startingCity, destination); }
            }

            RemoveComasFromLastItems();
        }

        private void RemoveComasFromLastItems()
        {
            var tempFlights = new Dictionary<string, string>(_flights);
            foreach (KeyValuePair<string, string> flight in _flights)
            {
                tempFlights[flight.Key] = _flights[flight.Key].Remove(_flights[flight.Key].Length - 2);
            }
            _flights = new Dictionary<string, string>(tempFlights);
        }
    }


    class Program
    {
        private const string Path = @"../../flights.txt";

        private static void Main(string[] args)
        {
            Flights flightPlanner = new Flights();
            var readText = File.ReadAllText(Path);
            string startingCity;
            string destination;

            flightPlanner.ConvertFlightsToDictionary(readText);

            Console.WriteLine("What would you like to do?\n" +
                "To display list of cities press 1:\n" +
                "To exit program press #");

            bool runLoop = Console.ReadLine() == "1";

            Console.WriteLine(flightPlanner.GetAllAvailableFlights());

            Console.Write("\nInput the city you wish to start from: ");

            startingCity = Console.ReadLine();
            flightPlanner.VisitCity(startingCity);

            Console.WriteLine("Available Cities: " + flightPlanner.GetAvailableCities(startingCity));

            while (runLoop)
            {
                Console.Write("\nInput the city you wish to go to: ");
                destination = Console.ReadLine();

                if (destination == startingCity) { flightPlanner.VisitCity(destination); break; }

                flightPlanner.VisitCity(destination);
                Console.WriteLine("Available cities: " + flightPlanner.GetAvailableCities(destination));
            }

            Console.WriteLine();
            Console.Write("Your flight route: " + flightPlanner.GetVisitedCities());

            Console.ReadKey();
        }
    }
}