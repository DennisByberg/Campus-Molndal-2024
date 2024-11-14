namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class AdvancedExercises2
    {
        // Skapa en klass Rectangle med attributen Width och Height.
        // Lägg till en metod CalculateArea() som beräknar och returnerar rektangelns area.
        // Skapa ett objekt och anropa metoden för att beräkna och skriva ut arean.
        public static void PrintExercise1()
        {
            var rectangle = new Rectangle(10, 10);

            rectangle.CalculateAndPrintArea();
        }

        // Skapa en klass Circle med attributet Radius och en metod CalculateCircumference() som beräknar och returnerar cirkelns omkrets.
        // Använd Math.PI för att få värdet av pi.
        // Skapa ett objekt och beräkna omkretsen.
        public static void PrintExercise2()
        {
            var circle = new Circle(10);
            System.Console.WriteLine($"The circumference of the circle is {circle.CalculateCircumference()}");
        }

        // Utvidga klassen Rectangle från Uppgift 3.1 med en konstruktor som tar
        // Width och Height som parametrar och en metod CalculateCircumference() som beräknar rektangelns omkrets.
        public static void PrintExercise3()
        {
            var rectangle = new Rectangle(5, 8);

            System.Console.WriteLine($"The circumference of the rectangle is {rectangle.CalculateCircumference()}");
        }
    }
}
