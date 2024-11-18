using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._05_datatypes
{
    public static class Exercises2
    {
        public static void PrintExercise1()
        {
            //Skapa en lista av heltal.
            var numbers = new List<int>();

            //Lägg till fem heltal i listan.
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            //Beräkna och skriv ut summan av alla element i listan.
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"Sum is {sum}");
        }
    }
}
