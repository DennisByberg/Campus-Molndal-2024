using campus_molndal_oop_adv._01_oop_sqlite.Classes;
using System;

namespace campus_molndal_oop_adv._01_oop_sqlite
{
    internal static class Exercises1
    {
        // Skapa en klass Book med privata attribut för titel, författare och ISBN.
        // Implementera lämpliga konstruktorer, getters och setters.
        // Lägg till en ToString()-metod som returnerar en sträng-representation av boken.
        // Använd en IDE som Visual Studio eller VSCode för att skriva och testa din kod.
        internal static void PrintExercise1()
        {
            Book book = new Book("The Whispering Shadows", "Eliza Ravenswood", "978-1-69210-398-4");
            Console.WriteLine(book);
        }
    }
}
