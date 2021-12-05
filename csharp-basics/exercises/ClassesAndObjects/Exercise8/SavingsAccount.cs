using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        private float _startingBalance { get; }
        public float currentBalance { get; private set; }
        public float withdrawn { get; private set; } = 0;
        public float deposited { get; private set; } = 0;
        public float interestEarned { get; private set; }
        float monthlyInterest;


        public SavingsAccount(float startingBalance, float yearlyInterest)
        {
            _startingBalance = startingBalance;
            currentBalance = startingBalance;
            monthlyInterest = yearlyInterest / 12.0f;
        }

        public void Withdraw(float amount)
        {
            withdrawn += amount;
            currentBalance += amount;
        }

        public void Deposit(float amount)
        {
            deposited += amount;
            currentBalance -= amount;
        }

        public void AddMonthlyInterest()
        {
            float interest = (currentBalance * monthlyInterest);

            interestEarned += interest;
            currentBalance += interest;
        }
    }
}
