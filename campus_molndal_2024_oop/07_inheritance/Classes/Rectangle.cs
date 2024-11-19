using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }

        //CTOR
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public Rectangle() { }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle...");
        }
    }
}
