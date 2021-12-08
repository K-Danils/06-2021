using System;

namespace Account
{
    class Account
    {
        private double _money;
        public string Name { get; private set; }

        public Account(string v1, double v2)
        {
            Name = v1;
            _money = v2;
        }

        public double Withdrawal(double i)
        {
            if (_money - i > 0) { _money -= i; }
            else { Console.WriteLine("Not enough money"); }
            return _money;
        }

        public void Deposit(double i)
        {
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
