using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Classroom
    {
        private readonly List<Student> _students;

        public Classroom()
        {
            _students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }

        // Implementera en metod som returnerar en referens till en Student-objekt baserat på studentens namn.
        public Student GetStudent(string name)
        {
            foreach (var student in _students)
            {
                if (student.GetName() == name) return student;
            }

            return null;
        }

        public void PrintAllStudentsName()
        {
            var index = 1;

            foreach (var student in _students)
            {
                Console.WriteLine($"Student #{index}: {student.GetName()}");
                index++;
            }
        }
    }
}