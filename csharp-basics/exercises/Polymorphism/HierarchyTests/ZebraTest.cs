using System;
using Hierarchy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HierarchyTests
{
    [TestClass]
    public class ZebraTest
    {
        private Zebra _target;

        [TestMethod]
        public void Eat_Vegetable_ReturnsTrue()
        {
            // Arrange
            _target = new Zebra("Zebra", "Zebra", 180, "Savanna");

            // Assert
            Assert.IsTrue(_target.Eat(new Vegetable(5)));
        }

        [TestMethod]
        public void Eat_Meat_ReturnsFalse()
        {
            // Arrange
            _target = new Zebra("Zebra", "Zebra", 180, "Savanna");

            // Assert
            Assert.IsFalse(_target.Eat(new Meat(5)));
        }

        [TestMethod]
        public void FoodEaten_5Vegetable_Returns5()
        {
            // Arrange
            _target = new Zebra("Zebra", "Zebra", 180, "Savanna");

            // Act
            _target.Eat(new Vegetable(5));

            // Assert
            Assert.AreEqual(5, _target.FoodEaten);
        }
    }
}
