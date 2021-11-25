using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static bool checkFifteen(int num1, int num2)
        {
            if ((num1 == 15 || num2 == 15) || (num1 + num2 == 15 || num1 - num2 == 15 || num2 - num1 == 15))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(checkFifteen(num1, num2));
            Console.ReadLine();

        }
    }
}
