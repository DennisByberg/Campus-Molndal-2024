using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class ForLoopExercises
    {
        // Skriv en for-loop som skriver ut alla heltal från 1 till 10.
        public static void PrintExercise1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Skriv ett program som använder en for-loop för att beräkna och skriva ut summan av alla tal från 1 till 100.
        public static void PrintExercise2()
        {
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum from 1-100 is {sum}");
        }
    }
}
