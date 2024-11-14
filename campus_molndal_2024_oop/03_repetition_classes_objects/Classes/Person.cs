using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        // CTOR
        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        // CTOR
        public Person(string name, int age)
            : this(name, age, "unknown@unknown.com")
        { }

        // CTOR
        public Person()
            : this("Unknown", 0, "Unknown")
        { }

        // This method prints the person's introduction to the console.
        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}, im {Age} years old an my mail is {Email} ");
        }
    }
}
