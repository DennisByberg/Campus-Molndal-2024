using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public static class Exercises5
    {
        // Skapa en klass Library som har fält för Name och Location.
        // Skapa en klass Book med fält för Title, Author, och Year.
        // Lägg till en metod i Library som skriver ut bibliotekets namn och plats.
        // Skapa objekt av både Library och Book, och anropa metoderna för att visa information om biblioteket och en bok.
        public static void PrintExercise1()
        {
            var library = new Library("Kållered Bibliotek", "Kållered");
            var book = new Book("book1", "author1", 1994);
            var book2 = new Book("book2", "author2", 1993);

            library.AddBook(book);
            library.AddBook(book2);

            library.PrintNameAndLocation();
            library.PrintAllBooks();
        }

        // Skapa en klass Student med fält för Name, StudentId, och Grade.
        // Implementera en konstruktor som tar alla dessa värden som parametrar.
        // Skapa överlagrade konstruktörer så att du kan skapa en Student med endast Name och StudentId, och använda ett standardvärde för Grade.
        // Skapa objekt av Student med olika konstruktorer och skriv ut deras attribut.
        public static void PrintExercise2()
        {
            var student1 = new Student("Dennis");
            var student2 = new Student(1, "Sune");
            var student3 = new Student(2, "Sofia", "MVG");

            student1.PrintStudentInfo();
            Console.WriteLine("--- --- ---");
            student2.PrintStudentInfo();
            Console.WriteLine("--- --- ---");
            student3.PrintStudentInfo();
        }

        // Utöka klassen Student med en metod Study() som ökar studentens betyg(Grade) med en viss poäng.
        // Lägg till en metod PrintInfo() som skriver ut studentens namn och betyg.
        // Skapa flera Student-objekt och använd Study()-metoden för att förbättra deras betyg, och sedan PrintInfo() för att visa resultaten.
        public static void PrintExercise3()
        {
            var student = new Student(1, "Dennis", "G");

            student.PrintStudentInfo();
            student.Study();

            Console.WriteLine("\n--- After Study ---\n");

            student.PrintStudentInfo();
        }

        // Skapa en klass Teacher med fält för Name och Subject.
        // Skapa en metod Teach(Student student) som tar en Student-objektreferens och använder Study()-metoden för att öka studentens betyg.
        // Skapa objekt av Teacher och Student och visa hur läraren kan påverka studentens betyg genom att använda metoden Teach()
        public static void PrintExercise4()
        {
            var student = new Student(1, "Dennis", "G");
            var teacher = new Teacher("Sune", "Programming");

            Console.WriteLine("--- Before Teach ---");
            student.PrintStudentInfo();

            teacher.Teach(student);

            Console.WriteLine("\n--- After Teach ---");
            student.PrintStudentInfo();
        }

        // Skapa en klass Department som har en lista av Teacher-objekt.
        // Lägg till metoder för att lägga till och ta bort lärare från avdelningen.
        // Skapa flera Teacher-objekt och lägg till dem i en Department.
        // Visa hur förändringar i en Teacher-objekts fält reflekteras i Department genom att använda olika referenser.
        public static void PrintExercise5()
        {
            var department = new Department();
            var teacher1 = new Teacher("Sune", "Programming");
            var teacher2 = new Teacher("Polka", "Science");
            var teacher3 = new Teacher("Gösta", "Math");

            department.AddTeacher(teacher1);
            department.AddTeacher(teacher2);
            department.AddTeacher(teacher3);

            Console.WriteLine("--- BEFORE REMOVE ---");
            department.PrintAllTeacherNames();

            department.RemoveTeacher(teacher3);

            Console.WriteLine("\n--- AFTER REMOVE ---");
            department.PrintAllTeacherNames();
        }
    }
}