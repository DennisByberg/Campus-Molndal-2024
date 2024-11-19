namespace campus_molndal_2024_oop._08_design_patterns.Classes
{
    public class Pizza
    {
        private string _size;
        private string _crust;
        private string _toppings;

        public Pizza SetSize(string size)
        {
            _size = size;
            return this;
        }

        public Pizza SetCrust(string crust)
        {
            _crust = crust;
            return this;
        }

        public Pizza SetToppings(string toppings)
        {
            _toppings = toppings;
            return this;
        }

        public override string ToString()
        {
            return $"Pizza - Size: {_size}, Crust: {_crust}, Toppings: {_toppings}";
        }
    }
}
