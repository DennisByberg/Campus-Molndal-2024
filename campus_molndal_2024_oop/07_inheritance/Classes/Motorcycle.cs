using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string make, string model, int year) : base(make, model, year)
        { }

        public void PopWheelie()
        {
            Console.WriteLine("Popping wheelie...");
        }
    }
}
