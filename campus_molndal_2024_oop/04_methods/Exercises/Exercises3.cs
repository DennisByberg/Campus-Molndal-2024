using System.Diagnostics;

namespace campus_molndal_2024_oop._04_methods
{
    public static class Exercises3
    {
        // Skapa en klass Book med privata variabler för title, author, och price.
        // Skapa en parametriserad konstruktor som initialiserar dessa variabler.
        // Skapa en metod DisplayInfo som skriver ut information om boken.
        public static void PrintExercise1()
        {
            var book = new Book("I Am Zlatan Ibrahimovic", "Zlatan Ibrahimovic", 399);
            book.DisplayInfo();
        }
    }
}
