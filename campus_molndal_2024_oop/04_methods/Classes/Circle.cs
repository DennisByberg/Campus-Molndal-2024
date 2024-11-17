using System;

namespace campus_molndal_2024_oop._04_methods
{
    public static class Circle
    {
        // Area = π × r 
        public static double CalculateArea(double radius) => Math.Round(Math.PI * radius * radius, 1);

        // Omkrets = 2 × π × r
        public static double CalculateCircumference(double radius) => Math.Round(2 * Math.PI * radius, 1);
    }
}
