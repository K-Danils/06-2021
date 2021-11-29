using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, eyes, teeth, hair;
            int age;
            double height, weight;

            name = "Zed A. Shaw";
            age = 35;
            height = 74.0 * 2.54;  // inches | 1 inch = 2.54cm
            weight = 180.0 * 0.453592; // lbs | 1 pound = 0.453592kg
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";

            Console.WriteLine("Let's talk about {0}.", name);
            Console.WriteLine("He's {0} centimeters tall.", height);
            Console.WriteLine("He's {0} kilos heavy.", weight);
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got {0} eyes and {1} hair.", eyes, hair);
            Console.WriteLine("His teeth are usually {0} depending on the coffee.", teeth);

            Console.WriteLine("If I add {0}, {1:0.##}, and {2:0.##} I get {3:0.##}.", 
                age, height, weight, (age + height + weight));

            Console.ReadKey();
        }
    }
}