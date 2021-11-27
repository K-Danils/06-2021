using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input distance in meters: ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Input hour: ");
            double hours = double.Parse(Console.ReadLine());

            Console.Write("Input minutes: ");
            double minutes = double.Parse(Console.ReadLine());

            Console.Write("Input seconds: ");
            double seconds = double.Parse(Console.ReadLine());

            double totalTimeSeconds = hours * 3600 + minutes * 60 + seconds;
            double totalTimeHours = hours + minutes / 60 + seconds * 0.000278;
            double speedMS = distance / totalTimeSeconds;
            double speedKMH = (distance / 1000) / totalTimeHours;

            Console.WriteLine("Your speed in meters/second is : " + speedMS);
            Console.WriteLine("Your speed in km/h is : " + speedKMH);
            Console.WriteLine("Your speed in miles/h is : " + (speedKMH * 0.621371192));

            Console.ReadLine();
        }
    }
}
