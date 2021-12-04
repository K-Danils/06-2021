using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Date
    {
        public int month { get; set; }
        public int day { get; set; }
        public int year { get; set; }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void DisplayDate()
        {
            Console.WriteLine("{0}/{1}/{2}", day, month, year);
        }
    }
}
