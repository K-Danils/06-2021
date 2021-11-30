using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Codelex", "Scissors", "Engineer", "Holiday" };
            Random ran = new Random();
            string wordToGuess = "";
            string guessProgression = "";
            string guess = "";
            string misses = "";

            while (true)
            {
                wordToGuess = words[ran.Next(0, words.Length)];
                guessProgression = HideGuess(wordToGuess);
                misses = "";

                while (true)
                {
                    Console.Clear();

                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-"); 
                    Console.WriteLine("Word: " + guessProgression);
                    Console.WriteLine("Misses: " + misses);
                    Console.Write("Guess: ");
                    guess = Console.ReadKey().KeyChar.ToString();
                    Console.WriteLine();

                    int index = wordToGuess.ToLower().IndexOf(guess);

                    if (index >= 0)
                    {
                        guessProgression = FindAllGuessedChars(wordToGuess, guessProgression, guess);

                    }
                    else
                    {
                        misses +=guess;
                    }

                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");

                    if (guessProgression.Equals(wordToGuess.ToLower()))
                    {
                        Console.Clear();

                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        Console.WriteLine("Word: " + wordToGuess);
                        Console.WriteLine("Misses: " + misses);
                        Console.WriteLine("Guess: " + guess);
                        Console.WriteLine("YOU GOT IT!\n");

                        break;
                    }
                }

                Console.Write("Play \"again\" or \"quit\"?");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                guessProgression = "";
            }




        }

        private static string FindAllGuessedChars(string wordToGuess, string guessProgression, string guess)
        {
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (guess.Equals(wordToGuess[i].ToString().ToLower()))
                {
                    StringBuilder sb = new StringBuilder(guessProgression);
                    sb[i] = guess[0];
                    guessProgression = sb.ToString();
                }
            }

            return guessProgression;
        }

        private static string HideGuess(string wordToGuess)
        {
            string guessProgression = "";

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                guessProgression += "_";
            }

            return guessProgression;
        }
    }
}
