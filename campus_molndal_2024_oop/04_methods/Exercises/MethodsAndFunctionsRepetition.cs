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
            var person = new Person();
            person.Greet("Sofia");
            person.Introduce("Dennis", 30, "Kållered");
        }
    }
}
