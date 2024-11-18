namespace campus_molndal_2024_oop._05_datatypes
{
    public class Player
    {
        private string _name;
        private int _number;

        public Player(string name, int number)
        {
            _name = name;
            _number = number;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
