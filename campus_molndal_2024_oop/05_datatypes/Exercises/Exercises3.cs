using System;

namespace campus_molndal_2024_oop._05_datatypes
{
    public static class Exercises3
    {
        // 1. Skapa en array med minst fem heltal.
        // 2. Implementera Bubble Sort för att sortera arrayen i stigande ordning.
        // 3. Skriv ut arrayen före och efter sortering.
        public static void PrintExercise1()
        {
            int[] numbers = new int[] { 32, 64, 33, 75, 21 };

            Console.WriteLine("Array before sorting:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            SortHelper.BubbleSort(numbers);

            Console.WriteLine("\nArray after sorting:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
