using System;

namespace campus_molndal_2024_oop._04_methods
{
    public static class Person
    {
        public static void Greet(string personToGreet)
        {
            Console.WriteLine($"Greetings {personToGreet}");
        }

        public static void Introduce(string name, int age, string location)
        {
            Console.WriteLine($"Hello, my name is {name}, im {age} years old and lives in {location}");
        }
    }
}
