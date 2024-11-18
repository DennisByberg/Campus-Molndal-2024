using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._05_datatypes
{
    public class Library
    {
        private List<Book> _library = new List<Book>();

        public void AddBook(Book book)
        {
            _library.Add(book);
        }

        public void RemoveBook(string title)
        {
            var bookToRemove = _library.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (bookToRemove != null)
                _library.Remove(bookToRemove);
        }

        public List<Book> FindBooksByAuthor(string authorName)
        {
            var matchingBooks = new List<Book>();

            foreach (var book in _library)
            {
                if (book.Author.Equals(authorName, StringComparison.OrdinalIgnoreCase))
                    matchingBooks.Add(book);
            }

            return matchingBooks;
        }

        public void ListBooksChronologically()
        {
            if (_library.Count == 0)
            {
                Console.WriteLine("Biblioteket är tomt.");
                return;
            }

            // Sortera böckerna baserat på årtal (stigande ordning)
            _library.Sort((book1, book2) => book1.Year.CompareTo(book2.Year));

            Console.WriteLine("Böcker i kronologisk ordning:");
            foreach (var book in _library)
            {
                book.DisplayInfo();
            }
        }

        public void DisplayAllBooks()
        {
            if (_library.Count == 0)
            {
                Console.WriteLine("Biblioteket är tomt.");
                return;
            }

            Console.WriteLine("Alla böcker i biblioteket:");
            foreach (var book in _library)
            {
                book.DisplayInfo();
            }
        }
    }
}
