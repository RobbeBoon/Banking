using Banking.Models.Domain;
using System;

namespace Banking
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BankAccount account = new BankAccount("133-15615651-12");
            account.Deposit(200);
            WriteToConsole(account);
            account.Withdraw(100);
            WriteToConsole(account);
        }

        public static void WriteToConsole(BankAccount account)
        {
            Console.WriteLine($"Balance: {account.Balance}");
        }
    }
}
