using System.Security.Cryptography;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public static class Exercises
    {
        // Skapa en klass kallad Book med följande fält: Title, Author, Pages.
        // Skapa en metod i klassen som skriver ut bokens titel och författare.
        // Skapa ett objekt av klassen Book i Main-metoden och tilldela värden till fälten.
        // Anropa metoden för att skriva ut bokinformationen.
        public static void PrintExercise1()
        {
            var book = new Book();

            book.Title = "Programming Book";
            book.Author = "A random dev";
            book.Pages = 300;

            book.PrintTitleAndAuthor();
        }

        // Skapa flera objekt av klassen Book med olika värden för varje bok.
        // Lägg till en metod i Book som beräknar och skriver ut hur lång tid det skulle ta att läsa boken baserat på ett visst antal sidor per dag.
        // Anropa denna metod för varje bokobjekt och visa resultaten.
        public static void PrintExercise2()
        {
            var book1 = new Book();

            book1.Title = "Programming Book";
            book1.Author = "A random dev";
            book1.Pages = 300;

            var book2 = new Book();

            book2.Title = "Programming Book 2";
            book2.Author = "A random dev 2";
            book2.Pages = 200;

            int pagesReadEachDay = 15;
            System.Console.WriteLine($"It will take {book1.GetDaysToReadBook(pagesReadEachDay)} day(s) to read {book1.Title} if you read {pagesReadEachDay} pages a day");
            System.Console.WriteLine($"It will take {book2.GetDaysToReadBook(pagesReadEachDay)} day(s) to read {book2.Title} if you read {pagesReadEachDay} pages a day");
        }
    }
}
