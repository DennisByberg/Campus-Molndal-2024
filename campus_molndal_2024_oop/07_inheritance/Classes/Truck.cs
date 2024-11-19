using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public class Truck : Vehicle
    {
        public Truck(string make, string model, int year) : base(make, model, year)
        { }

        public void LoadCargo()
        {
            Console.WriteLine("Loading cargo...");
        }
    }
}
