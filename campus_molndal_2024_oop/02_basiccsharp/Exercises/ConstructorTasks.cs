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

        public static void PrintExercise2()
        {

        }
    }
}
