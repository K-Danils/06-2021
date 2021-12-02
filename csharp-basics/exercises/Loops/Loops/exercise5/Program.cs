using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter second word:");
            string input2 = Console.ReadLine();

            if (input1.Length + input2.Length > 30)
            {
                Console.WriteLine("Input length is too large");
            }
            else
            {
                Console.Write(input1);

                for (int i = 0; i < 30 - (input1.Length + input2.Length); i++)
                {
                    Console.Write(".");
                }

                Console.Write(input2);
            }

            Console.Read();
        }
    }
}
