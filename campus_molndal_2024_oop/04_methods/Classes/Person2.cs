namespace campus_molndal_2024_oop._04_methods
{
    public class Person2
    {
        private string _name;
        private int _age;
        private string _location;

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public string GetLocation()
        {
            return _location;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void SetLocation(string location)
        {
            _location = location;
        }
    }
}
