using System;
using System.Diagnostics.Contracts;

namespace CodeIf
{
    class AccountContract
    {
        private static double balance = 1000;
        private static readonly double cap = 100000;
        

        public static void Main(string[] args)
        {
            Contract.Requires(false);

            Console.WriteLine("Transaction Begins");
            Deposit(500);
            Console.WriteLine("After deposit, expects 1500 and is : " + balance);
            Withdraw(1500);
            Console.WriteLine("After Withdrawal of 1500, expects 0 and is : " + balance);
            Withdraw(1000);
            Console.WriteLine("Attempt to Withdraw more than balance, new balance is : " + balance);
            Deposit(1000000);
            Console.WriteLine("Attempt to deposit over the cap, balance remains at: " + balance);
            Console.WriteLine("Press ctrl + c to exit");
            Console.ReadLine();
        }

        public static void Deposit(double amount)
        {
            if (amount > 0 && amount < cap) { 
            balance += amount;
            }            
        }

        public static void Withdraw(double amount)
        {
            if (amount <= balance && 0 < amount) { 
            balance -= amount;
        }
        }
    }
}
