using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Date
    {
        private int _month;
        private int _day;
        private int _year;

        public int Month
        {
            get => _month;
            set => _month = value;
        }

        public int Year
        {
            get => _day;
            set => _day = value;
        }

        public int Day
        {
            get => _day;
            set => _day = value;
        }

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public void DisplayDate()
        {
            Console.WriteLine("{0}/{1}/{2}", _day, _month, _year);
        }
    }
}
