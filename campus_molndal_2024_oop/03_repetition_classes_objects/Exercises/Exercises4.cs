using System;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public static class Exercises4
    {
        // Skapa en klass kallad Dog med fälten Name och Age, samt en metod Bark() som skriver ut ett meddelande.
        // Skapa två objektreferenser till samma Dog-objekt och använd den ena referensen för att ändra Age.
        // Visa att ändringen reflekteras när du använder den andra referensen.
        public static void PrintExercise1()
        {
            var dog1 = new Dog("Dog1", 10);
            var dog2 = dog1;

            dog1.Age = 5;

            Console.WriteLine($"dog1 Age: {dog1.Age}");  // 5
            Console.WriteLine($"dog2 Age: {dog2.Age}");  // 5

            dog1.Bark();  // Dog1 says Woof!!
            dog2.Bark();  // Dog1 says Woof!!
        }

        // Skapa en klass kallad House med fälten Address och Color.
        // Skapa en metod i en annan klass som tar ett House-objekt som parameter och ändrar Color.
        // Skapa ett objekt av House, passera det till metoden och visa att färgen ändras.
        public static void PrintExercise2()
        {
            var house = new House("Heljered 12,", "Blue");

            Console.WriteLine(house.Color); // Before
            ColorChanger.PaintHouseRed(house);
            Console.WriteLine(house.Color); // After paint
        }

        // Skapa en klass kallad Library med en metod GetBook(string title) som returnerar ett Book-objekt.
        // Skapa en klass Book med fälten Title och Author.
        // Skapa flera Book-objekt i Library och returnera ett objekt baserat på titeln som skickas till metoden.
        // Skapa en Main-metod där du använder GetBook() för att hämta en bok och sedan skriver ut dess information.
        public static void PrintExercise3()
        {
            var library = new Library();
            var book1 = new Book("Title1", "Author1");
            var book2 = new Book("Title2", "Author2");
            var book3 = new Book("Title3", "Author3");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library
                .GetBook("Title2")
                .PrintTitleAndAuthor();
        }

        // Skapa två objekt av klassen Person med samma fältvärden.
        // Implementera en Equals()-metod i klassen Person för att jämföra om två Person-objekt har samma Name och Age.
        // I Main, jämför de två objekten med == och.Equals() och förklara skillnaden.
        public static void PrintExercise4()
        {
            var person1 = new Person("Dennis", 30);
            var person2 = new Person("Dennis", 30);

            // False
            // The `==` operator checks if `person1` and `person2` refer to the same memory location (reference equality).
            // Since `person1` and `person2` are two separate instances (different memory locations), this returns False,
            // even though they have the same `Name` and `Age` values.
            Console.WriteLine(person1 == person2);

            // True
            // The `.Equals()` method, after being overridden in the `Person` class, checks if the `Name` and `Age` properties
            // of `person1` and `person2` are equal (value equality).
            // Since both objects have the same values for `Name` ("Dennis") and `Age` (30), this comparison returns True.
            Console.WriteLine(person1.Equals(person2));
        }

        // Skapa en klass BankAccount med fälten AccountNumber och Balance.
        // Skapa en metod TransferFunds(BankAccount from, BankAccount to, double amount) som överför pengar från ett konto till ett annat.
        // Testa att överföra pengar mellan två olika BankAccount-objekt och visa hur referenserna ändrar objektens tillstånd.
        public static void PrintExercise5()
        {
            var account1 = new BankAccount("123123123", 5000);
            var account2 = new BankAccount("954534822", 3000);

            Console.WriteLine($"account1 balance: {account1.GetBalance()}");
            Console.WriteLine($"account2 balance: {account2.GetBalance()}");

            account1.TransferFunds(account1, account2, 100);

            Console.WriteLine($"account1 balance: {account1.GetBalance()}");
            Console.WriteLine($"account2 balance: {account2.GetBalance()}");
        }
        // Skapa en klass Classroom som innehåller en lista över Student-objekt.
        // Skapa metoder i Classroom för att lägga till och ta bort Student-objekt från listan.
        // Implementera en metod som returnerar en referens till en Student-objekt baserat på studentens namn.
        // Testa klassen genom att skapa flera Student-objekt, lägga till dem i en Classroom, och sedan hämta en student från listan för att ändra deras information.
        public static void PrintExercise6()
        {
            var classroom = new Classroom();
            var student1 = new Student("Dennis");
            var student2 = new Student("Sofia");
            var student3 = new Student("Matteo");

            classroom.AddStudent(student1);
            classroom.AddStudent(student2);
            classroom.AddStudent(student3);

            classroom.PrintAllStudentsName();

            classroom
                .GetStudent("Dennis")
                .UpdateName("Dennis2");

            Console.WriteLine();

            classroom.PrintAllStudentsName();
        }
    }
}
