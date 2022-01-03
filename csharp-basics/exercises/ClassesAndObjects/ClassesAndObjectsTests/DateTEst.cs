using System;
using Exercise5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesAndObjectsTests
{
    [TestClass]
    public class DateTest
    {
        private Date _target;

        [TestMethod]
        [DataRow(12, 12, 2001)]
        [DataRow(01, 01, 0001)]
        [DataRow(31, 05, 2030)]
        public void Date_RealDates_CreatesInstanceOfDate(int day, int month, int year)
        {
            _target = new Date(day, month, year);

            Assert.AreEqual(day, _target.Day);
            Assert.AreEqual(month, _target.Month);
            Assert.AreEqual(year, _target.Year);
        }

        [TestMethod]
        [DataRow(12, 12, 2001)]
        [DataRow(01, 01, 0001)]
        [DataRow(31, 05, 2030)]
        public void Date_RealDates_ShouldChangeCurrentDateToGivenInput(int day, int month, int year)
        {
            _target = new Date(12, 12, 2001);

            _target.Day = day;
            _target.Month = month;
            _target.Year = year;

            Assert.AreEqual(day, _target.Day);
            Assert.AreEqual(month, _target.Month);
            Assert.AreEqual(year, _target.Year);
        }

        [TestMethod]
        [DataRow(32, 12, 2001)]
        [DataRow(01, 44, 0001)]
        [DataRow(31, 05, -2030)]
        public void Date_ImpossibleDates_ThrowsException(int day, int month, int year)
        {
            var exception = Assert.ThrowsException<Exception>(() => new Date(day, month, year));

            Assert.AreEqual(exception.Message, "Date out of bounds");
        }

        [TestMethod]
        [DataRow(32, 12, 2001)]
        [DataRow(01, 44, 0001)]
        [DataRow(31, 05, -2030)]
        public void Date_ImpossibleDates_ShouldTryToAssignValueButThrowsExceptionInstead(int day, int month, int year)
        {
            _target = new Date(12, 12, 2001);

            try
            {
                _target.Day = day;
                _target.Month = month;
                _target.Year = year;
                Assert.Fail();
            }
            catch(Exception ex)
            {
                Assert.AreEqual(ex.Message, "Date out of bounds");
            }
        }

        [TestMethod]
        [DataRow(32, 12, 2001)]
        [DataRow(01, 44, 0001)]
        [DataRow(31, 05, -2030)]
        public void Date_ChangeImpossibleDates_ThrowsException(int day, int month, int year)
        {
            var exception = Assert.ThrowsException<Exception>(() => _target = new Date(day, month, year));

            Assert.AreEqual(exception.Message, "Date out of bounds");
        }

        [TestMethod]
        [DataRow(12, 12, 2001)]
        [DataRow(01, 01, 0001)]
        [DataRow(31, 05, 2030)]
        public void GetDate_RealDates_ReturnsRepresentationOfTheDateInstance(int day, int month, int year)
        {
            _target = new Date(day, month, year);

            Assert.AreEqual($"{day}/{month}/{year}", _target.GetDate());
        }
    }
}
