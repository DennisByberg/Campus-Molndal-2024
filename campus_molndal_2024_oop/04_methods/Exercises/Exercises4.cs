using System;

namespace campus_molndal_2024_oop._04_methods
{
    public static class Exercises4
    {
        //Skriv en rekursiv metod SumArray som tar en array av heltal som parameter och returnerar summan av alla tal i arrayen.
        public static void PrintExercise1()
        {
            int SumArray(int[] arr, int n)
            {
                if (n <= 0)
                    return 0;

                else
                    return arr[n - 1] + SumArray(arr, n - 1);
            }

            int[] numbers = new int[] { 1, 2, 3 };
            int sum = SumArray(numbers, numbers.Length);
            Console.WriteLine($"Sum of array: {sum}");
        }
    }
}
