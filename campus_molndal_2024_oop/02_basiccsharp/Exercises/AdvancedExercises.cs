using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class AdvancedExercises
    {
        // Skriv ett program som använder en for-loop för att generera alla primtal mellan 1 och 100 och skriver ut dem.
        public static void PrintExercise1()
        {
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.WriteLine(i + " är ett primtal.");
            }
        }
    }
}
