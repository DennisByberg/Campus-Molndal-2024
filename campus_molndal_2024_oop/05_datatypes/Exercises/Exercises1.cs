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

        public static void PrintExercise2()
        {
            // Skapa en array med heltal.
            int[] numbers = { 10, 20, 30, 40, 50, 32, 1, 3 };
            int[] numbers2 = { 193, 32, 2, 15, 92, 44, 22, 16 };
            // Skriv en metod för att hitta och returnera det största värdet i arrayen.
            var biggestNumber = ArrayHelper.GetBiggestNumberInArray(numbers);
            var biggestNumber2 = ArrayHelper.GetBiggestNumberInArray(numbers2);
            // Skriv en metod för att hitta och returnera det minsta värdet i arrayen.
            var smallestNumber = ArrayHelper.GetSmallestNumberInArray(numbers);
            var smallestNumber2 = ArrayHelper.GetSmallestNumberInArray(numbers2);
            // Testa metoderna med några olika värden.
            Console.WriteLine("--- numbers ---");
            Console.WriteLine($"biggestNumber: {biggestNumber}");
            Console.WriteLine($"smallestNumber: {smallestNumber}");
            Console.WriteLine("\n--- numbers 2 ---");
            Console.WriteLine($"biggestNumber: {biggestNumber2}");
            Console.WriteLine($"smallestNumber: {smallestNumber2}");
        }

        public static void PrintExercise3()
        {
            //Skapa en array med heltal.
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("--- ORIGINAL ---");
            foreach (var number in numbers)
                Console.WriteLine(number);

            // Skriv en metod som skriver ut elementen i arrayen i omvänd ordning.
            Console.WriteLine("\n--- REVERSED ---");
            foreach (var number in ArrayHelper.ReverseArray(numbers))
                Console.WriteLine(number);
        }
    }
}
