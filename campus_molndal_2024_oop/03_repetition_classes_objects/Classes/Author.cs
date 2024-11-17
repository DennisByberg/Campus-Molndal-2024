namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Author
    {
        public string Name { get; set; }
        public string Nationality { get; set; }

        public Author(string name, string nationality)
        {
            Name = name;
            Nationality = nationality;
        }
    }
}
