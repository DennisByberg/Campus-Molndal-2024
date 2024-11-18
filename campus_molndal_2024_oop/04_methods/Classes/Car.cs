namespace campus_molndal_2024_oop._04_methods
{
    public class Car
    {
        private string _make;
        private string _model;
        private int _year;

        public string GetMake()
        {
            return _make;
        }

        public string GetModel()
        {
            return _model;
        }

        public int GetYear()
        {
            return _year;
        }

        public void SetMake(string make)
        {
            _make = make;
        }

        public void SetModel(string model)
        {
            _model = model;
        }

        public void SetYear(int year)
        {
            _year = year;
        }
    }
}
