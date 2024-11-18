using System;

namespace campus_molndal_2024_oop._05_datatypes
{
    public static class Exercises4
    {
        // 1. Skapa en klass Team som innehåller en array av Player-objekt.
        // 2. Implementera metoder för att lägga till en spelare och lista alla spelare i teamet.
        public static void PrintExercise1()
        {
            var team = new Team(3);
            team.AddPlayer(new Player("Dennis", 10));
            team.AddPlayer(new Player("Eric", 19));
            team.AddPlayer(new Player("Niklas", 8));

            team.ListPlayers();
        }

        // 1. Skapa en klass Zoo som innehåller en lista av Animal-objekt.
        // 2. Implementera metoder för att lägga till ett djur och lista alla djur i zooet.
        public static void PrintExercise2()
        {
            Zoo zoo = new Zoo();
            zoo.AddAnimal(new Animal("Lion"));
            zoo.AddAnimal(new Animal("Tiger"));
            zoo.AddAnimal(new Animal("Elephant"));

            zoo.PrintAnimals();
        }

        // 1. Skapa en klass School som innehåller både en array av Teacher-objekt och en lista av Student-objekt.
        // 2. Implementera metoder för att lägga till lärare och studenter, och för att lista alla lärare och studenter.
        public static void PrintExercise3()
        {
            School school = new School(2);
            school.AddTeacher(new Teacher("Mr. Smith"));
            school.AddTeacher(new Teacher("Mrs. Johnson"));

            school.AddStudent(new Student("Dennis"));
            school.AddStudent(new Student("Sune"));

            Console.WriteLine("Teachers:");
            school.ListTeachers();

            Console.WriteLine("Students:");
            school.ListStudents();
        }
    }
}
