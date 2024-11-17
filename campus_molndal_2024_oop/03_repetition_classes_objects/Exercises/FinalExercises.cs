using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public static class FinalExercises
    {
        // Skapa en klass Dog med fälten Name och Age.
        // Skapa ett objekt av klassen Dog och tilldela värden till fälten.
        // Implementera en metod i Dog som skriver ut hundens namn och ålder.
        // Anropa metoden och se till att informationen skrivs ut korrekt.
        public static void PrintExercise1()
        {
            var dog = new Dog("Sune", 5);
            dog.PrintNameAndAge();
        }

        // Skapa en klass Car med fälten Brand, Model, och Year.
        // Implementera en konstruktor som initialiserar alla fälten.
        // Skapa en metod i Car som skriver ut bilens information i formatet "Brand: [Brand], Model: [Model], Year: [Year]".
        // Skapa ett objekt av klassen Car och anropa metoden för att skriva ut bilens information.
        public static void PrintExercise2()
        {
            var car = new Car("Volvo", "XC90", 2019);
            car.PrintInfo();
        }

        // Skapa en klass Book med fälten Title, Author, och PublicationYear.
        // Skapa en klass Library med fältet LibraryName och en metod som tar en Book-referens som parameter och skriver ut bokens titel och författare.
        // Skapa ett objekt av klassen Library och några objekt av klassen Book.
        // Använd metoden i Library för att skriva ut information om en av böckerna.
        public static void PrintExercise3()
        {
            var library = new Library("Kållered Bibliotek");
            var book1 = new Book("book1", "author1", 2001);
            var book2 = new Book("book2", "author2", 2002);

            library.AddBook(book1);
            library.AddBook(book2);

            library.PrintInfoAboutBook(book1);
        }

        // Skapa en klass Student med fälten Name, StudentId, och Grade.
        // Implementera flera konstruktörer: en som tar alla tre fälten som parametrar och en som endast tar Name och StudentId (med ett standardvärde för Grade).
        // Skapa objekt av Student med båda konstruktörerna och skriv ut studentens information.
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

        // Skapa klasserna Author och Book.
        // I Author, inkludera fälten Name och Nationality.
        // I Book, inkludera fälten Title, Author, och PublicationYear.
        // Skapa en metod i Book som skriver ut bokens titel och författarens namn och nationalitet.
        // Skapa objekt av både Author och Book och anropa metoden för att visa bokens och författarens information.
        public static void PrintExercise6()
        {
            var author = new Author("Charles Dickens", "England");
            var book = new Book2("Oliver Twist", author, 1837);

            book.PrintTitleAndAuthorInfo();
        }

        // Skapa en klass BankAccount med fälten AccountNumber och Balance.
        // Implementera en metod Deposit(double amount) som ökar saldot med det angivna beloppet.
        // Implementera en metod Withdraw(double amount) som minskar saldot med det angivna beloppet om det finns tillräckligt med pengar, annars skriv ut ett felmeddelande.
        // Skapa ett BankAccount-objekt och testa båda metoderna.
        public static void PrintExercise7()
        {
            var bankAccount = new BankAccount("123123123", 10_000);
            Console.WriteLine($"After Instantiation: {bankAccount.GetBalance()}");

            bankAccount.Withdraw(1000);
            Console.WriteLine($"After Withdraw 1000: {bankAccount.GetBalance()}");

            bankAccount.Deposit(25_000);
            Console.WriteLine($"After Deposit 25_000: {bankAccount.GetBalance()}");
        }

        // Skapa en klass Engine med fälten Horsepower och Type.
        // Skapa en klass Car med fälten Brand, Model, Year, och en Engine.
        // Implementera en konstruktor i Car som tar alla fälten som parametrar och länkar en Engine till Car.
        // Implementera en metod i Car som skriver ut bilens och motorns information.
        // Skapa ett Car-objekt och anropa metoden för att visa all information.
        public static void PrintExercise8()
        {
            var engine = new Engine(140, "Normal");
            var car = new Car("Ford", "Focus", 2023, engine);

            car.PrintInfo();
        }

        // Skapa klasserna Teacher och Student.
        // I Teacher, inkludera fälten Name och Subject.
        // I Student, inkludera fälten Name och en referens till en Teacher.
        // Implementera en metod i Student som skriver ut studentens namn och lärarens namn och ämne.
        // Skapa objekt av både Teacher och Student och länka dem, sedan anropa metoden i Student.
        public static void PrintExercise9()
        {
            var teacher = new Teacher("Sune", "Catologi");
            var student = new Student("Dennis", teacher);

            student.PrintStudentNameAndTeacherInfo();
        }
    }
}
