using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class SwitchStatementsExercises
    {
        //Skriv ett program som tar en månad(som ett heltal från 1 till 12) och skriver ut motsvarande månads namn.Använd en switch-sats.
        public static void PrintExercise1()
        {
            int month = 1;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Januari");
                    break;
                case 2:
                    Console.WriteLine("Februari");
                    break;
                case 3:
                    Console.WriteLine("Mars");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Juni");
                    break;
                case 7:
                    Console.WriteLine("Juli");
                    break;
                case 8:
                    Console.WriteLine("Augusti");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }
        }

        public static void PrintExercise2()
        {
            int grade = 5;

            switch (grade)
            {
                case 0:
                    Console.WriteLine('F');
                    break;

                case 1:
                    Console.WriteLine('E');
                    break;

                case 2:
                    Console.WriteLine('D');
                    break;

                case 3:
                    Console.WriteLine('C');
                    break;

                case 4:
                    Console.WriteLine('B');
                    break;

                case 5:
                    Console.WriteLine('A');
                    break;

                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }
    }
}
