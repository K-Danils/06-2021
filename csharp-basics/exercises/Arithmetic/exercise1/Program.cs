using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class CheckFifteen
    {
        public CheckFifteen()
        {
        }

        public bool IsFifteen(int num1, int num2)
        {
            return num1 == 15 || num2 == 15 || 
                num1 + num2 == 15 || num1 - num2 == 15 || 
                num2 - num1 == 15;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());

            CheckFifteen cf = new CheckFifteen();

            Console.WriteLine(cf.IsFifteen(num1, num2));
            Console.ReadLine();

        }
    }
}
