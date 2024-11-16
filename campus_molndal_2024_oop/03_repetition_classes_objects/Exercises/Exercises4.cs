using System;
using System.Xml.Linq;

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
    }
}
