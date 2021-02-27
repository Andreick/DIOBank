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
                        break;
                    case "4":
                        break;
                    case "5":
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
