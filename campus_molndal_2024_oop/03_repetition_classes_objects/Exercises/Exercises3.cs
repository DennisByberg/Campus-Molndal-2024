using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public static class Exercises3
    {
        // Skapa en klass kallad Person med fälten Name, Age, och Email.
        // Skapa en anpassad konstruktor som tar alla tre fälten som parametrar och initialiserar dem.
        // Skapa ett objekt av klassen Person och skriv ut alla fält.
        public static void PrintExercise1()
        {
            var person = new Person("Dennis", 30, "dennis@gmail.com");

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Email);
        }
    }
}
