using System;
using exercise8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticsTest
{
    [TestClass]
    public class SalaryCalculatorTest
    {
        SalaryCalculator _target = new SalaryCalculator();

        [TestMethod]
        public void CalculateSalary_basePay7Dot5_workedHours35_ExceptionTheBasePayIsTooLittle()
        {
            // Act
            Exception ex = Assert.ThrowsException<Exception>(() => _target.CalculateSalary(7.5m, 35));
            // Assert
            Assert.AreEqual("ERROR - The base pay is too little", ex.Message);
        }

        [TestMethod]
        public void CalculateSalary_basePay10_workedHours73_ExceptionTooManyHoursWorked()
        {
            // Act
            Exception ex = Assert.ThrowsException<Exception>(() => _target.CalculateSalary(10m, 73));
            // Assert
            Assert.AreEqual("ERROR - Too many hours worked", ex.Message);
        }

        [TestMethod]
        public void CalculateSalary_basePay8Dot2_workedHours47_Returns414Dot1()
        {
            // Assert
            Assert.AreEqual(414.1m, _target.CalculateSalary(8.2m, 47));
        }

        [TestMethod]
        public void CalculateSalary_basePay9_workedHours55_Returns562Dot5()
        {
            // Assert
            Assert.AreEqual(562.5m, _target.CalculateSalary(9.0m, 55));
        }
    }
}
