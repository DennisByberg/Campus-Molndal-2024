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

        // Skapa ett program som frågar användaren om deras ålder och avgör om de är en minderårig (under 18 år), en vuxen (18-64 år) eller en senior (65 år och äldre).
        public static void PrintExercise2()
        {
            try
            {
                Console.Write("Enter your age: ");
                var age = Convert.ToInt32(Console.ReadLine());

                if (age >= 65) Console.WriteLine("You are a senior");
                else if (age >= 18) Console.WriteLine("You are an adult");
                else Console.WriteLine("You are a kid");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid age");
            }
        }
    }
}
