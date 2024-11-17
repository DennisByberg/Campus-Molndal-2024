namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
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

        public void UpdateName(string newName)
        {
            _name = newName;
        }
    }
}
