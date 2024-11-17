using System;
using System.Collections.Generic;
using System.Linq;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Member
    {
        private string _name;
        private List<Book> _loanedBooks;

        public Member(string name)
        {
            _name = name;
            _loanedBooks = new List<Book>();
        }

        public void LoanBook(Book book)
        {
            _loanedBooks.Add(book);
        }

        public void ReturnBook(Book bookToReturn)
        {
            for (int i = _loanedBooks.Count - 1; i >= 0; i--)
            {
                if (_loanedBooks[i].Equals(bookToReturn))
                {
                    _loanedBooks.RemoveAt(i);
                    break;
                }
            }
        }

        public void PrintLoanedBooks()
        {
            if (_loanedBooks.Count < 1)
                Console.WriteLine("No books loaned.");

            foreach (var (loanedBook, index) in _loanedBooks.Select((loanedBook, index) => (loanedBook, index)))
            {
                Console.WriteLine($"Loaned Book #{index + 1}: {loanedBook.GetTitle()}");
            }
        }
    }
}
