using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Bark()
        {
            Console.WriteLine("Woff!!");
        }

        public void PrintNameAndAge()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
