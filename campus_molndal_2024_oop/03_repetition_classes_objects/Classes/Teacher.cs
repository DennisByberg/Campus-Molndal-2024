namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Teacher
    {
        private readonly string _name;
        private readonly string _subject;

        public Teacher(string name, string subject)
        {
            _name = name;
            _subject = subject;
        }

        public void Teach(Student student)
        {
            student.Study();
        }

        public string GetName()
        {
            return _name;
        }

        public string GetSubject()
        {
            return _subject;
        }
    }
}
