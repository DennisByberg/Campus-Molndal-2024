using campus_molndal_2024_oop._07_inheritance.Classes;
using System;
namespace campus_molndal_2024_oop._07_inheritance.Exercises
{
    public static class FinalExercises
    {
        // 1. Skapa ett system där du har en abstrakt klass Shape med en abstrakt metod calculateArea().
        // 2. Implementera två nya underklasser Triangle och Square.
        // 3. Triangle ska ha en konstruktor som tar bas och höjd som parametrar och beräknar arean med formeln(bas* höjd) / 2.
        // 4. Square ska ha en konstruktor som tar sidan som parameter och beräknar arean med formeln sida * sida.
        // 5. Skapa objekt av båda klasserna och anropa calculateArea() för att verifiera att det fungerar.
        public static void PrintExercise1()
        {
            var triangle = new Triangle(10, 5);
            var square = new Square(10);

            Console.WriteLine(triangle.CalculateArea());
            Console.WriteLine(square.CalculateArea());
        }

        // 1. Skapa en abstrakt klass LibraryItem med egenskaperna title och author, samt en abstrakt metod checkout().
        // 2. Implementera två underklasser Book och Magazine.
        // 3. Implementera checkout()-metoden för varje underklass så att den skriver ut information om att objektet är utlånat.
        // 4. Skapa en klass Library som har en lista av LibraryItem-objekt och en metod addLibraryItem(LibraryItem item) för att lägga till objekt till listan.
        // 5. Implementera en metod listItems() som listar alla objekt i biblioteket och anropar checkout() för varje objekt.
        public static void PrintExercise2()
        {
            Library library = new Library();

            var book = new Book();
            var magazine = new Magazine();

            library.AddLibraryItem(book);
            library.AddLibraryItem(magazine);

            library.ListItems();
        }
    }
}