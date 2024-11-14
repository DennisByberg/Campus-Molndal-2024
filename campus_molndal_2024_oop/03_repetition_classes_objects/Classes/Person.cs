using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    //Lägg till validering i konstruktorerna i klassen Person för att säkerställa att Age alltid är ett positivt tal.
    //Om ett ogiltigt värde ges, kasta ett undantag (ArgumentException).
    //Skapa ett objekt med ett ogiltigt Age-värde och se vad som händer.
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

        // This method prints the person's introduction to the console.
        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}, im {Age} years old an my mail is {Email} ");
        }
    }
}
