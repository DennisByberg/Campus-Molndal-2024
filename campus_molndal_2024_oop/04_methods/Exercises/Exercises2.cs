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

        public static void PrintExercise2()
        {
            var student = new Student();
            student.SetAge(10);
            student.SetName("Dennis");
            student.SetGrade('A');

            Console.WriteLine($"Name: {student.GetName()}, Age: {student.GetAge()}, Grade: {student.GetGrade()}");
        }
    }
}
