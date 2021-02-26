using System;
using Classes;

namespace DIOBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIO Bank at your service!");

            string userOption = GetUserOption();

            while (userOption != "X")
            {
                switch (userOption)
                {
                    case "1":
                        break;
                    case "2":
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

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}
