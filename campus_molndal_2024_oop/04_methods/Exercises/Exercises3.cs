using System;
using System.Diagnostics;

namespace campus_molndal_2024_oop._04_methods
{
    public static class Exercises3
    {
        // Skapa en klass Book med privata variabler för title, author, och price.
        // Skapa en parametriserad konstruktor som initialiserar dessa variabler.
        // Skapa en metod DisplayInfo som skriver ut information om boken.
        public static void PrintExercise1()
        {
            var book = new Book("I Am Zlatan Ibrahimovic", "Zlatan Ibrahimovic", 399);
            book.DisplayInfo();
        }

        // Skapa en klass Triangle med privata variabler base och height.
        // Implementera två konstruktorer: en standardkonstruktor som sätter bas och höjd till 1, och en parametriserad konstruktor som accepterar värden för bas och höjd.
        // Skapa en metod CalculateArea som beräknar och returnerar triangelns area.
        public static void PrintExercise2()
        {
            var triangle1 = new Triangle();
            var triangle2 = new Triangle(5.0, 10.0);

            Console.WriteLine("Area of triangle 1: " + triangle1.CalculateArea());
            Console.WriteLine("Area of triangle 2: " + triangle2.CalculateArea());
        }

        // Skapa en klass Student med privata variabler name och grade.
        // Implementera en parametriserad konstruktor som använder this-nyckelordet
        // för att skilja mellan parametrar och klassens variabler.
        // Skapa en metod PrintDetails som skriver ut studentens namn och betyg.
        public static void PrintExercise3()
        {
            var student = new Student("Dennis", 'A');
            student.PrintDetails();
        }

        // Skapa en klass Employee med privata variabler name, position, och salary.
        // Implementera flera konstruktorer: en standardkonstruktor,
        // en konstruktor som accepterar namn och position, och en konstruktor som accepterar alla tre variabler.
        // Skapa en metod DisplayEmployee som skriver ut information om anställden.
        public static void PrintExercise4()
        {
            var employee1 = new Employee();
            var employee2 = new Employee("Dennis", "Programmer");
            var employee3 = new Employee("Sofia", "Dentist", 30_000);

            employee1.DisplayEmployee();
            employee2.DisplayEmployee();
            employee3.DisplayEmployee();
        }
    }
}
