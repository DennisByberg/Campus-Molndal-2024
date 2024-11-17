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

        //Skapa en metod TransferFunds(BankAccount from, BankAccount to, double amount) som överför pengar från ett konto till ett annat.
        public void TransferFunds(BankAccount from, BankAccount to, double amount)
        {
            from._balance -= amount;
            to._balance += amount;
        }
    }
}
