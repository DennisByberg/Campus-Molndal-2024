namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Product
    {
        private int Id;
        private string Name;
        private double Price;
        private int Quantity;

        //CTOR
        public Product(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // CTOR (Id, Name & Price)
        public Product(int id, string name, double price)
            : this(id, name, price, 0) { }

        // CTOR (Id & Name)
        public Product(int id, string name)
            : this(id, name, 0.0, 0) { }

        public double GetPrice()
        {
            return Price;
        }
    }
}
