using System;

namespace campus_molndal_2024_oop._04_methods
{
    public static class SimpleCalculator
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b)
        {
            if (b <= 0)
                throw new ArgumentException("Must be divided by atleast 1");

            return a / b;
        }
    }
}
