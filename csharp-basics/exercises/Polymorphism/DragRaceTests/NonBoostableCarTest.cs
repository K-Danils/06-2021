using System;
using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRaceTests
{
    [TestClass]
    public class NonBoostableCarTest
    {
        private Car _target;

        [TestMethod]
        public void SpeedUp_SpeedUp5Times_StartingSpeedShouldBe75()
        {
            // Arrange
            _target = new Audi();

            // Act
            for (int i = 0; i < 5; i++)
            {
                _target.SpeedUp();
            }

            // Assert
            Assert.AreEqual("75", _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void SlowDown_SlowDown5TimesFrom50_StartingSpeedShouldBe0()
        {
            // Arrange
            _target = new Audi();

            // Act
            for (int i = 0; i < 5; i++)
            {
                _target.SlowDown();
            }

            // Assert
            Assert.AreEqual("0", _target.ShowCurrentSpeed());
        }

        [TestMethod]
        [DataRow(10, 5 ,100)]
        [DataRow(10, 10, 50)]
        [DataRow(10, 15, 0)]
        [DataRow(5, 25, 0)]
        public void SlowDownAndSpeedUp_VariousLoads_ResultsShouldMatchExpected(int speedUpTimes, int breakingTimes, int  expectedSpeed)
        {
            // Arrange
            _target = new Audi();

            // Act
            for (int i = 0; i < speedUpTimes; i++)
            {
                _target.SpeedUp();
            }

            for (int i = 0; i < breakingTimes; i++)
            {
                _target.SlowDown();
            }

            // Assert
            Assert.AreEqual(expectedSpeed.ToString(), _target.ShowCurrentSpeed());
        }
    }
}
