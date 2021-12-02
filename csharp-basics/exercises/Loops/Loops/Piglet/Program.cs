using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piglet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int diceRoll, sum = 0;
            string input = "";

            Console.WriteLine("Welcome to Piglet!");

            while (true)
            {
                diceRoll = ran.Next(0, 6) + 1;
                sum += diceRoll;

                Console.WriteLine("You rolled a " + diceRoll + "!");

                if (diceRoll == 1) { Console.WriteLine("You got 0 points"); break;}

                Console.Write("Roll again? ");

                input = Console.ReadLine();
                input = input.ToLower();

                if (input == "no" || input == "n")
                {
                    Console.WriteLine("You got {0} points.", sum);
                    Console.WriteLine();
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
