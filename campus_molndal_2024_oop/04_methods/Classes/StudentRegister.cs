using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._04_methods
{
    public class StudentRegister
    {
        private List<Student> _studentRegister;
        public StudentRegister()
        {
            _studentRegister = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            _studentRegister.Add(student);
        }

        //ta bort en student baserat på namn,
        public void RemoveStudent(string name)
        {
            _studentRegister.RemoveAll(student => student.GetName() == name);
        }

        //och för att visa alla studenter i registret.
        public void DisplayAllStudents()
        {
            var index = 1;
            foreach (var student in _studentRegister)
            {
                Console.WriteLine($"Student #{index}: {student.GetName()}");
                index++;
            }
        }
    }
}
