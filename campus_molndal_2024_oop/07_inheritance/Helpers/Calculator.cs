using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public static class Calculator
    {
        public static int Multiply(int a, int b) => a * b;
        public static double Multiply(double a, double b) => Math.Round(a * b, 2);
    }
}
