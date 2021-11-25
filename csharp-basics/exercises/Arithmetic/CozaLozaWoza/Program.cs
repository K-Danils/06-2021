using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            for (int i = 1; i <= 10; i++)
            {
                for (; j <= 11*i; j++)
                {
                    if (j%3 == 0 && j%5 == 0)
                    {
                        Console.Write("CozaLoza ");
                    }
                    else if (j % 3 == 0 && j % 7 == 0)
                    {
                        Console.Write("CozaWoza ");
                    }
                    else if (j % 5 == 0 && j % 7 == 0)
                    {
                        Console.Write("LozaWoza ");
                    }
                    else if (j % 3 == 0)
                    {
                        Console.Write("Coza ");
                    }
                    else if (j % 5 == 0)
                    {
                        Console.Write("Loza ");
                    }
                    else if (j % 7 == 0)
                    {
                        Console.Write("Woza ");
                    }
                    else
                    {
                        Console.Write(j+" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
