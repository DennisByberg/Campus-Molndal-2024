using campus_molndal_2024_oop._07_inheritance.Classes;
using campus_molndal_2024_oop._07_inheritance.Interfaces;
using System;
using System.Collections.Generic;

namespace campus_molndal_2024_oop._07_inheritance.Exercises
{
    public static class Exercises4
    {
        // 1. Skapa en abstrakt klass Employee med en abstrakt metod CalculateSalary().
        // 2. Skapa två underklasser FullTimeEmployee och PartTimeEmployee som implementerar CalculateSalary() på olika sätt.
        // 3. Implementera metoden CalculateSalary() i båda underklasserna för att beräkna lönen baserat på anställningstyp.
        // 4. Skapa objekt av båda typerna och använd polymorfism för att anropa CalculateSalary().
        public static void PrintExercise1()
        {
            var fullTime = new FullTimeEmployee("Dennis", 20000);
            var partTime = new PartTimeEmployee("Sofia", 190, 160);

            Console.WriteLine(fullTime.Name + "'s Salary: " + fullTime.CalculateSalary());
            Console.WriteLine(partTime.Name + "'s Salary: " + partTime.CalculateSalary());
        }

        // 1. Skapa ett gränssnitt Payable med metoden Pay().
        // 2. Låt klasserna FullTimeEmployee och PartTimeEmployee implementera Payable och definiera metoden Pay().
        // 3. Implementera metoden Pay() så att den skriver ut en betalningsbekräftelse med anställdas namn och lön.
        // 4. Använd polymorfism för att anropa Pay()-metoden via en Payable-referens.
        public static void PrintExercise2()
        {
            IPayable fullTimePayable = new FullTimeEmployee("Dennis", 20000);
            IPayable partTimePayable = new PartTimeEmployee("Sofia", 190, 160);

            fullTimePayable.Pay();
            partTimePayable.Pay();
        }

        // 1. Skapa ett system för en djurpark där du har en abstrakt klass Animal, flera underklasser som Lion, Elephant och Giraffe, samt ett gränssnitt Feedable med en metod Feed().
        // 2. Implementera en metod Feed() i varje djurklass som specificerar vad djuret äter.
        // 3. Skapa en lista av Feedable-objekt och iterera genom den för att mata alla djur i djurparken.
        public static void PrintChallenge()
        {
            List<IFeedable> zoo = new List<IFeedable>();
            var lion = new Lion();
            var elephant = new Elehant();
            var giraffe = new Giraffe();

            zoo.Add(lion);
            zoo.Add(elephant);
            zoo.Add(giraffe);


            foreach (var animal in zoo)
            {
                animal.Feed();
            }
        }
    }
}
