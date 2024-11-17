using System;
using System.Collections.Generic;
using System.Linq;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Department
    {
        private readonly List<Teacher> _department;

        public Department()
        {
            _department = new List<Teacher>();
        }

        public void AddTeacher(Teacher teacher)
        {
            _department.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            _department.Remove(teacher);
        }

        public void PrintAllTeacherNames()
        {
            foreach (var (teacher, index) in _department.Select((teacher, index) => (teacher, index)))
            {
                Console.WriteLine($"Teacher #{index + 1}: {teacher.GetName()}");
            }
        }
    }
}
