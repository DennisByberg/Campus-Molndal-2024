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

        // Skapa ett program som använder en do-while-loop för att skriva ut en meny för en enkel kalkylator och be användaren välja en operation tills de väljer att avsluta.
        public static void PrintExercise2()
        {
            int choice;

            do
            {
                Console.WriteLine("1) Use Calculator");
                Console.WriteLine("2) Exit");
                Console.Write("> ");

                bool isValidInput = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number (1 or 2).");
                    continue; // Skip to the next iteration of the loop
                }

                if (choice == 1)
                {
                    Console.WriteLine("Calculator feature is not implemented yet.");
                }

                else if (choice == 2)
                {
                    Console.WriteLine("Press any key to exit...");
                    break; // Exit the loop
                }

                else
                {
                    Console.WriteLine("Please choose a valid option (1 or 2).");
                }

            } while (true);
        }
    }
}