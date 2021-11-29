using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, carsNotDriver, carsDriven, seatsInCar;
            double carpoolCapacity, averagePassengersPerCar;

            cars = 100;
            seatsInCar = 4;
            drivers = 28;
            passengers = 90;
            carsNotDriver =  cars - drivers; // free cars
            carsDriven = drivers; // cars driven at the moment
            carpoolCapacity = seatsInCar * drivers;
            averagePassengersPerCar =(double)passengers / (double)drivers;

            Console.WriteLine("There are {0} cars available.", cars);
            Console.WriteLine("There are only {0} drivers available.", drivers);
            Console.WriteLine("There will be {0} empty cars today.", carsNotDriver);
            Console.WriteLine("We can transport {0} people today.", carpoolCapacity);
            Console.WriteLine("We have {0} passengers to carpool today.", passengers);
            Console.WriteLine("We need to put about {0:0.##} average passengers in each car.", averagePassengersPerCar);
            Console.ReadKey();
        }
    }
}