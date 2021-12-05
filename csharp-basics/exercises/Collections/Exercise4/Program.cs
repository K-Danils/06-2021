using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string input = Console.ReadLine();
            var numbers = input.ToCharArray().ToList();
            
            while (true)
            {
                numbers.ForEach(num => sum += (int)Math.Pow(int.Parse(num.ToString()), 2));

                if (sum == 1) { Console.WriteLine("Number {0} is happy", input); break; }
                else if (sum == int.Parse(input)) { Console.WriteLine("Number {0} is not happy", input); break; }

                numbers = sum.ToString().ToCharArray().ToList();
                sum = 0;
            }

            Console.ReadKey();
        }
    }
}
