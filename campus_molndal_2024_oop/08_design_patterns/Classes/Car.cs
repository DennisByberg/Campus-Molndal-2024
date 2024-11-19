using campus_molndal_2024_oop._08_design_patterns.Interfaces;
using System;

namespace campus_molndal_2024_oop._08_design_patterns.Classes
{
    public class Car : IVehicle
    {
        public void Drive() => Console.WriteLine("Driving the car...");
    }
}
