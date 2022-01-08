using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOddEven
{
    public class OddEven
    {
        public OddEven()
        {
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public void PrintIsEven(int number)
        {
            if (IsEven(number))
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            OddEven oddEven = new OddEven();
            oddEven.PrintIsEven(Int32.Parse(Console.ReadLine()));
            Console.ReadLine();
            Console.WriteLine("bye!");
        }
    }
}
