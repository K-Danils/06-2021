using System;
using PhoneBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionsTests
{
    [TestClass]
    public class PhoneDirectoryTest
    {
        PhoneDirectory _target;

        [TestMethod]
        [DataRow("John Smith", "21345")]
        [DataRow("Robert Corner", "34155")]
        [DataRow("Admin", "5555")]
        public void PutNumber_CorrectEntry_GetNumberReturnsCorrectNumber(string name, string number)
        {
            _target = new PhoneDirectory();

            _target.PutNumber(name, number);

            Assert.AreEqual(number, _target.GetNumber(name));
        }


        [TestMethod]
        public void PutNumber_MultipleCorrectEntries_GetNumberReturnsCorrectNumber()
        {
            _target = new PhoneDirectory();

            _target.PutNumber("John Smith", "21345");
            _target.PutNumber("Robert Corner", "34155");
            _target.PutNumber("Admin", "5555");

            Assert.AreEqual("34155", _target.GetNumber("Robert Corner"));
        }

        [TestMethod]
        public void PutNumber_DuplicateValues_ShouldOverWriteExistingNumber()
        {
            _target = new PhoneDirectory();

            _target.PutNumber("John Smith", "first number");
            _target.PutNumber("John Smith", "second number");

            Assert.AreEqual("second number", _target.GetNumber("John Smith"));
        }

        [TestMethod]
        [DataRow("", "21345")]
        [DataRow("name", "")]
        [DataRow(null, "21345")]
        [DataRow("", null)]
        [DataRow("", "")]
        [DataRow(null, null)]
        public void PutNumber_GiveEmptyAndNullValues_ShouldThrowException(string name, string number)
        {
            _target = new PhoneDirectory();
            
            var exception = Assert.ThrowsException<Exception>(() => _target.PutNumber(name, number));

            Assert.AreEqual(exception.Message, "Name or number cannot be null or empty.");
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void GetNumber_GiveEmptyAndNullValues_ShouldThrowException(string name)
        {
            _target = new PhoneDirectory();

            Assert.ThrowsException<ArgumentNullException>(() => _target.GetNumber(name));
        }

        [TestMethod]
        public void GetNumber_NoneExistingName_ShouldThrowException()
        {
            _target = new PhoneDirectory();

            _target.PutNumber("John Smith", "first number");
            _target.PutNumber("Robert corner", "second number");

            var exception = Assert.ThrowsException<Exception>(() => _target.GetNumber("Crane Robinson"));

            Assert.AreEqual(exception.Message, "Name is non existing.");
        }
    }
}
