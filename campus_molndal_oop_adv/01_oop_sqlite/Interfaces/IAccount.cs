namespace campus_molndal_oop_adv._01_oop_sqlite
{
    internal interface IAccount
    {
        string AccountNumber { get; set; }
        string AccountHolderName { get; set; }

        void Withdraw(decimal amount);
        void Deposit(decimal amount);
        void DisplayAccountInfo();
    }
}
