using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private string _name;
        private float _balance;

        public BankAccount(string name, float balance)
        {
            _name = name;
            _balance = balance;
        }

        public void PrintUserNameAndBalance()
        {
            if (_balance > 0) { Console.WriteLine("{0}, {1:C2}", _name, _balance); }
            else
            {
                float tempBalance = _balance * -1;
                Console.WriteLine("{0}, -{1:C2}", _name, tempBalance);
            }
        }
    }
}
