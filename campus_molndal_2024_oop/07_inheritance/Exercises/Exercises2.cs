using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public static class Exercises2
    {
        // 1. Skapa en klass Calculator med överlagrade metoder Multiply().
        // 2. En metod ska multiplicera två heltal och en annan ska multiplicera två decimaltal.
        // 3. Implementera metoderna och testa dem genom att skapa ett objekt av Calculator-klassen och anropa båda versionerna av Multiply().
        public static void PrintExercise1()
        {
            Console.WriteLine(Calculator.Multiply(3, 3));
            Console.WriteLine(Calculator.Multiply(3.5, 3.5));
        }

        // 1. Skapa en basklass Shape med en metod Draw().
        // 2. Skapa två underklasser Circle och Rectangle som överskuggar Draw()-metoden med specifika implementeringar för att rita cirklar och rektanglar.
        // 3. Skapa ett objekt av varje underklass och anropa deras Draw()-metoder genom en variabel av typen Shape.
        public static void PrintExercise2()
        {
            var circle = new Circle();
            var rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();
        }
    }
}
