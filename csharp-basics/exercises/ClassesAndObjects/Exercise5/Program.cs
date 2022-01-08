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
            Date date = new Date(32,12,2001);

            date.GetDate();

            date.Day = 31;
            date.Month = 3;
            date.Year = 2100;

            date.GetDate();

            Console.ReadKey();
        }
    }
}
