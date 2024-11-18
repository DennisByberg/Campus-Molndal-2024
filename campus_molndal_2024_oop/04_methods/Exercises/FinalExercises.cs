using System;
using System.Text;

namespace campus_molndal_2024_oop._04_methods
{
    public static class FinalExercises
    {
        // Skapa en klass SimpleCalculator som innehåller metoder för att addera, subtrahera, multiplicera och dividera två tal.Varje metod ska ta två parametrar och returnera resultatet.
        // Implementera en Main-metod som anropar alla dessa metoder med olika tal och skriver ut resultaten.
        public static void PrintExercise1()
        {
            Console.WriteLine(SimpleCalculator.Add(10, 5));
            Console.WriteLine(SimpleCalculator.Subtract(10, 5));
            Console.WriteLine(SimpleCalculator.Multiply(10, 5));
            Console.WriteLine(SimpleCalculator.Divide(10, 5));
        }

        // Skapa en klass Person som innehåller privata variabler för namn, ålder och stad.Implementera publika getter- och setter-metoder för varje variabel.
        // Skriv en Main-metod där du skapar flera instanser av Person, sätter värden för varje instans och skriver ut informationen med hjälp av getter-metoderna.
        public static void PrintExercise2()
        {
            var person1 = new Person2();
            var person2 = new Person2();

            person1.SetName("Dennis");
            person2.SetName("Sofia");

            Console.WriteLine(person1.GetName());
            Console.WriteLine(person2.GetName());
        }
    }
}
