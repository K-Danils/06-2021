using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            float startingBalance = float.Parse(Console.ReadLine());
            Console.Write("Enter the annual interest rate: ");
            float yearlyInterest = float.Parse(Console.ReadLine());
            Console.Write("How long has the account been opened? ");
            int months = int.Parse(Console.ReadLine());

            SavingsAccount savingsAccount = new SavingsAccount(startingBalance, yearlyInterest);
            float amount = 0;

            for (int i = 1; i <= months; i++)
            {
                Console.Write("Enter amount deposited for month: " + i + " : ");
                amount = float.Parse(Console.ReadLine());
                savingsAccount.Deposit(amount);
                
                Console.Write("Enter amount withdrawn for month: " + i + " : ");
                amount = float.Parse(Console.ReadLine());
                savingsAccount.Withdraw(amount);

                savingsAccount.AddMonthlyInterest();
            }

            Console.WriteLine("Total deposited: {0:C2}", savingsAccount.Deposited);
            Console.WriteLine("Total withdrawn: {0:C2}", savingsAccount.Withdrawn);
            Console.WriteLine("Interest earned: {0:C2}", savingsAccount.InterestEarned);
            Console.WriteLine("Ending Balance: {0:C2}", savingsAccount.CurrentBalance);

            Console.ReadKey();
        }
    }
}
