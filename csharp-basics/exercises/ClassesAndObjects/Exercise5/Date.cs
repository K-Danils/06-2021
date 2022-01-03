using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Date
    {
        private int _month { get; set; }
        private int _day { get; set; }
        private int _year { get; set; }

        public int Month
        {
            get => _month;
            set => _month = (value > 0 && value <= 12) ? value : throw new Exception("Date out of bounds");
        }

        public int Day
        {
            get => _day;
            set => _day = (value > 0 && value <= 31) ? value : throw new Exception("Date out of bounds");
        }
        public int Year
        {
            get => _year;
            set => _year = (value >= 0 && value <= 9999) ? value : throw new Exception("Date out of bounds");
        }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string GetDate()
        {
            return $"{_day}/{_month}/{_year}";
        }
    }
}
