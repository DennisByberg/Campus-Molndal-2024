using campus_molndal_2024_oop._03_repetition_classes_objects;
using campus_molndal_2024_oop._04_methods;
using System;
using System.Collections.Generic;
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

        // 1. Skapa en array med tio heltal.
        // 2. Implementera en metod för att sortera arrayen i stigande ordning utan att använda inbyggda sorteringsfunktioner.
        // 3. Implementera en linjär sökning i arrayen som letar efter ett specifikt tal och returnerar indexet där talet finns. Om talet inte finns i arrayen, returnera -1.
        // 4. Gör en metod som returnerar hur många gånger ett specifikt tal förekommer i arrayen.
        // 5. Testa att söka efter tal både före och efter att arrayen har sorterats.
        // 6. Använd sorteringsmetoden innan du letar efter ett specifikt tal för att säkerställa att arrayen är i rätt ordning.
        public static void PrintExercise2()
        {
            int[] numbers = new int[] { 10, 3, 5, 1, 4, 9, 8, 2, 7, 6 };
            Console.WriteLine("Original array:");
            PrintHelper.PrintArray(numbers);

            // Sortera arrayen
            SortHelper.BubbleSort(numbers);
            Console.WriteLine("\nSorted array:");
            PrintHelper.PrintArray(numbers);

            // Sök efter ett tal före sortering
            int searchNumber = 5;
            int index = ArrayHelper.LinearSearch(numbers, searchNumber);
            if (index != -1)
                Console.WriteLine($"\nNumber {searchNumber} found at index {index}.");
            else
                Console.WriteLine($"\nNumber {searchNumber} not found.");

            // Räkna förekomster av ett specifikt tal
            int count = ArrayHelper.CountOccurrences(numbers, searchNumber);
            Console.WriteLine($"\nNumber {searchNumber} occurs {count} times in the array.");
        }

        // 1. Skapa en klass Book med attributen title, author, och year.
        // 2. Skapa en lista för att lagra flera Book-objekt.
        // 3. Implementera en metod som lägger till en ny bok i listan.
        // 4. Skapa en metod som tar bort en bok från listan baserat på titeln.
        // 5. Gör en metod som söker efter en bok i listan baserat på författarens namn och returnerar alla böcker som matchar.
        // 6. Se till att metoderna hanterar situationer där boken inte finns eller där listan är tom.
        // 7. Implementera en metod som listar alla böcker i listan i kronologisk ordning baserat på årtal.
        public static void PrintExercise3()
        {
            var library = new Library();

            library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 1937));
            library.AddBook(new Book("1984", "George Orwell", 1949));
            library.AddBook(new Book("Animal Farm", "George Orwell", 1945));
            library.AddBook(new Book("The Silmarillion", "J.R.R. Tolkien", 1977));
            library.AddBook(new Book("Brave New World", "Aldous Huxley", 1932));

            var booksByOrwell = library.FindBooksByAuthor("George Orwell");
            foreach (var book in booksByOrwell)
            {
                book.DisplayInfo();
            }

            // Lista alla böcker i kronologisk ordning
            library.ListBooksChronologically();

            // Visa alla böcker i biblioteket
            library.DisplayAllBooks();
        }
    }
}
