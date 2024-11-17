namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public Order Order { get; set; }

        public Customer(string customerName, Order order)
        {
            CustomerName = customerName;
            Order = order;
        }
    }
}
