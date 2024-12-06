using System;

namespace ConsoleApp6
{
    public class BankAccount // Task 2
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} USD. New balance: {Balance} USD");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InsufficientFundsException("Insufficient funds for this withdrawal.");

            Balance -= amount;
            Console.WriteLine($"Withdrew {amount} USD. Remaining balance: {Balance} USD");
        }
    }

    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    public static class Task2BankAccount
    {
        public static void Run()
        {
            Console.WriteLine("Enter account number:");
            string accountNumber = Console.ReadLine();

            Console.WriteLine("Enter initial balance:");
            decimal initialBalance;
            while (!decimal.TryParse(Console.ReadLine(), out initialBalance) || initialBalance < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative decimal value for the initial balance:");
            }

            var account = new BankAccount(accountNumber, initialBalance);
            Console.WriteLine($"Account created with Account Number: {account.AccountNumber} and Balance: {account.Balance} USD");

            while (true)
            {
                Console.WriteLine("Choose an operation (1, 2 or 3):");
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - Exit");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        Console.WriteLine("Enter amount to deposit:");
                        decimal depositAmount;
                        while (!decimal.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive decimal value for the deposit amount:");
                        }
                        account.Deposit(depositAmount);
                        break;

                    case 2: 
                        Console.WriteLine("Enter amount to withdraw:");
                        decimal withdrawalAmount;
                        while (!decimal.TryParse(Console.ReadLine(), out withdrawalAmount) || withdrawalAmount <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive decimal value for the withdrawal amount:");
                        }

                        try
                        {
                            account.Withdraw(withdrawalAmount);
                        }
                        catch (InsufficientFundsException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;

                    case 3: 
                        Console.WriteLine("Goodbye!");
                        return;

                    default: 
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}
