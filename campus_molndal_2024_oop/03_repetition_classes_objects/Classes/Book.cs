namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Book
    {
        public string Title = "Unknown";
        public string Author = "Unknown";
        public int Pages = 0;

        public void PrintTitleAndAuthor()
        {
            System.Console.WriteLine($"The book is {Title} and the author is {Author}");
        }
    }
}
