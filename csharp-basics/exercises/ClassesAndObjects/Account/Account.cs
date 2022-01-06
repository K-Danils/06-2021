using System;

namespace Account
{
    public class AccountCreator
    {
        private double _money;
        public string Name { get; private set; }

        public AccountCreator(string v1, double v2)
        {
            Name = !String.IsNullOrEmpty(v1) ? v1 : throw new Exception("Name cannot be empty or null");

            _money = v2;
        }

        public double Withdrawal(double i)
        {
            // in case negative value is used for i, turn it to positive
            i = i < 0 ? i * -1 : i;

            _money = _money - i > 0 ?  _money -= i : throw new Exception("Not enough money");

            return _money;
        }

        public void Deposit(double i)
        {
            if (i < 0) { throw new Exception("Negative values used"); }

            _money += i;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{Name}: {_money}";
        }
    }
}
