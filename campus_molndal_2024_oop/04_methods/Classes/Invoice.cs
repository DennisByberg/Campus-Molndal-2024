using System;
using System.Text;

namespace campus_molndal_2024_oop._04_methods
{
    //Lägg till metoder för att applicera en rabatt på totalbeloppet och för att visa fakturans detaljer.
    public class Invoice
    {
        private string _invoiceNumber;
        private string _customerName;
        private double _totalAmount;

        public Invoice(string invoiceNumber, string customerName, double totalAmount)
        {
            _invoiceNumber = invoiceNumber;
            _customerName = customerName;
            _totalAmount = totalAmount;
        }

        public void ApplyDiscount(double discountPercentage)
        {
            double discountAmount = _totalAmount * (discountPercentage / 100);
            _totalAmount -= discountAmount;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Invoice Number: {_invoiceNumber}");
            Console.WriteLine($"Customer Name: {_customerName}");
            Console.WriteLine($"Total Amount: {_totalAmount}:-");
        }
    }
}
