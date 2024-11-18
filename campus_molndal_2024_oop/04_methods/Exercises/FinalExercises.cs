using System;

namespace campus_molndal_2024_oop._04_methods
{
    public static class FinalExercises
    {
        // Skapa en klass SimpleCalculator som innehåller metoder för att addera, subtrahera, multiplicera och dividera två tal.Varje metod ska ta två parametrar och returnera resultatet.
        // Implementera en Main-metod som anropar alla dessa metoder med olika tal och skriver ut resultaten.
        public static void PrintExercise1()
        {
            Console.WriteLine(SimpleCalculator.Add(10, 5));
            Console.WriteLine(SimpleCalculator.Subtract(10, 5));
            Console.WriteLine(SimpleCalculator.Multiply(10, 5));
            Console.WriteLine(SimpleCalculator.Divide(10, 5));
        }
    }
}
