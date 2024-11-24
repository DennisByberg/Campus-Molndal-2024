using System.Collections.Generic;

namespace campus_molndal_oop_adv._01_oop_sqlite.Classes
{
    internal class Library
    {
        List<Book> _library;

        public Library()
        {
            _library = new List<Book>();
        }

        public void AddBook(Book book) => _library.Add(book);

        public void RemoveBook(Book book) => _library.Remove(book);

        public int GetBookCount() => _library.Count;

        public Book FindBookByTitle(string title)
        {
            foreach (var book in _library)
            {
                if (book.GetTitle().Equals(title))
                    return book;
            }

            return null;
        }

        public Book FindBookByAuthor(string author)
        {
            foreach (var book in _library)
            {
                if (book.GetAuthor().Equals(author))
                    return book;
            }

            return null;
        }
    }
}
