using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
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
                Console.WriteLine($"Book #{index}: {book.Title}");
                index++;
            }
        }

        // Skapa en klass kallad Library med en metod GetBook(string title) som returnerar ett Book-objekt.
        public Book GetBook(string title)
        {
            foreach (var book in _library)
            {
                if (title == book.Title) return book;
            }

            return null;
        }

    }
}
