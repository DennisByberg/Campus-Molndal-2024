using campus_molndal_oop_adv_todo.Models;
using System;

namespace campus_molndal_oop_adv_todo.Helpers
{
    internal static class ReadHelper
    {
        public static TodoItem GetTodoInput()
        {
            Console.Write("Enter todo description: ");
            var description = Console.ReadLine();

            Console.Write("Enter 1 if completed, otherwise 0: ");
            var isCompleted = int.Parse(Console.ReadLine());

            // Create and return a new TodoItem object with the input data
            return new TodoItem
            {
                Description = description,
                IsCompleted = isCompleted,
                CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };
        }

        public static TodoItem GetTodoUpdateInput()
        {
            Console.Write("Enter Todo ID: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Description: ");
            var description = Console.ReadLine();

            Console.Write("Enter 1 if completed, otherwise 0: ");
            var isCompleted = int.Parse(Console.ReadLine());

            // Create and return a new TodoItem object with the input data
            return new TodoItem
            {
                Id = id,
                Description = description,
                IsCompleted = isCompleted,
                CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };
        }
    }
}
