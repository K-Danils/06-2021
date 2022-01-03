using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    public class SalaryCalculator
    {
        readonly int legalLimitHours = 60;
        readonly int nonOvertimeHours = 40;
        readonly decimal legalMinWage = 8.0m;
        readonly decimal legalOvertimeModifier = 1.5m;


        public decimal CalculateSalary(decimal basePay, int workedHours)
        {
            if (basePay < legalMinWage)
            {
                throw new Exception("ERROR - The base pay is too little");
            }
            else if (workedHours > legalLimitHours)
            {
                throw new Exception("ERROR - Too many hours worked");
            }
            else
            {
                if (workedHours <= nonOvertimeHours) { return workedHours * basePay;}
                else
                {
                    int extraHours = workedHours - nonOvertimeHours;
                    decimal extraPay = legalOvertimeModifier * basePay;
                    decimal total = (nonOvertimeHours * basePay) + (extraHours * extraPay);
                    return total;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator salary = new SalaryCalculator();

            Console.Write("Employee {0}, Total pay ${1}", 1, salary.CalculateSalary(7.5m, 35));
            Console.Write("Employee {0}, Total pay ${1}", 2, salary.CalculateSalary(8.2m, 47));
            Console.Write("Employee {0}, Total pay ${1}", 3, salary.CalculateSalary(10.0m, 73));
            Console.ReadKey();
        }
    }
}
