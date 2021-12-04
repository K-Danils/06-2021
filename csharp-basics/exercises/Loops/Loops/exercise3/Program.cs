using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int[] randomArr = new int[20];

            for (int i = 0; i < 20; i++)
            {
                randomArr[i] = ran.Next(0,101);
            }

            Console.WriteLine("Numbers: ");

            foreach (int element in randomArr) { Console.Write(element + " "); }

            Console.Write("\nInput the number to get its position: ");
            
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int index = Array.IndexOf(randomArr, input);

            if (index > -1)
            {
                Console.WriteLine("Number {0} is at position {1}", input, index + 1);
            }
            else
            {
                Console.WriteLine("Number is out of range\n");
            }

            Console.ReadKey();
        }
    }
}
