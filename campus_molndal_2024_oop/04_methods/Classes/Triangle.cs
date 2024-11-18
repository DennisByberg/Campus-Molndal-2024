namespace campus_molndal_2024_oop._04_methods
{
    public class Triangle
    {
        private double _base;
        private double _height;

        public Triangle(double @base, double height)
        {
            _base = @base;
            _height = height;
        }

        public Triangle() : this(1, 1)
        { }

        public double CalculateArea()
        {
            return 0.5 * _base * _height;
        }
    }
}
