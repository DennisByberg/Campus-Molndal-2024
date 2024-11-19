using campus_molndal_2024_oop._07_inheritance.Classes;
using campus_molndal_2024_oop._07_inheritance.Interfaces;
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

        public static void PrintExercise2()
        {
            IPayable fullTimePayable = new FullTimeEmployee("Dennis", 20000);
            IPayable partTimePayable = new PartTimeEmployee("Sofia", 190, 160);

            fullTimePayable.Pay();
            partTimePayable.Pay();
        }
    }
}
