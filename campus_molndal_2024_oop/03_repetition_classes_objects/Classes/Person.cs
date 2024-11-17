using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Email;

        // CTOR
        public Person(string name, int age, string email)
        {
            if (age < 0)
                throw new ArgumentException("Age must be positive");

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

        // Overrides the default Equals method to compare two Person objects based on their Name and Age properties instead of their memory references.
        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return Name == other.Name && Age == other.Age;
            }
            return false;
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        // Prints the person's introduction to the console.
        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}, im {Age} years old an my mail is {Email} ");
        }

    }
}
