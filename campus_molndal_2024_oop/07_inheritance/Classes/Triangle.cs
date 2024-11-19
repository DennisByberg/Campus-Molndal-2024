using System;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return (Base * Height) / 2;
        }
    }
}
