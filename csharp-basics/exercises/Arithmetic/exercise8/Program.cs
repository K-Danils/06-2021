using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    class Program
    {
        static void CalculateSalary(float basePay, int workedHours)
        {
            const int legalLimitHours = 60;
            const int nonOvertimeHours = 40;
            const float legalMinWage = 8.0f;
            const float legalOvertimeModifier = 1.5f;
            
            if(basePay < legalMinWage)
            {
                Console.WriteLine("ERROR - The base pay is too little");
            }
            else if (workedHours > legalLimitHours)
            {
                Console.WriteLine("ERROR - Too many hours worked");
            }
            else
            {
                if (workedHours <= nonOvertimeHours) { Console.WriteLine("$" + (workedHours * basePay)); }
                else
                {
                    int extraHours = workedHours - nonOvertimeHours;
                    float extraPay = legalOvertimeModifier * basePay;
                    float total = (nonOvertimeHours * basePay) + (extraHours * extraPay);
                    Console.WriteLine("$" + total);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Employee {0}, Total pay ", 1);
            CalculateSalary(7.5f, 35);
            Console.Write("Employee {0}, Total pay ", 2);
            CalculateSalary(8.2f, 47);
            Console.Write("Employee {0}, Total pay ", 3);
            CalculateSalary(10.0f, 73);
            Console.ReadKey();
        }
    }
}
