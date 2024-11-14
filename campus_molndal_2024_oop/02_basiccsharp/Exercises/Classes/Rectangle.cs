namespace campus_molndal_2024_oop._02_basiccsharp
{
    public class Rectangle
    {
        private readonly int Height = 0;
        private readonly int Width = 0;

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public void CalculateAndPrintArea()
        {
            var area = Height * Width;
            System.Console.WriteLine($"The area is: {area}");
        }
    }
}