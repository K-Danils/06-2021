using CheckOddEven;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticsTest
{
    [TestClass]
    public class OddEvenTest
    {
        private OddEven _target;

        [TestMethod]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(8)]
        public void IsEven_EvenNum_ShouldReturnTrue(int num)
        {
            // Arrange
            _target = new OddEven();

            // Assert
            Assert.IsTrue(_target.IsEven(num));
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(7)]
        [DataRow(9)]
        [DataRow(11)]
        public void IsEven_OddNum_ShouldReturnFalse(int num)
        {
            // Arrange
            _target = new OddEven();

            // Assert
            Assert.IsFalse(_target.IsEven(num));
        }
    }
}
