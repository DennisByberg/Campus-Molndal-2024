using campus_molndal_2024_oop._03_repetition_classes_objects;
using campus_molndal_2024_oop._04_methods;
using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._05_datatypes
{
    // 1. Skapa en klass School som innehåller både en array av Teacher-objekt och en lista av Student-objekt.
    // 2. Implementera metoder för att lägga till lärare och studenter, och för att lista alla lärare och studenter.
    public class School
    {
        private List<Student> _students;
        private Teacher[] _teachers;
        private int teacherCount;

        public School(int teacherSize)
        {
            _students = new List<Student>();
            _teachers = new Teacher[teacherSize];
            teacherCount = 0;
        }

        public void AddTeacher(Teacher teacher)
        {
            if (teacherCount < _teachers.Length)
            {
                _teachers[teacherCount] = teacher;
                teacherCount++;
            }
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void ListTeachers()
        {
            for (int i = 0; i < teacherCount; i++)
            {
                Console.WriteLine(_teachers[i].GetName());
            }
        }

        public void ListStudents()
        {
            foreach (var student in _students)
            {
                Console.WriteLine(student.GetName());
            }
        }
    }

    public class Teacher
    {
        private string _name;

        public Teacher(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class Student
    {
        private string _name;

        public Student(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}