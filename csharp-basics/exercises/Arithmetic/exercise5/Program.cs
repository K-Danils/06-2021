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
            Random ran = new Random();
            int guessingNum = 5;
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            
            for (int i = 0; i < 2; i++)
            {
                int guess = Int32.Parse(Console.ReadLine());
                if (guess > guessingNum)
                {
                    if (i == 1 ) {Console.WriteLine("Sorry, you are too high.  I was thinking of " + guessingNum + ".");}
                    else {Console.WriteLine("Too high.");}
                }
                else if (guess < guessingNum)
                {
                    if (i == 1) { Console.WriteLine("Sorry, you are too low.  I was thinking of " + guessingNum + ".");}
                    else {Console.WriteLine("Too low.");}
                }
                else
                {
                    Console.WriteLine("You guessed it!  What are the odds?!? ");
                    break;
                }
            }
            Console.ReadKey();
            
        }
    }
}
