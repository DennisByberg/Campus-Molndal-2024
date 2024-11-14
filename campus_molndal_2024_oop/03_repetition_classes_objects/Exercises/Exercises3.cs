using System;
using System.Xml.Linq;

namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public static class Exercises3
    {
        // Skapa en klass kallad Person med fälten Name, Age, och Email.
        // Skapa en anpassad konstruktor som tar alla tre fälten som parametrar och initialiserar dem.
        // Skapa ett objekt av klassen Person och skriv ut alla fält.
        public static void PrintExercise1()
        {
            var person = new Person("Dennis", 30, "dennis@gmail.com");

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Email);
        }

        // Utöka klassen Person med en andra konstruktor som endast tar Name och Age, och tilldelar en standard Email.
        // Skapa en tredje konstruktor som inte tar några parametrar och som sätter alla fält till standardvärden.
        // Skapa flera objekt av klassen Person med hjälp av de olika konstruktörerna och skriv ut alla fält för att verifiera att konstruktörerna fungerar som förväntat.
        public static void PrintExercise2()
        {
            var person = new Person("Dennis", 30, "dennis@gmail.com");
            var person2 = new Person("Sofia", 27);
            var person3 = new Person();

            person.Introduce();
            person2.Introduce();
            person3.Introduce();
        }

        // Modifiera de överlagrade konstruktörerna i klassen Person för att använda this() för att undvika kodupprepning.
        // Verifiera att objekten fortfarande skapas korrekt med hjälp av de modifierade konstruktörerna.
        public static void PrintExercise3()
        {
            var person = new Person("Dennis", 30, "dennis@gmail.com");
            var person2 = new Person("Sofia", 27);
            var person3 = new Person();

            person.Introduce();
            person2.Introduce();
            person3.Introduce();
        }

        //Lägg till validering i konstruktorerna i klassen Person för att säkerställa att Age alltid är ett positivt tal.
        //Om ett ogiltigt värde ges, kasta ett undantag (ArgumentException).
        //Skapa ett objekt med ett ogiltigt Age-värde och se vad som händer.
        public static void PrintExercise4()
        {
            //var person = new Person("Dennis", -1, "dennis@gmail.com"); // THROWS.
        }
    }
}
