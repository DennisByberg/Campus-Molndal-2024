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
    }
}
