using System;

namespace campus_molndal_2024_oop._04_methods
{
    public static class MathHelper
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static double Divide(int a, int b) => a / b;

        public static int SumNumbers(int n)
        {
            if (n <= 0)
                return 0;

            return n + SumNumbers(n - 1);
        }
    }
}
