using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Rectangle
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double CalculateArea()
        {
            return Math.Round(_height * _width, 1);
        }

        public double CalculatePerimeter()
        {
            return Math.Round(2 * (_height + _width), 1);
        }
    }
}
