using campus_molndal_2024_oop._03_repetition_classes_objects.Classes;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public static class Exercises2
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

        // Lägg till ett nytt fält i klassen Book som representerar bokens genre.
        // Skapa en metod som kontrollerar om en bok tillhör en viss genre och returnerar true eller false.
        // Testa metoden genom att kontrollera genren för olika bokobjekt.
        public static void PrintExercise3()
        {
            var book1 = new Book();

            book1.Title = "Programming Book";
            book1.Author = "A random dev";
            book1.Genre = "Comedy";
            book1.Pages = 300;

            var book2 = new Book();

            book2.Title = "Programming Book 2";
            book2.Author = "A random dev 2";
            book2.Genre = "Action";
            book2.Pages = 200;

            System.Console.WriteLine($"Book1 genre is comedy?: {book1.IsBookOfGenre("Comedy")}");
            System.Console.WriteLine($"Book1 genre is science?: {book1.IsBookOfGenre("Science")}");
            System.Console.WriteLine($"Book2 genre is action?: {book2.IsBookOfGenre("Action")}");
        }

        // Lägg till en metod i klassen Book som jämför två böcker baserat på antalet sidor och returnerar vilken bok som är längre.
        // Skapa två bokobjekt med olika antal sidor och använd metoden för att jämföra dem.
        public static void PrintExercise4()
        {
            var book1 = new Book();

            book1.Title = "Programming Book";
            book1.Author = "A random dev";
            book1.Genre = "Comedy";
            book1.Pages = 300;

            var book2 = new Book();

            book2.Title = "Programming Book 2";
            book2.Author = "A random dev 2";
            book2.Genre = "Action";
            book2.Pages = 200;

            System.Console.WriteLine(book1.IsBookLongerThan(book2));
        }

        // Skapa en ny klass kallad Library som innehåller en lista över böcker.
        // * Lägg till metoder för att:
        // * Lägga till en bok i biblioteket.
        // * Ta bort en bok från biblioteket.
        // * Visa alla böcker i biblioteket.
        // Skapa ett objekt av Library och lägg till flera böcker i det. Använd metoderna för att manipulera listan av böcker.
        public static void PrintExercise5()
        {
            var library = new Library();

            var book1 = new Book();

            book1.Title = "Programming Book";
            book1.Author = "A random dev";
            book1.Genre = "Comedy";
            book1.Pages = 300;

            var book2 = new Book();

            book2.Title = "Programming Book 2";
            book2.Author = "A random dev 2";
            book2.Genre = "Action";
            book2.Pages = 200;

            library.AddBook(book1);
            library.AddBook(book2);

            library.PrintAllBooks();
        }
    }
}
