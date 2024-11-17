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
    }
}
