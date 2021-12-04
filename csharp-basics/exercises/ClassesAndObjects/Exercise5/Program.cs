using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(12,12,2001);

            date.DisplayDate();

            date.day = 21;
            date.month = 3;
            date.year = 2100;

            date.DisplayDate();

            Console.ReadKey();
        }
    }
}
