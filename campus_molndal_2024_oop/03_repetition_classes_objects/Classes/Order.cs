using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    // Skapa en ny klass kallad Order med fälten OrderId, Product, Quantity, och TotalPrice.
    // Skapa en konstruktor som tar ett Product-objekt och en Quantity, och beräknar TotalPrice baserat på produktens pris och kvantitet.
    // Lägg till logik i konstruktören för att förhindra att en order skapas om Quantity är mindre än 1.
    // Testa klassen genom att skapa flera Order-objekt och verifiera att all logik fungerar korrekt.
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
