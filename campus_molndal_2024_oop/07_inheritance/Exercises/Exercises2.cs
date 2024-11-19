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
    }
}
