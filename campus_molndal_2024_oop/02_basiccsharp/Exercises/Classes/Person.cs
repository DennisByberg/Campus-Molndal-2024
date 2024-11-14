using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Occupation;

        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is ${Name}, I'm {Age} years old and work as a {Occupation}");
        }
    }
}
