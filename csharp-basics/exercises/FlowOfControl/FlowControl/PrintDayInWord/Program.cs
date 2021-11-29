using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number corresponding to the day: ");
            int input = 0;

            if (int.TryParse(Console.ReadLine(), out input))
            {
                switch (input)
                {
                    case 0:
                        Console.WriteLine("Monday");
                        break;
                    case 1:
                        Console.WriteLine("Tuesday");
                        break;
                    case 2:
                        Console.WriteLine("Wednsday");
                        break;
                    case 3:
                        Console.WriteLine("Thursday");
                        break;
                    case 4:
                        Console.WriteLine("Friday");
                        break;
                    case 5:
                        Console.WriteLine("Saturday");
                        break;
                    case 6:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Not a valid day");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Not a valid day");
            }
            
            Console.Read();
        }
    }
}
