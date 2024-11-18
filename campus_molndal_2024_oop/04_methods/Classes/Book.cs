using System;

namespace campus_molndal_2024_oop._04_methods
{
    public class Book
    {
        private string _title;
        private string _author;
        private double _price;

        public Book(string title, string author, double price)
        {
            _title = title;
            _author = author;
            _price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {_title}, Author: {_author}, Price: {_price}");
        }

        public void ApplyDiscount(double discountPercentage)
        {
            double discountAmount = _price * (discountPercentage / 100);
            _price -= discountAmount;
            Console.WriteLine($"Discount of {discountPercentage}% applied. New price: {_price}");
        }
    }
}