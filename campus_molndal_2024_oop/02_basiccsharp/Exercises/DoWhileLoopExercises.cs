using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class DoWhileLoopExercises
    {
        // Skriv ett program som använder en do-while-loop för att upprepat fråga användaren om en siffra tills de matar in ett negativt tal.
        public static void PrintExercise1()
        {
            int userInput = 0;

            do
            {
                Console.Write("Enter a number: ");
                int.TryParse(Console.ReadLine(), out userInput);

            } while (userInput >= 0);

            Console.WriteLine("Press any key to exit...");
        }
    }
}