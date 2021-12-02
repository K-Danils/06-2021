using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiFigure
{
    class AsciiFigure
    {
        private int size;

        public AsciiFigure()
        {
            this.size = int.Parse(Console.ReadLine());
            MakePyramid();
        }

        private void MakePyramid()
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < (size - i) * 4; j++)
                {
                    Console.Write("/");
                }

                for (int j = 0; j < ((i - 1) * 4) * 2; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < (size - i) * 4; j++)
                {
                    Console.Write("\\");
                }

                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AsciiFigure pyramid = new AsciiFigure();

            Console.Read();
        }
    }
}
