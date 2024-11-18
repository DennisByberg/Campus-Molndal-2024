using System;
using System.Text;

namespace campus_molndal_2024_oop._04_methods
{
    public static class Calculator
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => a / b;
        public static double CalculateRectangleArea(double length, double width) =>
            Math.Round(length * width, 2);
        public static double CalculateRectanglePerimeter(double length, double width) =>
            Math.Round(2 * (length * width), 2);
    }
}
