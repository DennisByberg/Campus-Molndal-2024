using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Book2
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int PublicationYear { get; set; }

        public Book2(string title, Author author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public void PrintTitleAndAuthorInfo()
        {
            Console.WriteLine($"Title: {Title}, Author Name: {Author.Name}, Author Nationality: {Author.Nationality}");
        }
    }
}
