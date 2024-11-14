using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public class Person
    {
        public string Name = "Unknown";
        public int Age = 0;
        public string Occupation = "Unknown";

        // Constructor
        public Person() { }

        // Constructor
        public Person(string name, int age, string occupation)
        {
            Name = name;
            Age = age;
            Occupation = occupation;
        }


        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name}, I'm {Age} years old and work as a {Occupation}");
        }
    }
}
