﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    public class DragRaceSimulation
    {
        private List<Car> _cars;

        public DragRaceSimulation(List<Car> cars)
        {
            _cars = cars;
        }

        public void StartRace(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                foreach (var car in _cars)
                {
                    if (i == 1) { car.StartEngine(); continue; }

                    else if (i == 3)
                    {
                        if (car is IBoostable)
                        {
                            ((IBoostable)car).UseNitrousOxideEngine();
                            continue;
                        }
                    }
                    car.SpeedUp();
                }
            }
        }

        public void ShowAllSpeeds()
        {
            _cars.ForEach(car => Console.WriteLine(car.GetType().Name + " : " + car.ShowCurrentSpeed()));
        }

        public string GetFastestCar()
        {
            var fastestCar = int.Parse(_cars[0].ShowCurrentSpeed());

            _cars.ForEach(car => fastestCar = int.Parse(car.ShowCurrentSpeed()) > fastestCar ? int.Parse(car.ShowCurrentSpeed()) : fastestCar);

            return fastestCar.ToString();
        }
    }
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */
        static void Main(string[] args)
        {
            var cars = new List<Car> {
            new Alpine(),
            new Audi(),
            new Bmw(),
            new Lexus(),
            new Tesla(),
            new Toyota(),
            };

            DragRaceSimulation dragRace = new DragRaceSimulation(cars);

            dragRace.StartRace(10);
            dragRace.ShowAllSpeeds();
            Console.WriteLine("Fastest speed: " + dragRace.GetFastestCar());

            Console.ReadKey();
        }
    }
}
