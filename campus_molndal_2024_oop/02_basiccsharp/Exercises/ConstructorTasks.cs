using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class ConstructorTasks
    {
        // Skapa en konstruktor i klassen Person som tar Name, Age, och Occupation som parametrar.
        // Skapa ett objekt med hjälp av konstruktorn.
        public static void PrintExercise1()
        {
            var person = new Person("Dennis", 30, "Frontend Dev");
            person.Introduce();
        }

        // Lägg till en konstruktor utan parametrar som tilldelar standardvärden till attributen.
        // Skapa ett objekt med denna konstruktor och skriv ut standardvärdena.
        public static void PrintExercise2()
        {
            var person = new Person();
            person.Introduce();
        }
    }
}
