using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Teacher
    {
        private string _name;
        private string _subject;

        public Teacher(string name, string subject)
        {
            _name = name;
            _subject = subject;
        }

        public void Teach(Student student)
        {
            student.Study();
        }
    }
}
