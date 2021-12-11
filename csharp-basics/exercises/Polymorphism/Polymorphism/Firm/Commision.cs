using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    public class Commision : Hourly
    {
        private double _totalSales;
        private double _commisionRate;

        public Commision(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commisionRate) : 
            base( eName,  eAddress,  ePhone,  socSecNumber,  rate)
        {
            _commisionRate = commisionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales;
        }

        public override double Pay()
        {
            double payment = base.Pay() + (_totalSales * _commisionRate);
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSales;
            return result;
        }
    }
}
