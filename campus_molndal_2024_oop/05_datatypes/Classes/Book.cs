using System;

namespace campus_molndal_2024_oop._05_datatypes
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Titel: {Title}, Författare: {Author}, År: {Year}");
        }
    }
}
