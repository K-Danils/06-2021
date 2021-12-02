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
            int[] randomArr = new int[21];

            for (int i = 0; i < 21; i++)
            {
                randomArr[i] = ran.Next(0,101);
            }
            while (true)
            {
                Console.Write("Input the position: ");

                int input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (input >= 0 && input <= 20)
                {
                    Console.WriteLine("Number at {0} is {1}", input, randomArr[input]);
                }
                else
                {
                    Console.WriteLine("Number is out of range\n");
                }
            }
        }
    }
}
