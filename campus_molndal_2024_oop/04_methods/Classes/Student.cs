using System;
using System.Diagnostics;
using System.Text;

namespace campus_molndal_2024_oop._04_methods
{
    public class Student
    {
        private string _name;
        private int _age;
        private char _grade;

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public char GetGrade()
        {
            return _grade;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Age must be a positive number");

            _age = age;
        }

        public void SetGrade(char grade)
        {
            grade = char.ToUpper(grade);

            if (grade >= 'A' && grade <= 'F')
                _grade = grade;
        }
    }
}
