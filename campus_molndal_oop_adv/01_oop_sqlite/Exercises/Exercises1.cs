using campus_molndal_oop_adv._01_oop_sqlite.Classes;
using System;
using System.Xml.Linq;

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

        // Skapa en klass Library som innehåller en lista av Book-objekt.
        // Implementera metoder för att lägga till och ta bort böcker, samt en metod för att söka efter böcker baserat på titel eller författare.
        // Använd C# Collections för att hantera listan av böcker.
        internal static void PrintExercise2()
        {
            Library library = new Library();
            var book1 = new Book("Echoes of the Forgotten", "Samuel W. Moore", "978-3-54192-374-1");
            var book2 = new Book("Beneath the Silver Sky", "Amelia Blackstone", "978-0-22150-741-9");
            var book3 = new Book("The Last Ember's Flame", "Henry J. Sinclair", "978-1-53379-822-0");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.RemoveBook(book2);

            Book foundBookByTitle = library.FindBookByTitle("Echoes of the Forgotten");
            Book foundBookByAuthor = library.FindBookByAuthor("Henry J. Sinclair");

            Console.WriteLine($"foundBookByTitle: {foundBookByTitle}");
            Console.WriteLine($"foundBookByAuthor: {foundBookByAuthor}");
            Console.WriteLine($"Books in library: {library.GetBookCount()}");
        }

        // Skapa en hierarki av klasser för olika typer av fordon.
        // Börja med en abstrakt klass Vehicle med gemensamma egenskaper som Speed och Weight.
        // Skapa sedan subklasser som Car, Bicycle och Boat.
        // Implementera en abstrakt metod Move() i Vehicle och override denna i subklasserna för att beskriva hur varje fordonstyp rör sig.
        // Använd en UML-diagramverktyg för att visualisera klassrelationerna.
        internal static void PrintExercise3()
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            car.Move();
            bicycle.Move();
            boat.Move();

            // + UML DIAGRAM IN: Images/UML1.Png
        }

        internal static void PrintExercise4()
        {
            // Implemented accounts.
        }

        internal static void PrintExercise5()
        {
            // Exempel 1: Pair<string, int>
            Pair<string, int> stringIntPair = new Pair<string, int>("Age", 25);
            Console.WriteLine("String-Int Pair: " + stringIntPair);
            stringIntPair.First = "Updated Age";
            stringIntPair.Second = 30;
            Console.WriteLine("Updated String-Int Pair: " + stringIntPair);

            // Exempel 2: Pair<double, bool>
            Pair<double, bool> doubleBoolPair = new Pair<double, bool>(99.99, true);
            Console.WriteLine("Double-Bool Pair: " + doubleBoolPair);
            doubleBoolPair.First = 77.77;
            doubleBoolPair.Second = false;
            Console.WriteLine("Updated Double-Bool Pair: " + doubleBoolPair);

            // Exempel 3: Pair<int, string>
            Pair<int, string> intStringPair = new Pair<int, string>(1, "One");
            Console.WriteLine("Int-String Pair: " + intStringPair);
        }
    }
}
