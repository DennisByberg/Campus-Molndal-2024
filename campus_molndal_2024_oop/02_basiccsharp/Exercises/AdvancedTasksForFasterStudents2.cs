using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    // Skriv ett program som simulerar en enkel miniräknare.Användaren matar in två tal och väljer en operation
    // (addition, subtraktion, multiplikation, division). Använd en switch-sats för att utföra den valda operationen och skriv ut resultatet.
    public static class AdvancedTasksForFasterStudents2
    {
        public static void PrintExercise1()
        {
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Operator(+, -, / or *): ");
            string operatorChoice = Console.ReadLine();

            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (operatorChoice)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;

                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }
    }
}
