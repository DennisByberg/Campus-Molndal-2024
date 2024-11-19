using campus_molndal_2024_oop._08_design_patterns.Interfaces;
using System;

namespace campus_molndal_2024_oop._08_design_patterns.Classes
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string typeOfVehicle)
        {
            if (typeOfVehicle.Equals("Car", StringComparison.OrdinalIgnoreCase))
                return new Car();

            else if (typeOfVehicle.Equals("Bicycle", StringComparison.OrdinalIgnoreCase))
                return new Bicycle();

            return null;
        }
    }
}
