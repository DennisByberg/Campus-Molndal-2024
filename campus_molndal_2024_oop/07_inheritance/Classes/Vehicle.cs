using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting enginge...");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping engine...");
        }
    }
}
