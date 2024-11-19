using campus_molndal_2024_oop._07_inheritance.Classes;
using System;

namespace campus_molndal_2024_oop._07_inheritance.Exercises
{
    public static class Exercises4
    {
        public static void PrintExercise1()
        {
            Employee fullTime = new FullTimeEmployee("Dennis", 20000);
            Employee partTime = new PartTimeEmployee("Sofia", 190, 160);

            Console.WriteLine(fullTime.Name + "'s Salary: " + fullTime.CalculateSalary());
            Console.WriteLine(partTime.Name + "'s Salary: " + partTime.CalculateSalary());
        }
    }
}
