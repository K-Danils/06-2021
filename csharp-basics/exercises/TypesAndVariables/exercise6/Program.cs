using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double num;

            Console.WriteLine("Input a series of numbers\nTo print sum type -1 and press enter");

            while (true)
            {
                num = double.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("= " + sum);
                    break;
                }

                Console.Write(" + ");
                sum += num;            
            }

            Console.Read();
        }
    }
}
