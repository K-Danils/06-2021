using System;

namespace CozaLozaWoza
{
    public class CozaLoza
    {
        public CozaLoza()
        {
        }

        public string DetermineCozaLozaWoza(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "CozaLoza";
            }
            else if (num % 3 == 0 && num % 7 == 0)
            {
                return "CozaWoza";
            }
            else if (num % 5 == 0 && num % 7 == 0)
            {
                return "LozaWoza";
            }
            else if (num % 3 == 0)
            {
                return "Coza";
            }
            else if (num % 5 == 0)
            {
                return "Loza";
            }
            else if (num % 7 == 0)
            {
                return "Woza";
            }
            else
            {
                return num.ToString();
            }
        }

        public void PrintCozaLozaWoza(int rows, int lineLength)
        {
            int j = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (; j <= lineLength * i; j++)
                {
                    Console.Write(DetermineCozaLozaWoza(j) + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CozaLoza cl = new CozaLoza();

            cl.PrintCozaLozaWoza(10,11);
            Console.ReadLine();
        }
    }
}
