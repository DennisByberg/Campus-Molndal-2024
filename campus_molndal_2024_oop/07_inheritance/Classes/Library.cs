using System.Collections.Generic;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public class Library
    {
        private List<LibraryItem> _library = new List<LibraryItem>();

        public void AddLibraryItem(LibraryItem item)
        {
            _library.Add(item);
        }

        public void ListItems()
        {
            foreach (var item in _library)
            {
                item.Checkout();
            }
        }
    }
}
