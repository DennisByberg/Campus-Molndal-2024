using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public class ColorPrinterHelper : PrinterHelper
    {
        public override void Print(int number)
        {
            // Change text color to orange
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            base.Print(number);

            // Reset the color back to default
            Console.ResetColor();
        }

        public override void Print(string text)
        {
            // Change text color to orange
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            base.Print(text);

            // Reset the color back to default
            Console.ResetColor();
        }

        public override void Print(double decimalNumber)
        {
            // Change text color to orange
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            base.Print(decimalNumber);

            // Reset the color back to default
            Console.ResetColor();
        }
    }
}
