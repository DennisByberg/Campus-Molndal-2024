using System;

namespace campus_molndal_2024_oop._05_datatypes
{
    public static class Exercises1
    {
        public static void PrintExercise1()
        {
            // Skapa en array av heltal med storleken 5.
            // Tilldela värden till arrayens element.
            int[] arr = { 10, 20, 30, 40, 50 };
            int sum = 0;

            // Beräkna och skriv ut medelvärdet av alla element i arrayen.
            foreach (var number in arr)
                sum += number;

            Console.WriteLine($"Average: {sum / arr.Length}");
        }
    }
}
