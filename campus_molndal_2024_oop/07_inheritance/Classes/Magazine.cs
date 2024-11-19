using System;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public class Magazine : LibraryItem
    {
        public override void Checkout()
        {
            Console.WriteLine("Lånar ut magazine");
        }
    }
}
