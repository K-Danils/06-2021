using System;
using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRaceTests
{
    [TestClass]
    public class BoostableCarTest
    {
        private Car _target;

        [TestMethod]
        public void SpeedUp_SpeedUp5Times_StartingSpeedShouldBe50()
        {
            // Arrange
            _target = new Toyota();

            // Act
            for (int i = 0; i < 5; i++)
            {
                _target.SpeedUp();
            }

            // Assert
            Assert.AreEqual("50", _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void SlowDown_SlowDown5TimesFrom50_StartingSpeedShouldBe25()
        {
            // Arrange
            _target = new Lexus();

            // Act
            for (int i = 0; i < 5; i++)
            {
                _target.SlowDown();
            }

            // Assert
            Assert.AreEqual("0", _target.ShowCurrentSpeed());
        }

        [TestMethod]
        [DataRow(10, 5, 75)]
        [DataRow(10, 10, 50)]
        [DataRow(10, 15, 25)]
        [DataRow(5, 25, 0)]
        public void SlowDownAndSpeedUp_VariousLoads_ResultsShouldMatchExpected(int speedUpTimes, int breakingTimes, int expectedSpeed)
        {
            // Arrange
            _target = new Toyota();

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

        public void UseNitrousOxideEngine_CallItTwice_StartingSpeedShouldBe200()
        {
            // Arrange
            _target = new Toyota();

            // Act
            ((IBoostable)_target).UseNitrousOxideEngine();

            // Assert
            Assert.AreEqual("200", _target.ShowCurrentSpeed());
        }
    }
}
