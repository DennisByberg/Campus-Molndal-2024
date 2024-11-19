using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public class Car : Vehicle
    {
        public Car(string make, string model, int year) : base(make, model, year)
        { }

        public void PlayRadio()
        {
            Console.WriteLine("Playing the radio...");
        }
    }
}
