namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public abstract double CalculateSalary();
    }
}
