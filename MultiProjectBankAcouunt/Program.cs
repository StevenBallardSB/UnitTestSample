using BankAccountBuisnessLogic;
using System;
using static System.Console;

namespace MultiProjectBankAcouunt
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to Joe's Bank!");
            WriteLine("Please enter an account number: ");

            string accNum = Console.ReadLine();
            BankAccount acc = new BankAccount(accNum);

            WriteLine("\n\nEnter an amount to deposit:");
            double amount = Convert.ToDouble(ReadLine());
            acc.Deposit(amount);
            WriteLine($"The new balance is: {acc.Balance}");
            ReadKey();
        }
    }
}
