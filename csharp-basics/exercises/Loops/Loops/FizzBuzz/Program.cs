using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private int num;

        public FizzBuzz()
        {
            Console.Write("Max value? ");
            this.num = int.Parse(Console.ReadLine());
            PrintFizzBuzz();
        }

        private void PrintFizzBuzz()
        {
            int count = 0;

            for (int i = 1; i <= num; i++, count++)
            {
                if (count % 20 == 0)
                {
                    Console.WriteLine();
                }   

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Console.Read();
        }
    }
}
