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
            AccountCreator mattsAccount = new AccountCreator("Matt's account", 1000);
            AccountCreator myAccount = new AccountCreator("My Account", 0);

            mattsAccount.Withdrawal(100);
            myAccount.Deposit(100);

            Console.WriteLine(mattsAccount.Balance());
            Console.WriteLine(myAccount.Balance());

            AccountCreator A = new AccountCreator("A", 100);
            AccountCreator B = new AccountCreator("B", 0);
            AccountCreator C = new AccountCreator("C", 0);

            AccountCreator.Transfer(A, B, 50);
            AccountCreator.Transfer(B, C, 25);

            Console.WriteLine(A.Balance());
            Console.WriteLine(B.Balance());
            Console.WriteLine(C.Balance());

            Console.ReadLine();
        }
    }
}
