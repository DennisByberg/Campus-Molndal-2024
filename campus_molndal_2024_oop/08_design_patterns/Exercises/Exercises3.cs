using campus_molndal_2024_oop._08_design_patterns.Classes;
using System;

namespace campus_molndal_2024_oop._08_design_patterns.Exercises
{
    public static class Exercises3
    {
        public static void PrintExercise1()
        {
            //Pizza.cs
        }

        public static void PrintExercise2()
        {
            var pizza = new Pizza()
                .SetCrust("Thin Crust")
                .SetSize("Medium")
                .SetToppings("Fresh mozzarella");

            Console.WriteLine(pizza);
        }
    }
}
