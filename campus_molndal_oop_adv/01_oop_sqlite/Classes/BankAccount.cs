using System;

namespace campus_molndal_oop_adv._01_oop_sqlite.Classes
{
    internal class BankAccount : IAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }

        private decimal _balance;

        public BankAccount(string accountNumber, string accountHolderName, decimal balance)
        {
            if (balance < 0)
                throw new ArgumentException("Initial balance cannot be negative.");

            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            _balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            _balance += amount;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"AccountNumber: {AccountNumber}, AccountHolderName: {AccountHolderName}, Balance: {_balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (_balance < amount) throw new ArgumentException("Not enough balance");

            _balance -= amount;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
