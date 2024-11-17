using System;

namespace campus_molndal_2024_oop._04_methods
{
    public class Person
    {
        public void Greet(string personToGreet)
        {
            Console.WriteLine($"Greetings {personToGreet}");
        }

        public void Introduce(string name, int age, string location)
        {
            Console.WriteLine($"Hello, my name is {name}, im {age} years old and lives in {location}");
        }
    }
}
