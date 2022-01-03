using System;
using System.Collections.Generic;
using System.Linq;

namespace Hierarchy
{
    public class AnimalCreator
    {
        string name;
        string animalType;
        double weight;
        string livingRegion;
        string breed;

        public List<string> Attributes = new List<string>();
        public List<Animal> Animals = new List<Animal>();

        public AnimalCreator()
        {

        }

        public void CreateNewAnimal()
        {
            if (animalType.ToLower() == "cat")
            {
                Animals.Add(new Cat(animalType, name, weight, livingRegion, breed));
            }
            else if (animalType.ToLower() == "tiger")
            {
                Animals.Add(new Tiger(animalType, name, weight, livingRegion));
            }
            else if (animalType.ToLower() == "mouse")
            {
                Animals.Add(new Mouse(animalType, name, weight, livingRegion));
            }
            else if (animalType.ToLower() == "zebra")
            {
                Animals.Add(new Zebra(animalType, name, weight, livingRegion));
            }
            else
            {
                throw new Exception("Animal not found");
            }
        }

        public void ProccessInformation(string input)
        {
            Attributes = input.Split(' ').ToList();
            if (Attributes.Count == 5 && Attributes[0].ToLower() == "cat")
            {
                name = Attributes[1];
                animalType = Attributes[0];
                weight = double.Parse(Attributes[2]);
                livingRegion = Attributes[3];
                breed = Attributes[4];
            }
            else if (Attributes.Count == 4 && Attributes[0].ToLower() != "cat")
            {
                name = Attributes[1];
                animalType = Attributes[0];
                weight = double.Parse(Attributes[2]);
                livingRegion = Attributes[3];
            }
            else
            {
                throw new Exception("Not enough / too much information has been given");
            }
        }

        public string GetAnimalInformation()
        {
            if (Attributes.Count == 5)
            {
                return $"{animalType} [{name}, {breed}, {weight}, {livingRegion}, {Animals[Animals.Count - 1].FoodEaten}]";
            }
            else
            {
                return $"{animalType} [{name}, {weight}, {livingRegion}, {Animals[Animals.Count - 1].FoodEaten}]";
            }
        }

        public bool FeedAnimal(string input)
        {
            List<string> food = new List<string>(input.Split(' '));
            if (food[0].ToLower() == "vegetable")
            {
                Vegetable vegetable = new Vegetable(int.Parse(food[1]));
                return FeedTheAnimal(Animals[Animals.Count - 1], vegetable) ? true : throw new Exception(animalType + " does not eat that type of food!");
            }
            else if (food[0].ToLower() == "meat")
            {
                Meat meat = new Meat(int.Parse(food[1]));
                return FeedTheAnimal(Animals[Animals.Count - 1], meat) ? true : throw new Exception(animalType + " does not eat that type of food!");
            }
            else
            {
                throw new Exception("Incorrect food was given");
            }
        }

        private bool FeedTheAnimal(Animal animal, Food food)
        {
            animal.MakeSound();
            return animal.Eat(food);
        }

        public void EndTheLoop()
        {
            string separator = "";
            foreach (Animal animal in Animals)
            {
                if (animal is Cat)
                {
                    Console.Write(separator + $"{animal.AnimalType} [{animal.AnimalName}, {((Cat)animal).Breed}, {animal.AnimalWeight}, " +
                    $"{((Mammal)animal).LivingRegion}, {animal.FoodEaten}]");
                    separator = ", ";
                }
                else
                {
                    Console.Write(separator + GetAnimalInformation());
                    separator = ", ";
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            AnimalCreator animalCreator = new AnimalCreator();

            while (true)
            {
                input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    animalCreator.EndTheLoop();

                    break;
                }
                animalCreator.ProccessInformation(input);
                animalCreator.CreateNewAnimal();

                input = Console.ReadLine();
                animalCreator.FeedAnimal(input);
                Console.WriteLine(animalCreator.GetAnimalInformation());
            }

            Console.ReadKey();
        }
    }
}