using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public class PrinterHelper
    {
        public virtual void Print(int number)
        {
            Console.WriteLine(number);
        }

        public virtual void Print(string text)
        {
            Console.WriteLine(text);
        }

        public virtual void Print(double decimalNumber)
        {
            Console.WriteLine(decimalNumber);
        }
    }
}
