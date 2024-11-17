namespace campus_molndal_2024_oop._04_methods
{
    public static class TemperatureConverter
    {
        // Skapa en klass TemperatureConverter med en metod ToCelsius som omvandlar
        // Fahrenheit till Celsius och en metod ToFahrenheit som omvandlar Celsius till Fahrenheit.
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (5.0 / 9.0) * (fahrenheit - 32);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (9.0 / 5.0) * celsius + 32;
        }
    }
}
