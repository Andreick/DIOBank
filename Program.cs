using System;
using System.Collections.Generic;
using Classes;

namespace DIOBank
{
    class Program
    {
        static List<Account> accounts = new List<Account>();
        static void Main(string[] args)
        {
            Console.WriteLine("DIO Bank at your service!");

            string userOption = GetUserOption();

            while (userOption != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListAccounts();
                        break;
                    case "2":
                        NewAccount();
                        break;
                    case "3":
                        Transfer();
                        break;
                    case "4":
                        Withdraw();
                        break;
                    case "5":
                        Deposit();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = GetUserOption();
            }

            Console.WriteLine("Thank you for using our services.");
        }

        private static void Transfer()
        {
            Console.Write("Enter the source account number: ");
            int sourceAccountIndex = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter the target account number: ");
            int targetAccountIndex = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter the transfer amount: ");
            double transferValue = double.Parse(Console.ReadLine());

            accounts[sourceAccountIndex].Transfer(transferValue, accounts[targetAccountIndex]);
        }

        private static void Deposit()
        {
            Console.Write("Enter the account number: ");
            int accountIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter the deposit amount: ");
            double depositValue = double.Parse(Console.ReadLine());

            Console.WriteLine();
            accounts[accountIndex - 1].Deposit(depositValue);
        }

        private static void Withdraw()
        {
            Console.Write("Enter the account number: ");
            int accountIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter the withdraw amount: ");
            double withdrawValue = double.Parse(Console.ReadLine());

            Console.WriteLine();
            accounts[accountIndex - 1].Withdraw(withdrawValue);
        }

        private static void ListAccounts()
        {
            Console.WriteLine("List accounts");

            if(accounts.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("There're no registered accounts.");
                return;
            }

            for (int i = 0; i < accounts.Count; i++)
            {
                Console.WriteLine();
                Account account = accounts[i];
                Console.WriteLine($"Account #{i + 1}:");
                Console.WriteLine(account);
            }
        }

        private static void NewAccount()
        {
            Console.WriteLine("Insert new account");
            Console.WriteLine();
            Console.Write("Enter 1 for natural person or 2 for juridic person: ");
            AccountType accountType = (AccountType) int.Parse(Console.ReadLine());

            Console.Write("Enter the customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the initial balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Enter the credit: ");
            double credit = double.Parse(Console.ReadLine());

            Account newAccount = new Account(accountType: accountType, balance: balance, credit: credit, name: name);

            accounts.Add(newAccount);

            Console.WriteLine();
            Console.WriteLine("Account successfully created");
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the desired option:");

            Console.WriteLine("1 - List accounts");
            Console.WriteLine("2 - New account");
            Console.WriteLine("3 - Transfer");
            Console.WriteLine("4 - Withdraw");
            Console.WriteLine("5 - Deposit");
            Console.WriteLine("C - Clear window");
            Console.WriteLine("X - Exit");
            Console.WriteLine();

            Console.Write("Option: ");
            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}
