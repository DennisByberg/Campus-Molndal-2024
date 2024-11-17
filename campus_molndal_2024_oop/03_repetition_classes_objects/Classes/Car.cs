using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _year;

        public Car(string brand, string model, int year)
        {
            _brand = brand;
            _model = model;
            _year = year;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Brand: {_brand}, Model: {_model}, Year: {_year}");
        }
    }
}
