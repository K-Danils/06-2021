using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input minutes: ");

            float minutes = float.Parse(Console.ReadLine());
            float years = minutes * 1.9013E-6f;
            float days = minutes * 0.000694f;

            Console.WriteLine("{0} is {1} days and {2} years", minutes, days, years);
            Console.Read();
        }
    }
}
