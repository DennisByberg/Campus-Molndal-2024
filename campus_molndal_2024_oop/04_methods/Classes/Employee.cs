using System;

namespace campus_molndal_2024_oop._04_methods
{
    public class Employee
    {
        private string _name;
        private string _position;
        private double _salaly;

        public Employee(string name, string position, double salaly)
        {
            _name = name;
            _position = position;
            _salaly = salaly;
        }

        public Employee(string name, string position) : this(name, position, 0)
        { }

        public Employee() : this("Unknown", "Unknown", 0)
        { }

        public void SetSalary(double salary)
        {
            _salaly = salary;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"Name: {_name}, Position: {_position}, Salary: {_salaly}");
        }
    }
}
