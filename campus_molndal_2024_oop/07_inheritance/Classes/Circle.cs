using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        //CTOR
        public Circle(double radius)
        {
            Radius = radius;
        }

        //CTOR
        public Circle() { }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a circle...");
        }
    }
}
