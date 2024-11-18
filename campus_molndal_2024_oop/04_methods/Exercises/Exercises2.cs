using System;

namespace campus_molndal_2024_oop._04_methods
{
    public static class Exercises2
    {
        public static void PrintExercise1()
        {
            var car = new Car();
            car.SetModel("Focus");
            Console.WriteLine(car.GetModel());
        }
    }
}
