using System;

namespace campus_molndal_oop_adv_todo.Helpers
{
    internal static class PrintHelper
    {
        public static void PrintMenu()
        {
            Console.WriteLine("1. Add Todo");
            Console.WriteLine("2. Show All Todos");
            Console.WriteLine("3. Update A Todo");
            Console.WriteLine("4. Delete A Todo");
            Console.WriteLine("5. Exit");
        }
    }
}
