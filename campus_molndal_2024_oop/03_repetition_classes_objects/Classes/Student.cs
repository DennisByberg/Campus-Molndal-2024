using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Student
    {
        private int _studentId;
        private string _name;
        private string _grade;

        public Student(int studentId, string name, string grade)
        {
            _studentId = studentId;
            _name = name;
            _grade = grade;
        }

        public Student(int studentId, string name) : this(studentId, name, "IG")
        { }

        public Student(string name) : this(0, name, "IG")
        { }

        public string GetName()
        {
            return _name;
        }

        public int GetStudentId()
        {
            return _studentId;
        }

        public string GetGrade()
        {
            return _grade;
        }

        public void UpdateName(string newName)
        {
            _name = newName;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"StudentId: {_studentId}");
            Console.WriteLine($"Student Name: {_name}");
            Console.WriteLine($"Grade: {_grade}");
        }
    }
}
