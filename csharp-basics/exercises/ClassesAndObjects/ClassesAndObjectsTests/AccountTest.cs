using System;
using Account;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesAndObjectsTests
{
    [TestClass]
    public class AccountTest
    {
        AccountCreator _target;

        [TestMethod]
        [DataRow(-20, 70)]
        [DataRow(20, 70)]
        [DataRow(13.4, 76.6)]
        [DataRow(50, 40)]
        public void Withdraw_VariusAmounts_BalanceShouldChangeToExpectedAmount(double amount, double expectedAmount)
        {
            _target = new AccountCreator("a", 90);

            _target.Withdrawal(amount);

            Assert.AreEqual(expectedAmount, _target.Balance());
        }

        [TestMethod]
        [DataRow(40, 130)]
        [DataRow(13.4, 103.4)]
        public void Deposit_20_ShouldHaveBalanceOf110(double amount, double expectedAmount)
        {
            _target = new AccountCreator("a", 90);

            _target.Deposit(amount);

            Assert.AreEqual(expectedAmount, _target.Balance());
        }

        [TestMethod]
        public void ToString_AccountCreatorInstance_ReturnsInstanceInformation()
        {
            _target = new AccountCreator("Robert Smith", 90);

            Assert.AreEqual("Robert Smith: 90", _target.ToString());
        }

        [TestMethod]
        public void Transfer_AccountA_AccountB_Transfer50_AccountBHasBalanceOf50AccountABalanceOf40()
        {
            AccountCreator A = new AccountCreator("Robert Smith", 90);
            AccountCreator B = new AccountCreator("Smithers Robertson", 0);

            AccountCreator.Transfer(A, B, 50);

            Assert.AreEqual(40, A.Balance());
            Assert.AreEqual(50, B.Balance());
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void AccountCreator_EmptyAndNullName_ThrowsException(string name)
        {
            var exception = Assert.ThrowsException<Exception>(() => new AccountCreator(name, 10));

            Assert.AreEqual(exception.Message, "Name cannot be empty or null");
        }

        [TestMethod]
        public void Withdraw_ImpossibleAmount_ThrowsException()
        {
            _target = new AccountCreator("a", 10);

            var exception = Assert.ThrowsException<Exception>(() => _target.Withdrawal(20));

            Assert.AreEqual(exception.Message, "Not enough money");
        }

        [TestMethod]
        public void Deposit_NegativeValue_ThrowsException()
        {
            _target = new AccountCreator("a", 10);

            var exception = Assert.ThrowsException<Exception>(() => _target.Deposit(-20));

            Assert.AreEqual(exception.Message, "Negative values used");
        }
    }
}
