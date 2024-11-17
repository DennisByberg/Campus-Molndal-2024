using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Library
    {
        private readonly string _name;
        private readonly string _location;
        private readonly List<Book> _library;
        public Library(string name, string location)
        {
            _name = name;
            _location = location;
            _library = new List<Book>();

        }

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

        public void PrintNameAndLocation()
        {
            Console.WriteLine($"Library name: {_name}");
            Console.WriteLine($"Library location: {_location}");
        }

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
