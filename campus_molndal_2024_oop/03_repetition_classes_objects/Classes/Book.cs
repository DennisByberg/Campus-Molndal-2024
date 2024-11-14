using System;
using static System.Net.Mime.MediaTypeNames;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Book
    {
        public string Title = "Unknown";
        public string Author = "Unknown";
        public string Genre = "Unknown";
        public int Pages = 0;

        public void PrintTitleAndAuthor()
        {
            System.Console.WriteLine($"The book is {Title} and the author is {Author}");
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
    }
}
