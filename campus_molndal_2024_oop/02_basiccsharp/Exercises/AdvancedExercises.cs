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

        public static void PrintExercise2()
        {
            Console.Write("Enter the number of terms for the Fibonacci sequence: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int totalTerms);

            if (!isValid || totalTerms <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int prevNumber = 0, currentNumber = 1;

            Console.WriteLine($"Fibonacci sequence with {totalTerms} terms:");

            for (int i = 0; i < totalTerms; i++)
            {
                Console.Write(prevNumber + " ");

                int nextNumber = prevNumber + currentNumber;
                prevNumber = currentNumber;
                currentNumber = nextNumber;
            }

            Console.WriteLine();
        }
    }
}