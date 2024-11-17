using System;
using System.Xml.Linq;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public static class FinalExercises
    {
        public static void PrintExercise1()
        {
            var dog = new Dog("Sune", 5);
            dog.PrintNameAndAge();
        }

        public static void PrintExercise2()
        {
            var car = new Car("Volvo", "XC90", 2019);
            car.PrintInfo();
        }

        public static void PrintExercise3()
        {
            var library = new Library("Kållered Bibliotek");
            var book1 = new Book("book1", "author1", 2001);
            var book2 = new Book("book2", "author2", 2002);

            library.AddBook(book1);
            library.AddBook(book2);

            library.PrintInfoAboutBook(book1);
        }

        public static void PrintExercise4()
        {
            var student1 = new Student(1, "Dennis", "MVG");
            var student2 = new Student(2, "Sofia");


            student1.PrintStudentInfo();
            Console.WriteLine("--- --- ---");
            student2.PrintStudentInfo();
        }

        // Skapa en klass Rectangle med fälten Width och Height.
        // Implementera en metod CalculateArea() som beräknar och returnerar rektangelns area.
        // Implementera en metod CalculatePerimeter() som beräknar och returnerar rektangelns omkrets.
        // Skapa ett objekt av Rectangle och anropa båda metoderna, skriv ut resultaten.
        public static void PrintExercise5()
        {
            var rectangle = new Rectangle(15.1, 10.7);

            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Rectangle Perimeter: {rectangle.CalculatePerimeter()}");
        }
    }
}
