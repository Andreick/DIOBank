using System;

namespace Classes
{
    public class Account
    {
        public Account(AccountType accountType, string name, double balance, double credit)
        {
            this.Name = name;
            this.Balance = balance;
            this.Credit = credit;
            this.AccountType = accountType;
        }

        private string Name { get; set; }

        private double Balance { get; set; }

        private double Credit { get; set; }

        private AccountType AccountType { get; set; }

        public bool WithDraw(double withDrawValue)
        {
            if (withDrawValue <= 0)
            {
                Console.WriteLine("You can't withdraw a value less than or equal to zero");
                return false;
            }

            if (withDrawValue < (Balance + Credit))
            {
                Console.WriteLine("Insufficient balance!");
                return false;
            }

            Balance -= withDrawValue;
            Console.WriteLine($"The Current balance of {Name} is {Balance}");
            return true;
        }

        public bool Deposit(double depositValue)
        {
            if (depositValue <= 0)
            {
                Console.WriteLine("You can't deposit a value less than or equal to zero");
                return false;
            }

            Balance += depositValue;
            Console.WriteLine($"The Current balance of {Name} is {Balance}");
            return true;
        }

        public bool Transfer(double transferValue, Account targetAccount)
        {
            if (WithDraw(transferValue))
            {
                return Deposit(transferValue);
            }

            return false;
        }

        public override string ToString()
        {
            string returns = "";
            returns += $"Account type: {AccountType}\n";
            returns += $"Name: {Name}\n";
            returns += $"Balance: {Balance.ToString("C")}\n";
            returns += $"Credit: {Credit.ToString("C")}\n";
            return returns;
        }
    }
}