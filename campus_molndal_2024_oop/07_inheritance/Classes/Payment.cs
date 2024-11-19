using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public abstract class Payment
    {
        public abstract void ProcessPayment();
    }

    public class CreditCardPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Paying with Credit Card");
        }
    }

    public class PayPalPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Paying with PayPal");
        }
    }

    public class PaymentProcessor
    {
        List<Payment> paymentProcessor = new List<Payment>();

        public void AddPayment(Payment payment)
        {
            paymentProcessor.Add(payment);
        }

        public void ProcessAllPayments()
        {
            foreach (var payment in paymentProcessor)
            {
                payment.ProcessPayment();
            }
        }
    }
}
