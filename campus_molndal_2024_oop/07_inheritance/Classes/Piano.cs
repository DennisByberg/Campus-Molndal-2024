using campus_molndal_2024_oop._07_inheritance.Interfaces;
using System;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public class Piano : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing the piano");
        }
    }
}
