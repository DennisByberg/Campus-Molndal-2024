using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    // Lägg till en metod i Book som beräknar och skriver ut hur lång tid det skulle ta att läsa boken baserat på ett visst antal sidor per dag.
    public class Book
    {
        public string Title = "Unknown";
        public string Author = "Unknown";
        public int Pages = 0;

        public void PrintTitleAndAuthor()
        {
            System.Console.WriteLine($"The book is {Title} and the author is {Author}");
        }

        public double GetDaysToReadBook(int pagesReadEachDay)
        {
            return Math.Round((double)Pages / pagesReadEachDay, 1);
        }
    }
}
