using System;

namespace GravityCalculator
{
    public class Gravity
    {
        private const double _gravity = -9.81;  // Earth's gravity in m/s^2
        public Gravity()
        {
        }

        public double CalculateFinalPosition(double initialVelocity, double fallingTime, double initialPosition)
        {
            return 0.5 * _gravity * Math.Pow(fallingTime, 2) + initialVelocity * fallingTime + initialPosition;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;

            Gravity gravity = new Gravity();

            Console.WriteLine("The object's position after " + fallingTime + 
                " seconds is " + gravity.CalculateFinalPosition(initialVelocity, fallingTime, initialPosition) + " m.");
            Console.ReadKey();
        }
    }
}
