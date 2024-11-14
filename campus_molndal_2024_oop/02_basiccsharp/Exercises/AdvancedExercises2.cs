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
    }
}
