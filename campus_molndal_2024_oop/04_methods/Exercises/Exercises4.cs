using campus_molndal_2024_oop._03_repetition_classes_objects;
using System;
using System.Reflection;
using System.Xml.Linq;

namespace campus_molndal_2024_oop._04_methods
{
    public static class Exercises4
    {
        // Skriv en rekursiv metod SumArray som tar en array av heltal
        // som parameter och returnerar summan av alla tal i arrayen.
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

        // Skriv en rekursiv metod Gcd som tar två heltal som parametrar
        // och returnerar den största gemensamma delaren(GCD) med hjälp av Euklides algoritm.
        public static void PrintExercise2()
        {
            int Gcd(int a, int b)
            {
                if (b == 0) return a;
                else return Gcd(b, a % b);
            }
            Console.WriteLine(Gcd(48, 18));
        }

        // Implementera en rekursiv version av binärsökning som söker efter ett
        // element i en sorterad array och returnerar dess index eller -1 om det inte finns.
        public static void PrintExercise3()
        {
            int BinarySearch(int[] array, int left, int right, int target)
            {
                // Kontrollera om sökintervallet är giltigt
                if (right >= left)
                {
                    // Beräkna mittenindexet för att dela upp arrayen
                    int middle = left + (right - left) / 2;

                    // Om målet finns vid mittenindexet, returnera indexet
                    if (array[middle] == target)
                        return middle;

                    // Om målet är mindre än mittenelementet,
                    // sök i den vänstra halvan av arrayen
                    if (array[middle] > target)
                        return BinarySearch(array, left, middle - 1, target);

                    // Om målet är större än mittenelementet,
                    // sök i den högra halvan av arrayen
                    return BinarySearch(array, middle + 1, right, target);
                }

                // Om målet inte hittas, returnera -1
                return -1;
            }
        }
    }
}
