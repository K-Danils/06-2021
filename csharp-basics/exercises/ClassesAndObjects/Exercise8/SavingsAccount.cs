using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        readonly float _startingBalance;
        public float CurrentBalance { get; private set; }
        public float Withdrawn { get; private set; } = 0;
        public float Deposited { get; private set; } = 0;
        public float InterestEarned { get; private set; }
        private float _monthlyInterest;


        public SavingsAccount(float startingBalance, float yearlyInterest)
        {
            _startingBalance = startingBalance;
            CurrentBalance = startingBalance;
            _monthlyInterest = yearlyInterest / 12.0f;
        }

        public void Withdraw(float amount)
        {
            Withdrawn += amount;
            CurrentBalance += amount;
        }

        public void Deposit(float amount)
        {
            Deposited += amount;
            CurrentBalance -= amount;
        }

        public void AddMonthlyInterest()
        {
            float interest = (CurrentBalance * _monthlyInterest);

            InterestEarned += interest;
            CurrentBalance += interest;
        }
    }
}
