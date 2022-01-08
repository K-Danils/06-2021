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
            // Arrange
            _target = new Date(day, month, year);

            // Assert
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
            // Arrange
            _target = new Date(12, 12, 2001);

            // Act
            _target.Day = day;
            _target.Month = month;
            _target.Year = year;

            // Assert
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
            // Arrange
            var exception = Assert.ThrowsException<Exception>(() => new Date(day, month, year));

            // Assert
            Assert.AreEqual(exception.Message, "Date out of bounds");
        }

        [TestMethod]
        [DataRow(32)]
        [DataRow(-32)]
        [DataRow(0)]
        public void DateSetter_ImpossibleDay_ShouldTryToAssignValueButThrowsExceptionInstead(int day)
        {
            // Arrange
            _target = new Date(12, 12, 2001);
            var exception = Assert.ThrowsException<Exception>(() => _target.Day = day);

            // Assert
            Assert.AreEqual(exception.Message, "Date out of bounds");
        }

        [TestMethod]
        [DataRow(13)]
        [DataRow(0)]
        [DataRow(-12)]
        public void DateSetter_ImpossibleMonth_ShouldTryToAssignValueButThrowsExceptionInstead(int month)
        {
            // Arrange
            _target = new Date(12, 12, 2001);
            var exception = Assert.ThrowsException<Exception>(() => _target.Month = month);

            // Assert
            Assert.AreEqual(exception.Message, "Date out of bounds");
        }

        [TestMethod]
        [DataRow(-2001)]
        [DataRow(12111001)]
        [DataRow(0)]
        public void DateSetter_ImpossibleYear_ShouldTryToAssignValueButThrowsExceptionInstead(int year)
        {
            // Arrange
            _target = new Date(12, 12, 2001);
            var exception = Assert.ThrowsException<Exception>(() => _target.Year = year);

            // Assert
            Assert.AreEqual(exception.Message, "Date out of bounds");
        }

        [TestMethod]
        [DataRow(32, 12, 2001)]
        [DataRow(01, 44, 0001)]
        [DataRow(31, 05, -2030)]
        public void Date_CreateImpossible_ThrowsException(int day, int month, int year)
        {
            // Arrange
            var exception = Assert.ThrowsException<Exception>(() => _target = new Date(day, month, year));

            // Assert
            Assert.AreEqual(exception.Message, "Date out of bounds");
        }

        [TestMethod]
        [DataRow(12, 12, 2001)]
        [DataRow(01, 01, 0001)]
        [DataRow(31, 05, 2030)]
        public void GetDate_RealDates_ReturnsRepresentationOfTheDateInstance(int day, int month, int year)
        {
            // Arrange
            _target = new Date(day, month, year);

            // Assert
            Assert.AreEqual($"{day}/{month}/{year}", _target.GetDate());
        }
    }
}
