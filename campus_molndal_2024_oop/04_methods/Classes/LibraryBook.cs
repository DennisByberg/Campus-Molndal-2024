namespace campus_molndal_2024_oop._04_methods
{
    public class LibraryBook
    {
        private string _title;
        private string _author;
        private int _yearPublished;

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public int GetYearPublished()
        {
            return _yearPublished;
        }

        protected void SetYearPublished(int yearPublished)
        {
            _yearPublished = yearPublished;
        }
    }
}
