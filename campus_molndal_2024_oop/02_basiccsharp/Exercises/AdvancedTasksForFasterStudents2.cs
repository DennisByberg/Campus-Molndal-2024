using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    // Skriv ett program som simulerar en enkel miniräknare.Användaren matar in två tal och väljer en operation
    // (addition, subtraktion, multiplikation, division). Använd en switch-sats för att utföra den valda operationen och skriv ut resultatet.
    public static class AdvancedTasksForFasterStudents2
    {
        public static void PrintExercise1()
        {
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Operator(+, -, / or *): ");
            string operatorChoice = Console.ReadLine();

            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (operatorChoice)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;

                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }

        // Skapa ett program som beräknar en rabatt på en produkt baserat på användarens medlemsstatus (t.ex. "guld", "silver", "brons"). Använd en switch-sats för att tillämpa rätt rabatt.
        //Guld: 20%
        //Silver: 10%
        //Brons: 5%
        public static void PrintExercise2()
        {
            var productPrice = 10.99;
            var memberStatus = "bronze";

            var goldDiscount = 0.20;
            var silverDiscount = 0.10;
            var bronzeDiscount = 0.05;

            switch (memberStatus)
            {
                case "gold":
                    Console.WriteLine($"Product with price {productPrice} cost {Math.Round(productPrice - (productPrice * goldDiscount), 2)} with gold member status");
                    break;

                case "silver":
                    Console.WriteLine($"Product with price {productPrice} cost {Math.Round(productPrice - (productPrice * silverDiscount), 2)} with silver member status");
                    break;

                case "bronze":
                    Console.WriteLine($"Product with price {productPrice} cost {Math.Round(productPrice - (productPrice * bronzeDiscount), 2)} with bronze member status");
                    break;

                default:
                    Console.WriteLine("Invalid memberStatus");
                    break;
            }
        }
    }
}
