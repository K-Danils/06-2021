using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Write a word: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsUpper(input[i]))
                {
                    count++;
                }
            }

            Console.WriteLine("Amount of uppercase characters: " + count);
            Console.Read();
        }
    }
}
