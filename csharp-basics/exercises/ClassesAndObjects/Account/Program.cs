using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class TransferMoney
    {
        public static void Transfer(AccountCreator from, AccountCreator to, double howMuch)
        {
            if (howMuch < 0) { throw new Exception("Can not transfer negative values"); }
            to.Deposit(howMuch);
            from.Withdrawal(howMuch);
        }
    }

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

            TransferMoney.Transfer(A, B, 50);
            TransferMoney.Transfer(B, C, 25);

            Console.WriteLine(A.Balance());
            Console.WriteLine(B.Balance());
            Console.WriteLine(C.Balance());

            Console.ReadLine();
        }
    }
}
