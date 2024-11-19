using campus_molndal_2024_oop._07_inheritance.Interfaces;
using System;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public class PartTimeEmployee : Employee, IPayable
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string name, double hourlyRate, int hoursWorked) : base(name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public void Pay()
        {
            Console.WriteLine("Paying " + Name + " a salary of " + CalculateSalary());
        }
    }
}
