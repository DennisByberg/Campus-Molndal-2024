using System;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Zzzzz");
        }
    }
}
