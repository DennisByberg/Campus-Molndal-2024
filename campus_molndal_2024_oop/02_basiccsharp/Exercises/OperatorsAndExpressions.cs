using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class OperatorsAndExpressions
    {
        public static void PrintExercise1()
        {
            // Skapa ett program som beräknar och skriver ut följande:
            // Summan av 10 och 20.
            Console.WriteLine(10 + 20);

            // Skillnaden mellan 100 och 30.
            Console.WriteLine(100 - 30);

            // Produkten av 5 och 7.
            Console.WriteLine(5 * 7);

            // Kvoten när 20 delas med 4.
            Console.WriteLine(20 / 4);

            // Resten när 10 delas med 3.
            Console.WriteLine(10 % 3);
        }

        public static void PrintExercise2()
        {
            // Skapa ett program som jämför två tal, t.ex.a = 15 och b = 20, och skriver ut resultatet av följande jämförelser:
            const int a = 15;
            const int b = 20;

            // Är a lika med b?
            Console.WriteLine(a == b);
            // Är a större än b?
            Console.WriteLine(a > b);
            // Är a mindre än eller lika med b?
            Console.WriteLine(a <= b);
        }
    }
}
