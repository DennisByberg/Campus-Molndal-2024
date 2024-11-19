using campus_molndal_2024_oop._07_inheritance.Classes;
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

        // 1. Skapa ett gränssnitt IPlayable med metoden Play().
        // 2. Skapa två klasser Guitar och Piano som implementerar IPlayable.
        // 3. Implementera Play()-metoden i båda klasserna och skapa objekt av Guitar och Piano som anropar Play().
        public static void PrintExercise2()
        {
            var piano = new Piano();
            var guitar = new Guitar();

            piano.Play();
            guitar.Play();
        }
    }
}
