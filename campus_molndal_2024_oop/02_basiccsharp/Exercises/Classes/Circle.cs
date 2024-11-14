using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    internal class Circle
    {
        private readonly double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        //Omkrets=2×π×r
        public double CalculateCircumference()
        {
            return Math.Round(2 * Math.PI * Radius, 1);
        }
    }
}