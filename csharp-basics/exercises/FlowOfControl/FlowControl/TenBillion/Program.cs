using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();
            long n = 0;

            if (long.TryParse(input, out n)) 
            {
                if (n < 0) 
                {
                    n *= -1;
                }
                
                if (n >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                }
                else 
                {
                    Console.WriteLine();
                    int digits = 1;
                    if (n.ToString().Length == 2) 
                    {
                        digits = 2;
                    } 
                    else if (n.ToString().Length == 3) 
                    {
                        digits = 3;
                    } 
                    else if (n.ToString().Length == 4) 
                    {
                        digits = 4;
                    } 
                    else if (n.ToString().Length == 5) 
                    {
                        digits = 5;
                    } 
                    else if (n.ToString().Length == 6) 
                    {
                        digits = 6;
                    } 
                    else if (n.ToString().Length == 7) 
                    {
                        digits = 7;
                    } 
                    else if (n.ToString().Length == 8) 
                    {
                        digits = 8;
                    } 
                    else if (n.ToString().Length == 9) 
                    {
                        digits = 9;
                    } 
                    else if (n.ToString().Length == 10) 
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }

            Console.Read();
        }
    }
}
