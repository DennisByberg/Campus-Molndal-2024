using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Order
    {
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public Order(int orderId, Product product, int quantity)
        {
            if (quantity < 1) throw new ArgumentException("quantity must be atleast 1");

            OrderId = orderId;
            Product = product;
            Quantity = quantity;
            TotalPrice = product.GetPrice() * quantity;
        }

        public double GetTotalPrice()
        {
            return TotalPrice;
        }
    }
}
