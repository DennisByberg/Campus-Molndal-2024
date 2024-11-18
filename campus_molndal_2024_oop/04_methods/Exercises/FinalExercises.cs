using System;
using System.Reflection;
using System.Text;

namespace campus_molndal_2024_oop._04_methods
{
    public static class FinalExercises
    {
        // Skapa en klass SimpleCalculator som innehåller metoder för att addera, subtrahera, multiplicera och dividera två tal.Varje metod ska ta två parametrar och returnera resultatet.
        // Implementera en Main-metod som anropar alla dessa metoder med olika tal och skriver ut resultaten.
        public static void PrintExercise1()
        {
            Console.WriteLine(SimpleCalculator.Add(10, 5));
            Console.WriteLine(SimpleCalculator.Subtract(10, 5));
            Console.WriteLine(SimpleCalculator.Multiply(10, 5));
            Console.WriteLine(SimpleCalculator.Divide(10, 5));
        }

        // Skapa en klass Person som innehåller privata variabler för namn, ålder och stad.Implementera publika getter- och setter-metoder för varje variabel.
        // Skriv en Main-metod där du skapar flera instanser av Person, sätter värden för varje instans och skriver ut informationen med hjälp av getter-metoderna.
        public static void PrintExercise2()
        {
            var person1 = new Person2();
            var person2 = new Person2();

            person1.SetName("Dennis");
            person2.SetName("Sofia");

            Console.WriteLine(person1.GetName());
            Console.WriteLine(person2.GetName());
        }

        // Skapa en klass Car som har privata variabler för märke, modell och år.Implementera flera konstruktorer: en utan parametrar,
        // en som accepterar bara märke och modell, och en som accepterar alla tre variablerna.
        // Lägg till en metod DisplayCarInfo som skriver ut bilens information.
        // I Main-metoden, skapa instanser av Car med olika konstruktorer och anropa DisplayCarInfo för att visa bilens information.
        public static void PrintExercise3()
        {
            var car1 = new Car();
            var car2 = new Car("Ford", "Focus");
            var car3 = new Car("Tesla", "Cybertruck", 2024);

            car1.DisplayInfo();
            car2.DisplayInfo();
            car3.DisplayInfo();
        }

        // Implementera en rekursiv metod som tar ett heltal n som parameter och returnerar summan av alla heltal från 1 till n.
        // Testa metoden i Main-metoden med olika värden av n.
        public static void PrintExercise4()
        {
            Console.WriteLine(MathHelper.SumNumbers(3)); // 6
            Console.WriteLine(MathHelper.SumNumbers(5)); // 15
        }
    }
}
