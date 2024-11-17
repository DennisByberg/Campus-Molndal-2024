using System;
using System.Security.Cryptography;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class BankAccount
    {
        private string _accountNumber;
        private double _balance;

        public BankAccount(string accountNumber, double balance)
        {
            _accountNumber = accountNumber;
            _balance = balance;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            // Implementera en metod Withdraw(double amount) som minskar saldot med det angivna beloppet om det finns tillräckligt med pengar, annars skriv ut ett felmeddelande.
            if (_balance < amount)
                Console.WriteLine("Balance is to low for the given withdraw amount");
            else
                _balance -= amount;
        }

        //Skapa en metod TransferFunds(BankAccount from, BankAccount to, double amount) som överför pengar från ett konto till ett annat.
        public void TransferFunds(BankAccount from, BankAccount to, double amount)
        {
            from._balance -= amount;
            to._balance += amount;
        }
    }
}
