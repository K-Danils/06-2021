using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account mattsAccount = new Account("Matt's account", 1000);
            Account myAccount = new Account("My Account", 0);

            mattsAccount.Withdrawal(100);
            myAccount.Deposit(100);

            Console.WriteLine(mattsAccount.Balance());
            Console.WriteLine(myAccount.Balance());

            Account A = new Account("A", 100);
            Account B = new Account("B", 0);
            Account C = new Account("C", 0);

            Transfer(A, B, 50);
            Transfer(B, C, 25);

            Console.WriteLine(A.Balance());
            Console.WriteLine(B.Balance());
            Console.WriteLine(C.Balance());

            Console.ReadLine();
        }

        public static void Transfer(Account from,Account to, double howMuch)
        {
            to.Deposit(howMuch);
            from.Withdrawal(howMuch);
        }
    }
}
