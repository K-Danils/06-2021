﻿using System;
using System.Collections.Generic;
using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRaceTests
{
    [TestClass]
    public class DragRaceSimulationTest
    {
        private DragRaceSimulation _target;

        [TestMethod]
        public void StartRace_ListOfAllCars_FastestSpeedShouldBe180()
        {
            // Arrange
            var cars = new List<Car>{
            new Alpine(),
            new Audi(),
            new Bmw(),
            new Lexus(),
            new Tesla(),
            new Toyota(),
            };

            _target = new DragRaceSimulation(cars);

            // Act
            _target.StartRace(10);

            // Assert
            Assert.AreEqual("180", _target.GetFastestCar());
        }
    }
}
