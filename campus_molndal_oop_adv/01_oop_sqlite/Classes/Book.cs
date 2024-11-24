namespace campus_molndal_oop_adv._01_oop_sqlite.Classes
{
    internal class Book
    {
        private string _title;
        private string _author;
        private string _ISBN;

        public Book(string title, string author, string ISBN)
        {
            _title = title;
            _author = author;
            _ISBN = ISBN;
        }

        public override string ToString()
        {
            return $"Title: {_title}, Author: {_author}, ISBN: {_ISBN}";
        }
    }
}
