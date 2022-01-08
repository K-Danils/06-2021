using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSquare
{
    class NumberSquare
    {
        private int _min;
        private int _max;

        public NumberSquare()
        {
            Console.Write("Min? ");
            this._min = int.Parse(Console.ReadLine());

            Console.Write("Max? ");
            this._max = int.Parse(Console.ReadLine());

            MoveNumbers();
        }

        private void MoveNumbers()
        { 
            for (int i = _max - 1; i >= 0; i--)
            {
                for (int j = _max - i, count = 0; count < _max; j++, count++)
                {
                    if (j > _max) { j = 1; }

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
