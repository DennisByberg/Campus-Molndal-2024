using campus_molndal_2024_oop._04_methods;
using System;

namespace campus_molndal_2024_oop._07_inheritance
{
    public static class Exercises3
    {
        // 1. Skapa en abstrakt klass Shape med en abstrakt metod CalculateArea().
        // 2. Skapa två underklasser Circle och Rectangle som implementerar CalculateArea().
        // 3. Implementera metoderna i underklasserna och beräkna arean för en cirkel och en rektangel.
        public static void PrintExercise1()
        {
            var circle = new Circle(10);
            var rectangle = new Rectangle(10, 5);

            Console.WriteLine($"Circle area: {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
        }
    }
}
