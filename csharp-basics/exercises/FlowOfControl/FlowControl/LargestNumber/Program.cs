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

            if (double.Parse(input1) <= double.Parse(input2))
            {
                if (double.Parse(input2) <= double.Parse(input3))
                {
                    Console.WriteLine("Largest number is: " + input3);
                }
                else
                {
                    Console.WriteLine("Largest number is: " + input2);
                }
            }
            else if (double.Parse(input1) <= double.Parse(input3))
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
