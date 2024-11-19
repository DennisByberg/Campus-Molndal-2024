using campus_molndal_2024_oop._08_design_patterns.Interfaces;
using System;

namespace campus_molndal_2024_oop._08_design_patterns.Classes
{
    public sealed class VehicleFactorySingleton
    {
        private static VehicleFactorySingleton instance;

        private VehicleFactorySingleton() { }

        public static VehicleFactorySingleton GetInstance()
        {
            return instance ?? (instance = new VehicleFactorySingleton());
        }

        public IVehicle CreateVehicle(string type)
        {
            if (type.Equals("Car", StringComparison.OrdinalIgnoreCase))
            {
                return new Car();
            }
            else if (type.Equals("Bicycle", StringComparison.OrdinalIgnoreCase))
            {
                return new Bicycle();
            }
            return null;
        }
    }
}
