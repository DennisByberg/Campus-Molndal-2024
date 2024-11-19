using System;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public class Database
    {
        private static Database instance;

        private Database() { }

        public static Database GetInstance()
        {
            return instance ?? (instance = new Database());
        }

        public void Connect()
        {
            Console.WriteLine("Connected to the database");
        }
    }
}
