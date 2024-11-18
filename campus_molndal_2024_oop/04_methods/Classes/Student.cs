using System;

namespace campus_molndal_2024_oop._04_methods
{
    public class Student
    {
        private string name;
        private int age;
        private char grade;

        public Student(string name, char grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public Student()
        {
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public char GetGrade()
        {
            return grade;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Age must be a positive number");

            this.age = age;
        }

        public void SetGrade(char grade)
        {
            grade = char.ToUpper(grade);

            if (grade >= 'A' && grade <= 'F')
                this.grade = grade;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {name}, Grade: {grade}");
        }
    }
}
