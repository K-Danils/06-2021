using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 1;
            for (int i = 1; i <= 10; i++)
            {
                res *= i;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
