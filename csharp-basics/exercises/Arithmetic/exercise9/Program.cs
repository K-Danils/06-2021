using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise9
{
    class Program
    {
        static void CalculateBMI(double weight, double height)
        {
            // convert from metric to imperial
            weight = weight * 2.2046;
            height = height * 0.3937;

            //```BMI = weight x 703 / height ^ 2```.
            //A sedentary person's weight is considered optimal if his or her BMI is between 18.5 and 25.
            double BMI = (weight * 703.0) / (Math.Pow(height, 2));

            if (BMI < 18.5) { Console.WriteLine("Underweight"); }
            else if (BMI > 25) { Console.WriteLine("Overweight"); }
            else { Console.WriteLine("Optimal weight"); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());
            CalculateBMI(weight, height);
            Console.ReadKey();
        }
    }
}
