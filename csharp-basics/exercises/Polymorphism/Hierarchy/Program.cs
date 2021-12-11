using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string name = "";
            string animalType = "";
            double weight = 0;
            string livingRegion = "";
            string breed = "";
            string separator = "";

            List<string> food = new List<string>();
            List<string> attributes = new List<string>();
            var animals = new List<Animal>();

            while (true)
            {
                food.Clear();
                attributes.Clear();
                input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    foreach (Animal animal in animals)
                    {
                        if (animal is Cat)
                        {
                            Console.Write(separator + $"{animal.AnimalType} [{animal.AnimalName}, {((Cat)animal).Breed}, {animal.AnimalWeight}, " +
                            $"{((Mammal)animal).LivingRegion}, {animal.FoodEaten}]");
                            separator = ", ";
                        }
                        else
                        {
                            Console.Write(separator + $"{animal.AnimalType} [{animal.AnimalName}, {animal.AnimalWeight}, " +
                         $"{((Mammal)animal).LivingRegion}, {animal.FoodEaten}]");
                            separator = ", ";
                        }
                    }

                    break;
                }

                attributes = new List<string>(input.Split(' '));

                if (attributes.Count == 5)
                {
                    name = attributes[1];
                    animalType = attributes[0];
                    weight = double.Parse(attributes[2]);
                    livingRegion = attributes[3];
                    breed = attributes[4];
                }
                else if (attributes.Count == 4)
                {
                    name = attributes[1];
                    animalType = attributes[0];
                    weight = double.Parse(attributes[2]);
                    livingRegion = attributes[3];
                }
                else
                {
                    Console.WriteLine("Not enough / too littleinformation has been given");
                    continue;
                }

                if (animalType.ToLower() == "cat")
                {
                    animals.Add(new Cat(animalType, name, weight, livingRegion, breed));
                }
                else if (animalType.ToLower() == "tiger")
                {
                    animals.Add(new Tiger(animalType, name, weight, livingRegion));
                }
                else if (animalType.ToLower() == "mouse")
                {
                    animals.Add(new Mouse(animalType, name, weight, livingRegion));
                }
                else if (animalType.ToLower() == "zebra")
                {
                    animals.Add(new Zebra(animalType, name, weight, livingRegion));
                }
                else
                {
                    Console.WriteLine("Animal not found");
                    continue;
                }

                input = Console.ReadLine();
                food = new List<string>(input.Split(' '));

                if (food[0].ToLower() == "vegetable")
                {
                    Vegetable vegetable = new Vegetable(int.Parse(food[1]));
                    FeedTheAnimal(animals[animals.Count - 1], vegetable);
                }
                else if (food[0].ToLower() == "meat")
                {
                    Meat meat = new Meat(int.Parse(food[1]));
                    FeedTheAnimal(animals[animals.Count - 1], meat);
                }
                else
                {
                    Console.WriteLine("Incorrect food was given");
                    continue;
                }

                if (attributes.Count == 5)
                {
                    Console.WriteLine($"{animalType} [{name}, {breed}, {weight}, {livingRegion}, {animals[animals.Count - 1].FoodEaten}]");
                }
                else if (attributes.Count == 4)
                {
                    Console.WriteLine($"{animalType} [{name}, {weight}, {livingRegion}, {animals[animals.Count - 1].FoodEaten}]");
                }
            }

            Console.ReadKey();
        }

        private static void FeedTheAnimal(Animal animal, Food food)
        {
            animal.MakeSound();
            animal.Eat(food);
        }
    }
}