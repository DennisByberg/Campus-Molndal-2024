﻿using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class ClassesAndObjectsExercises
    {
        // Skapa en klass Person med attributen Name, Age, och Occupation.Skapa ett objekt av klassen och tilldela värden till attributen.
        // Skriv ut informationen om personen.
        public static void PrintExercise1()
        {
            Person person = new Person();

            person.Name = "Dennis";
            person.Age = 30;
            person.Occupation = "Developer";

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Name: {person.Occupation}");
        }

        // Lägg till en metod Introduce() i klassen Person som skriver ut en presentation av personen.
        // Anropa metoden för att presentera objektet.
        public static void PrintExercise2()
        {
            var person = new Person();

            person.Name = "Dennis";
            person.Age = 30;
            person.Occupation = "Developer";

            person.Introduce();
        }
    }
}
