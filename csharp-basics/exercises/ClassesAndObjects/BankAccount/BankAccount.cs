using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        public string name { get; private set; }
        public float balance { get; private set; }

        public BankAccount(string name, float balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void ShowUserNameAndBalance()
        {
            if (balance > 0) { Console.WriteLine("{0}, {1:C2}", name, balance); }
            else
            {
                float tempBalance = balance * -1;
                Console.WriteLine("{0}, -{1:C2}", name, tempBalance);

            }
        }
    }
}
