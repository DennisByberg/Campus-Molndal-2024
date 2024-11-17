using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Book
    {
        public string Title = "Unknown";
        public string Author = "Unknown";
        public int Year = 0;
        public string Genre = "Unknown";
        public int Pages = 0;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public Book()
        {
        }

        public Book(string title, string author, int year) : this(title, author)
        {
            Year = year;
        }

        public void PrintTitleAndAuthor()
        {
            Console.WriteLine($"The book is {Title} and the author is {Author}");
        }

        public double GetDaysToReadBook(int pagesReadEachDay)
        {
            return Math.Round((double)Pages / pagesReadEachDay, 1);
        }

        public bool IsBookOfGenre(string genre)
        {
            if (genre == null) return false;
            return string.Equals(genre, Genre, StringComparison.OrdinalIgnoreCase);
        }

        // Lägg till en metod i klassen Book som jämför två böcker baserat på antalet sidor och returnerar vilken bok som är längre.
        public bool IsBookLongerThan(Book book)
        {
            return Pages > book.Pages;
        }
    }
}
