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
            else
                Console.WriteLine($"Boken \"{title}\" finns inte i biblioteket.");
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

        public void SortBooksByAuthor()
        {
            _library.Sort((book1, book2) => string.Compare(book1.Author, book2.Author, StringComparison.OrdinalIgnoreCase));
        }

        public void ListBooksChronologically()
        {
            if (_library.Count == 0)
            {
                Console.WriteLine("Biblioteket är tomt.");
                return;
            }

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

        public void LoanBook(string title)
        {
            var bookToLoan = _library.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (bookToLoan == null)
            {
                Console.WriteLine($"Boken \"{title}\" finns inte i biblioteket.");
                return;
            }

            if (bookToLoan.IsLoaned)
            {
                Console.WriteLine($"Boken \"{title}\" är redan utlånad.");
            }
            else
            {
                bookToLoan.IsLoaned = true;
                Console.WriteLine($"Boken \"{title}\" har blivit utlånad.");
            }
        }

        public void ReturnBook(string title)
        {
            var bookToReturn = _library.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (bookToReturn == null)
            {
                Console.WriteLine($"Boken \"{title}\" finns inte i biblioteket.");
                return;
            }

            if (!bookToReturn.IsLoaned)
            {
                Console.WriteLine($"Boken \"{title}\" var inte utlånad.");
            }
            else
            {
                bookToReturn.IsLoaned = false;
                Console.WriteLine($"Boken \"{title}\" har blivit återlämnad.");
            }
        }

        public List<Book> GetBooksByDecade(int decadeStartYear)
        {
            if (_library.Count == 0)
            {
                Console.WriteLine("Biblioteket är tomt.");
                return new List<Book>();
            }

            var matchingBooks = new List<Book>();
            int decadeEndYear = decadeStartYear + 9;

            foreach (var book in _library)
            {
                if (book.Year >= decadeStartYear && book.Year <= decadeEndYear)
                {
                    matchingBooks.Add(book);
                }
            }

            if (matchingBooks.Count == 0)
            {
                Console.WriteLine($"Inga böcker hittades för årtiondet {decadeStartYear}s.");
            }

            return matchingBooks;
        }
    }
}