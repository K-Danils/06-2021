﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMenu();
            Console.ReadKey();
        }

        public static int GetMenu()
        {
            int userChoice = 0;

            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");

            // get input from user
            var keyboard = Console.ReadKey();
            Console.WriteLine();
            
            // validate input
            if (keyboard.Key == ConsoleKey.D1)
            {
                CalculateCircleArea();
            }
            else if (keyboard.Key == ConsoleKey.D2)
            {
                CalculateRectangleArea();
            }
            else if (keyboard.Key == ConsoleKey.D3)
            {
                CalculateTriangleArea();
            }
            else if (keyboard.Key == ConsoleKey.D4)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Command not found");
            }
            
            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            int radius = Int32.Parse(Console.ReadLine());

            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            // Get length
            Console.WriteLine("Enter length? ");
            length = Int32.Parse(Console.ReadLine());

            // Get width
            Console.WriteLine("Enter width? ");
            width = Int32.Parse(Console.ReadLine());

            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            ground = Int32.Parse(Console.ReadLine());

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            height = Int32.Parse(Console.ReadLine());

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
