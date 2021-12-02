using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSquare
{
    class NumberSquare
    {
        private int min;
        private int max;

        public NumberSquare()
        {
            Console.Write("Min? ");
            this.min = int.Parse(Console.ReadLine());

            Console.Write("Max? ");
            this.max = int.Parse(Console.ReadLine());

            MoveNumbers();
        }

        private void MoveNumbers()
        { 
            for (int i = max - 1; i >= 0; i--)
            {
                for (int j = max - i, count = 0; count < max; j++, count++)
                {
                    if (j > max) { j = 1; }

                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumberSquare num = new NumberSquare();

            Console.Read();
        }
    }
}
