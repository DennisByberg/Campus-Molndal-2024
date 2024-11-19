using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public abstract class Shape
    {
        public abstract double CalculateArea();

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape...");
        }
    }
}
