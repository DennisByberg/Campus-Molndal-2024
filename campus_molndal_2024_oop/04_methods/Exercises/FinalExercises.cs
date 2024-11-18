using campus_molndal_2024_oop._03_repetition_classes_objects;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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

        // Skapa en klass Book som innehåller privata variabler för titel, författare och pris.
        // Implementera en parametriserad konstruktor för att sätta dessa värden.
        // Implementera metoder för att visa information om boken samt för att applicera en rabatt på priset.
        // Skapa instanser av Book i Main-metoden, tillämpa olika rabatter och visa bokinformationen efter varje rabatt.
        public static void PrintExercise5()
        {
            var book1 = new Book("C# Programming", "John Doe", 299.99);
            var book2 = new Book("Learning OOP", "Jane Smith", 149.50);

            Console.WriteLine("--- Before Discount ---");
            book1.DisplayInfo();
            book2.DisplayInfo();

            Console.WriteLine("\n--- Applying Discounts --");

            // Applicera rabatt och visa information igen
            book1.ApplyDiscount(20); // 20% rabatt
            book1.DisplayInfo();

            Console.WriteLine();

            book2.ApplyDiscount(10); // 10% rabatt
            book2.DisplayInfo();
        }

        // Implementera en metod för binärsökning som söker efter ett visst värde i en sorterad array av heltal.Om värdet hittas, returnera dess index, annars returnera -1.
        // Använd rekursion i din implementation.
        // Testa metoden i Main-metoden med olika sorterade arrayer och sökord.
        public static void PrintExercise6()
        {
            // Recursive method for binary search
            int BinarySearch(int[] arr, int left, int right, int target)
            {
                if (right >= left)
                {
                    int middle = left + (right - left) / 2;

                    if (arr[middle] == target)
                        return middle;

                    if (arr[middle] > target)
                        return BinarySearch(arr, left, middle - 1, target);

                    return BinarySearch(arr, middle + 1, right, target);
                }

                return -1;
            }

            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target1 = 5;
            int result1 = BinarySearch(arr1, 0, arr1.Length - 1, target1);
            Console.WriteLine(result1 != -1 ? $"Found at index {result1}" : "Not found");
        }


        // Skapa en klass Student med privata variabler för namn, ålder och betyg.
        // Implementera publika getter- och setter-metoder med validering(t.ex.åldern måste vara ett positivt heltal, och betyget måste vara mellan A och F).
        // Skapa en StudentRegister-klass som kan hålla flera Student-objekt i en lista.
        // Implementera metoder för att lägga till en student, ta bort en student baserat på namn, och för att visa alla studenter i registret.
        // I Main-metoden, testa att lägga till och ta bort studenter samt att visa studentregistret.
        public static void PrintExercise7()
        {
            var studentRegister = new StudentRegister();
            var student1 = new Student("Dennis", 'A');
            var student2 = new Student("Sofia", 'B');
            var student3 = new Student("Matteo", 'C');
            var student4 = new Student("Sune", 'D');

            studentRegister.AddStudent(student1);
            studentRegister.AddStudent(student2);
            studentRegister.AddStudent(student3);
            studentRegister.AddStudent(student4);

            Console.WriteLine("--- AFTER 4 ADDS ---");
            studentRegister.DisplayAllStudents();

            studentRegister.RemoveStudent("Sune");

            Console.WriteLine("\n--- AFTER REMOVE SUNE ---");
            studentRegister.DisplayAllStudents();
        }

        // Implementera en rekursiv metod som beräknar Fibonacci-tal.
        // Metoden ska ta ett heltal n som parameter och returnera det n:te Fibonacci-talet.
        // Använd metoden i Main-metoden för att generera de första 10 Fibonacci-talen och skriv ut dem.
        public static void PrintExercise8()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"Fibonacci({i}) = {MathHelper.Fibonacci(i)}");
        }
    }
}
