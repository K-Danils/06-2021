using exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticsTest
{
    [TestClass]
    public class CheckFifteenTest
    {
        private CheckFifteen _target = new CheckFifteen();

        [TestMethod]
        [DataRow(15, 10)]
        [DataRow(30, 15)]
        [DataRow(7, 8)]
        public void IsFifteen_NumbersThatResultIn15_ReturnsTrue(int num1, int num2)
        {
            Assert.IsTrue(_target.IsFifteen(num1, num2));
        }

        [TestMethod]
        [DataRow(-15, 10)]
        [DataRow(10, 10)]
        public void IsFifteen_NumbersThatDontIn15_10_False(int num1, int num2)
        {
            Assert.IsFalse(_target.IsFifteen(num1, num2));
        }
    }
}