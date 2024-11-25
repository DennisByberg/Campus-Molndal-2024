using System;

namespace campus_molndal_oop_adv._01_oop_sqlite.Classes
{
    internal class SavingsAccount : IAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }

        private decimal _balance;
        private readonly decimal _interestRate; // Annual interest rate (e.g., 0.03 for 3%)
        private int _withdrawalLimit; // Max allowed withdrawals per period
        private int _currentWithdrawals; // Track withdrawals in the current period
        private decimal _minimumBalance; // Minimum balance required to maintain

        public SavingsAccount(string accountNumber, string accountHolderName, decimal initialBalance, decimal interestRate, int withdrawalLimit = 6, decimal minimumBalance = 100)
        {
            if (initialBalance < minimumBalance)
                throw new ArgumentException($"Initial balance must be at least {minimumBalance:C}.");

            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            _balance = initialBalance;
            _interestRate = interestRate;
            _withdrawalLimit = withdrawalLimit;
            _minimumBalance = minimumBalance;
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

            if (_currentWithdrawals >= _withdrawalLimit)
                throw new InvalidOperationException("Withdrawal limit exceeded for this period.");

            if (_balance - amount < _minimumBalance)
                throw new InvalidOperationException("Withdrawal would reduce balance below the minimum required.");

            _balance -= amount;
            _currentWithdrawals++;
            Console.WriteLine($"Withdrew {amount:C}. New Balance: {_balance:C}");
        }

        public void ApplyInterest()
        {
            decimal interest = _balance * _interestRate;
            _balance += interest;
            Console.WriteLine($"Interest of {interest:C} applied. New Balance: {_balance:C}");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {_balance:C}");
            Console.WriteLine($"Annual Interest Rate: {_interestRate:P}");
            Console.WriteLine($"Withdrawal Limit: {_withdrawalLimit} (Used: {_currentWithdrawals})");
            Console.WriteLine($"Minimum Balance: {_minimumBalance:C}");
        }

        // Reset the withdrawal count (e.g., monthly reset)
        public void ResetWithdrawals()
        {
            _currentWithdrawals = 0;
            Console.WriteLine("Withdrawal count has been reset for the period.");
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
