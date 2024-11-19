using campus_molndal_2024_oop._07_inheritance.Interfaces;
using System;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public class FullTimeEmployee : Employee, IPayable
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            MonthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }

        public void Pay()
        {
            Console.WriteLine("Paying " + Name + " a salary of " + CalculateSalary());
        }
    }
}
