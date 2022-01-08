using System;
using Hierarchy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HierarchyTests
{
    [TestClass]
    public class MouseTest
    {
        private Mouse _target;

        [TestMethod]
        public void Eat_Vegetable_ReturnsTrue()
        {
            // Arrange
            _target = new Mouse("Mouse", "Mouse", .1, "Homes");

            // Assert
            Assert.IsTrue(_target.Eat(new Vegetable(5)));
        }

        [TestMethod]
        public void Eat_Meat_ReturnsFalse()
        {
            // Arrange
            _target = new Mouse("Mouse", "Mouse", .1, "Homes");

            // Assert
            Assert.IsFalse(_target.Eat(new Meat(5)));
        }

        [TestMethod]
        public void FoodEaten_5Vegetable_Returns5()
        {
            // Arrange
            _target = new Mouse("Mouse", "Mouse", .1, "Homes");

            // Act
            _target.Eat(new Vegetable(5));

            // Assert
            Assert.AreEqual(5, _target.FoodEaten);
        }
    }
}
