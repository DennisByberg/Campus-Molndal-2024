using System;

namespace campus_molndal_oop_adv._01_oop_sqlite.Classes
{
    internal class CheckingAccount : IAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }

        private decimal _balance;
        private decimal _overdraftLimit = 500m; // Default overdraft limit
        private decimal _withdrawalFee = 1.50m; // Default fee per withdrawal

        public CheckingAccount(string accountNumber, string accountHolderName, decimal initialBalance = 0)
        {
            if (initialBalance < 0)
                throw new ArgumentException("Initial balance cannot be negative.");

            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            _balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance: {_balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            decimal totalAmount = amount + _withdrawalFee;

            if (_balance - totalAmount < -_overdraftLimit)
                throw new InvalidOperationException("Insufficient funds and overdraft limit exceeded.");

            _balance -= totalAmount;
            Console.WriteLine($"Withdrew {amount:C} (Fee: {_withdrawalFee:C}). New Balance: {_balance:C}");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {_balance:C}");
            Console.WriteLine($"Overdraft Limit: {_overdraftLimit:C}");
        }

        // Optional: Adjust overdraft limit
        public void SetOverdraftLimit(decimal newLimit)
        {
            if (newLimit < 0)
                throw new ArgumentException("Overdraft limit cannot be negative.");

            _overdraftLimit = newLimit;
            Console.WriteLine($"Overdraft limit updated to {_overdraftLimit:C}.");
        }

        // Optional: Read-only access to Balance
        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
