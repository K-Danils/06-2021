using System;
using CalculateArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticsTest
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void AreaOfCircle_radius10_Returns314Dot15()
        {
            Assert.AreEqual(314.16, Math.Round(Geometry.AreaOfCircle(10),2));
        }

        [TestMethod]
        public void AreaOfRectangle_length24_width_14_Returns336()
        {
            Assert.AreEqual(336, Geometry.AreaOfRectangle(24, 14));
        }

        [TestMethod]
        public void AreaOfTriangle_ground12_h3_Returns18()
        {
            Assert.AreEqual(18, Geometry.AreaOfTriangle(12,3));
        }

        [TestMethod]
        public void AreaOfRectangle_NegativeValue_ThrowsExceptionNegativeOrEmptyValuesUsed()
        {
            var exception = Assert.ThrowsException<Exception>(() => Geometry.AreaOfRectangle(-24, 14));
            Assert.AreEqual(exception.Message, "Negative or empty values used");
        }

        [TestMethod]
        public void AreaOfTriangle_ZeroAsInput_ThrowsExceptionNegativeOrEmptyValuesUsed()
        {
            var exception = Assert.ThrowsException<Exception>(() => Geometry.AreaOfTriangle(12, 0));
            Assert.AreEqual(exception.Message, "Negative or empty values used");
        }
    }
}
