using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace campus_molndal_2024_oop._05_datatypes
{
    public static class FInalExercises
    {
        // 1. Skapa en array med fem olika heltal.
        // 2. Skriv en metod som tar denna array som indata och returnerar summan av alla heltal i arrayen.
        // 3. Skriv en annan metod som räknar antalet jämna tal i arrayen och returnerar detta antal.
        // 4. Lägg till en metod som hittar det minsta värdet i arrayen och returnerar det.
        // 5. Se till att metoderna fungerar oavsett vilka tal som finns i arrayen.
        // 6. Testa metoderna genom att anropa dem från main-metoden och skriv ut resultaten.
        public static void PrintExercise1()
        {
            Console.WriteLine("--- FIRST TEST: { 1, 2, 3, 4, 5 } ---");
            var numbers = new int[5] { 1, 2, 3, 4, 5 };
            var sum = ArrayHelper.SumArray(numbers);
            var evenNumbers = ArrayHelper.EvenNumberCounter(numbers);
            var smallestNumber = ArrayHelper.GetSmallestNumberInArray(numbers);
            Console.WriteLine($"sum of numbers: {sum}");
            Console.WriteLine($"even numbers in numbers: {evenNumbers}");
            Console.WriteLine($"smallest number in numbers: {smallestNumber}");

            Console.WriteLine("\n--- SECOND TEST: { 73, 23, 33, 11, 2 } ---");
            var numbers2 = new int[5] { 73, 23, 33, 11, 2 };
            var sum2 = ArrayHelper.SumArray(numbers2);
            var evenNumbers2 = ArrayHelper.EvenNumberCounter(numbers2);
            var smallestNumber2 = ArrayHelper.GetSmallestNumberInArray(numbers2);
            Console.WriteLine($"sum of numbers: {sum2}");
            Console.WriteLine($"even numbers in numbers: {evenNumbers2}");
            Console.WriteLine($"smallest number in numbers: {smallestNumber2}");
        }
    }
}
