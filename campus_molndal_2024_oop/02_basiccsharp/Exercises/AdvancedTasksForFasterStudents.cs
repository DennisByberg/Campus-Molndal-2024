using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
