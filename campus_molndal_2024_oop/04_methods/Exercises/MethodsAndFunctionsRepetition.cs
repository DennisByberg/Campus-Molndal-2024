using System;
using System.Security.Cryptography;
using System.Text;

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

        // Skapa en C#-klass med namnet Calculator.
        // I klassen, definiera metoderna Add, Subtract, Multiply, och Divide,
        // som alla tar två int-parametrar och returnerar resultatet som en int.
        // Skapa en Main-metod där du anropar varje metod och skriver ut resultaten.
        public static void PrintExercise6()
        {
            Console.WriteLine(Calculator.Add(10, 10));
            Console.WriteLine(Calculator.Subtract(10, 5));
            Console.WriteLine(Calculator.Multiply(10, 2));
            Console.WriteLine(Calculator.Divide(20, 2));
        }

        // Skapa en metod CalculateArea som tar två double-parametrar, length och width, och returnerar arean som en double.
        // Skapa en metod CalculatePerimeter som tar samma parametrar och returnerar omkretsen som en double.
        // Anropa dessa metoder från Main och skriv ut resultaten.
        public static void PrintExercise7()
        {
            Console.WriteLine(Calculator.CalculateRectangleArea(10, 5));
            Console.WriteLine(Calculator.CalculateRectanglePerimeter(10, 5));
        }

        // Definiera en metod PrintMessage som tar en string och skriver ut den till konsolen.
        // Skapa en överlagrad version av PrintMessage som tar två string-parametrar och skriver ut dem på samma rad.
        // Anropa båda versionerna av PrintMessage från Main.
        public static void PrintExercise8()
        {
            PrinterHelper.Print("Hello");
            PrinterHelper.Print("Hello", "World");
        }
    }
}
