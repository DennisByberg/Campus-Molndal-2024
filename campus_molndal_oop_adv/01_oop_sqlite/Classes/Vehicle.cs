using System;

namespace campus_molndal_oop_adv._01_oop_sqlite.Classes
{
    internal abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Weight { get; set; }

        internal abstract void Move();
    }

    internal class Car : Vehicle
    {
        internal override void Move()
        {
            Console.WriteLine("Car Moves...");
        }
    }

    internal class Bicycle : Vehicle
    {
        internal override void Move()
        {
            Console.WriteLine("Bicycle Moves...");
        }
    }

    internal class Boat : Vehicle
    {
        internal override void Move()
        {
            Console.WriteLine("Boat Moves...");
        }
    }
}
