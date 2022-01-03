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
            _target = new Audi();

            for (int i = 0; i < 5; i++)
            {
                _target.SpeedUp();
            }

            Assert.AreEqual(75.ToString(), _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void SlowDown_SlowDown5TimesFrom50_StartingSpeedShouldBe0()
        {
            _target = new Audi();

            for (int i = 0; i < 5; i++)
            {
                _target.SlowDown();
            }

            Assert.AreEqual(0.ToString(), _target.ShowCurrentSpeed());
        }

        [TestMethod]
        [DataRow(10, 5 ,100)]
        [DataRow(10, 10, 50)]
        [DataRow(10, 15, 0)]
        [DataRow(5, 25, 0)]
        public void SlowDownAndSpeedUp_VariousLoads_ResultsShouldMatchExpected(int speedUpTimes, int breakingTimes, int  expectedSpeed)
        {
            _target = new Audi();

            for (int i = 0; i < speedUpTimes; i++)
            {
                _target.SpeedUp();
            }

            for (int i = 0; i < breakingTimes; i++)
            {
                _target.SlowDown();
            }

            Assert.AreEqual(expectedSpeed.ToString(), _target.ShowCurrentSpeed());
        }
    }
}
