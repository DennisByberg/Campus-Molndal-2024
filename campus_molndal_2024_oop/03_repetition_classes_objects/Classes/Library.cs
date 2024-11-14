using System.Collections.Generic;

namespace campus_molndal_2024_oop._03_repetition_classes_objects.Classes
{
    // Skapa en ny klass kallad Library som innehåller en lista över böcker.
    // * Lägg till metoder för att:
    // * Lägga till en bok i biblioteket.
    // * Ta bort en bok från biblioteket.
    // * Visa alla böcker i biblioteket.
    public class Library
    {
        private readonly List<Book> _library;
        public Library()
        {
            _library = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _library.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _library.Remove(book);
        }

        public void PrintAllBooks()
        {
            var index = 1;
            foreach (var book in _library)
            {
                System.Console.WriteLine($"Book #{index}: {book.Title}");
                index++;
            }
        }
    }
}
