using campus_molndal_2024_oop._07_inheritance.Interfaces;
using System;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public class Guitar : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing the guitar");
        }
    }
}
