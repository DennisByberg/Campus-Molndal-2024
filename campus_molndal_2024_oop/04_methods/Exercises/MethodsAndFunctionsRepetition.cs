using System;

namespace campus_molndal_2024_oop._04_methods
{
    public static class MethodsAndFunctionsRepetition
    {
        // Skapa en klass MathHelper med följande metoder:
        // int Add(int a, int b): Addera två heltal och returnera resultatet.
        // int Subtract(int a, int b): Subtrahera det andra talet från det första och returnera resultatet.
        // int Multiply(int a, int b): Multiplicera två heltal och returnera resultatet.
        // double Divide(int a, int b): Dividera det första talet med det andra och returnera resultatet som en double.
        public static void PrintExercise1()
        {
            Console.WriteLine(MathHelper.Add(10, 5));
            Console.WriteLine(MathHelper.Subtract(10, 5));
            Console.WriteLine(MathHelper.Multiply(10, 5));
            Console.WriteLine(MathHelper.Divide(10, 5));
        }

        // Skapa en klass Person med en metod Greet som tar en sträng name som parameter och skriver ut en hälsning.
        // Lägg till en metod Introduce som tar parametrar för namn, ålder och staden där personen bor, och skriver ut en introduktion.
        public static void PrintExercise2()
        {
            Person.Greet("Sofia");
            Person.Introduce("Dennis", 30, "Kållered");
        }

        // Skapa en klass Circle med en metod CalculateArea som tar radien som parameter och returnerar arean.
        // Lägg till en metod CalculateCircumference som beräknar och returnerar omkretsen.
        public static void PrintExercise3()
        {
            Console.WriteLine(Circle.CalculateArea(10));
            Console.WriteLine(Circle.CalculateCircumference(10));
        }

        // Skapa en klass Printer med en metod Print som överlagras för att skriva ut olika typer av data
        // (strängar, heltal och flyttal).
        public static void PrintExercise4()
        {
            PrinterHelper.Print("Hello");
            PrinterHelper.Print(1);
            PrinterHelper.Print(1.123);
        }

        // Skapa en klass TemperatureConverter med en metod ToCelsius som omvandlar
        // Fahrenheit till Celsius och en metod ToFahrenheit som omvandlar Celsius till Fahrenheit.
        public static void PrintExercise5()
        {
            Console.WriteLine(TemperatureConverter.FahrenheitToCelsius(30.1));
            Console.WriteLine(TemperatureConverter.CelsiusToFahrenheit(0));
        }
    }
}
