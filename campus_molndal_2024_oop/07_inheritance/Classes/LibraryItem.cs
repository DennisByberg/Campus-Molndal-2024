namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public abstract void Checkout();
    }
}
