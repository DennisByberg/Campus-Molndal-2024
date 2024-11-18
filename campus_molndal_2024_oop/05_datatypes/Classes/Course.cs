using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._05_datatypes
{
    public class Course
    {
        private string _courseName;
        private Student2[] _students;
        private int _studentCount;

        public Course(string courseName, int capacity)
        {
            _courseName = courseName;
            _students = new Student2[capacity];
            _studentCount = 0;
        }

        // Add student to the course
        public void AddStudent(Student2 student)
        {
            if (_studentCount < _students.Length)
            {
                _students[_studentCount] = student;
                _studentCount++;
            }
            else
            {
                Console.WriteLine("Course is full. Cannot add more students.");
            }
        }

        public List<Student2> GetStudentByGrade(char grade)
        {
            List<Student2> studentsWithGrade = new List<Student2>();

            foreach (var student in _students)
            {
                if (student != null && char.ToUpper(student.GetGrade()) == char.ToUpper(grade))
                    studentsWithGrade.Add(student);
            }

            return studentsWithGrade;
        }

        public Student2 GetStudentWithBestGrade()
        {
            if (_studentCount == 0)
                throw new InvalidOperationException("Studentlistan är tom.");

            var bestStudent = _students[0];

            foreach (var student in _students)
            {
                if (student != null && student.GetGrade() < bestStudent.GetGrade())
                    bestStudent = student;
            }

            return bestStudent;
        }

        public void SortStudentsByGrade()
        {
            Array.Sort(_students, (student1, student2) =>
            {
                if (student1 == null || student2 == null)
                    return 0;

                return student2.GetGrade().CompareTo(student1.GetGrade());
            });
        }

        public void DisplayStudents()
        {
            foreach (var student in _students)
            {
                if (student != null)
                    Console.WriteLine($"Name: {student.GetName()}, Grade: {student.GetGrade()}");
            }
        }
    }

    public class Student2
    {
        private string _name;
        private char _grade;

        public Student2(string name, char grade)
        {
            _name = name;
            _grade = grade;
        }

        public char GetGrade()
        {
            return _grade;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
