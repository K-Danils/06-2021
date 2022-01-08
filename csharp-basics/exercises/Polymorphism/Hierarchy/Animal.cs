using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        public Animal(string name, string animalType, double weight)
        {
            _animalName = name;
            _animalType = animalType;
            _animalWeight = weight;
        }

        public string AnimalName { get => _animalName;}
        public string AnimalType { get => _animalType;}
        public double AnimalWeight { get => _animalWeight;}

        public int FoodEaten { get => _foodEaten; set => _foodEaten = value; }

        public virtual void MakeSound() { }

        public virtual bool Eat(Food food) { return false; }
    }
}
