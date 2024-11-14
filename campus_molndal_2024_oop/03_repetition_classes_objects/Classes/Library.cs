using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._03_repetition_classes_objects.Classes
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
    }
}
