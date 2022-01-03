using System;
using Hierarchy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HierarchyTests
{
    [TestClass]
    public class TigerTest
    {
        private Tiger _target;

        [TestMethod]
        public void Eat_Vegetable_ReturnsTrue()
        {
            _target = new Tiger("Tiger", "Tiger", 180, "Jungle");

            Assert.IsTrue(_target.Eat(new Meat(5)));
        }

        [TestMethod]
        public void Eat_Meat_ReturnsFalse()
        {
            _target = new Tiger("Tiger", "Tiger", 180, "Jungle");

            Assert.IsFalse(_target.Eat(new Vegetable(5)));
        }

        [TestMethod]
        public void FoodEaten_5Vegetable_Returns5()
        {
            _target = new Tiger("Tiger", "Tiger", 180, "Jungle");

            _target.Eat(new Meat(5));

            Assert.AreEqual(5, _target.FoodEaten);
        }
    }
}
