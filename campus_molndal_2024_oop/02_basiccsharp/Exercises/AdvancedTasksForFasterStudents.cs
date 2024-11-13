using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class AdvancedTasksForFasterStudents
    {
        // Beräknar hypotenusan av en rätvinklig triangel med hjälp av Pythagoras sats.
        public static void PrintExercise1()
        {
            try
            {
                // Låt användaren mata in de två kateterna
                Console.Write("Side A: ");
                int sideA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Side B: ");
                int sideB = Convert.ToInt32(Console.ReadLine());

                // Beräkna hypotenusan.
                var hypo = Math.Sqrt((sideA * sideA) + (sideB * sideB));

                Console.WriteLine($"Hypo: {hypo}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid integers for the sides.");
            }
        }

        // Program där användaren matar in sin ålder, och programmet bestämmer om de är berättigade att rösta(18 år eller äldre) och om de är berättigade till pension(65 år eller äldre).
        public static void PrintExercise2()
        {
            try
            {
                Console.Write("Enter your age: ");
                var age = Convert.ToInt32(Console.ReadLine());

                if (age >= 65) Console.WriteLine("You are eligible to vote and eligible for pension.");
                else if (age >= 18) Console.WriteLine("You are eligible to vote but not eligible for pension yet.");
                else Console.WriteLine("You are not eligible to vote yet and not eligible for pension yet.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid age");
            }
        }

        // Skriv ett program som beräknar den totala kostnaden för en shoppinglista.
        // Använd variabler för att representera priserna för olika objekt och summera dessa för att få det totala beloppet.
        public static void PrintExercise3()
        {
            const double applePrice = 10.99;
            const double orangePrice = 5.99;
            const double pineapplePrice = 12.99;

            const double totalCost = applePrice + orangePrice + pineapplePrice;

            Console.WriteLine($"totalCost: {totalCost}");
        }
    }

}
