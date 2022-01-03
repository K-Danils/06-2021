using System;
using GravityCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticsTest
{
    [TestClass]
    public class GravityCalculatorTest
    {
        Gravity _target = new Gravity();

        [TestMethod]
        public void CalculateFinalPosition_Vel0_Pos0_fallT10_ReturnsNegative490Dot5()
        {
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;

            Assert.AreEqual(-490.5, _target.CalculateFinalPosition(initialVelocity, fallingTime, initialPosition));
        }

        [TestMethod]
        public void CalculateFinalPosition_Vel10_Pos50_fallT30_ReturnsNegative4064Dot5()
        {
            double initialVelocity = 10.0;
            double fallingTime = 30.0;
            double initialPosition = 50.0;

            Assert.AreEqual(-4064.5, _target.CalculateFinalPosition(initialVelocity, fallingTime, initialPosition));
        }
    }
}
