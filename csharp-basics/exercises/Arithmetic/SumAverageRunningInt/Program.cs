using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            double average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }
            average = (double)sum / (double)upperBound;
            Console.WriteLine("The sum of {0} to {1} is {2}\nThe average is {3}", lowerBound, upperBound, sum, average);
            Console.ReadLine();
        }
    }
}
