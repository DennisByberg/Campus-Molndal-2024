using campus_molndal_2024_oop._03_repetition_classes_objects;
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

        //Skriv en rekursiv metod Gcd som tar två heltal som parametrar och returnerar den största gemensamma delaren(GCD) med hjälp av Euklides algoritm.
        public static void PrintExercise2()
        {
            int Gcd(int a, int b)
            {
                if (b == 0) return a;
                else return Gcd(b, a % b);
            }

            Console.WriteLine(Gcd(48, 18));
        }
    }
}
