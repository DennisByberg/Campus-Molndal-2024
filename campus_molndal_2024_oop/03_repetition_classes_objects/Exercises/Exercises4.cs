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
    }
}
