using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class IfElseExercises
    {
        // Skriv ett program som kontrollerar om ett tal är jämnt eller udda.
        // Använd en if-else-sats för att skriva ut ett meddelande om talet är jämnt eller udda.
        public static void PrintExercise1()
        {
            int x = 9;

            if (x % 2 == 0) Console.WriteLine("Number is even");
            else Console.WriteLine("Number is odd");
        }
    }
}
