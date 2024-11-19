using campus_molndal_2024_oop._07_inheritance.Interfaces;
using System;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public partial class Dog : Animal, IPet
    {
        public void Play()
        {
            Console.WriteLine("The dog is playing");
        }
    }
}
