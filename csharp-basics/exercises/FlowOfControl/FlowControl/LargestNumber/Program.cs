using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Console.ReadLine();

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Console.ReadLine();

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Console.ReadLine();

            var num1 = double.Parse(input1);
            var num2 = double.Parse(input2);
            var num3 = double.Parse(input3);

            if (num1 <= num2)
            {
                if (num2 <= num3)
                {
                    Console.WriteLine("Largest number is: " + input3);
                }
                else
                {
                    Console.WriteLine("Largest number is: " + input2);
                }
            }
            else if (num1 <= num3)
            {
                Console.WriteLine("Largest number is: " + input3);
            }
            else
            {
                Console.WriteLine("Largest number is: " + input1);
            }

            Console.Read();
        }
    }
}
