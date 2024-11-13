using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class WhileLoopExercises
    {
        // Skriv ett program som använder en while-loop för att skriva ut alla jämna tal mellan 1 och 20.
        public static void PrintExercise1()
        {
            var number = 1;

            while (number <= 20)
            {
                if (number % 2 == 0) Console.WriteLine(number);

                number++;
            }
        }

        // Skapa ett program som använder en while-loop för att gissa ett tal mellan 1 och 100 som användaren har valt. Låt användaren ange om gissningen är för hög, för låg, eller korrekt.
        public static void PrintExercise2()
        {
            int guess = 67;
            int low = 1;
            int high = 100;
            bool correct = false;

            while (!correct)
            {
                correct = true;
                Console.WriteLine("Gissning: " + guess);
            }
        }
    }
}