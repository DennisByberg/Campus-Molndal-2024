using campus_molndal_oop_adv_todo.Helpers;
using campus_molndal_oop_adv_todo.Models;
using System;

namespace campus_molndal_oop_adv_todo
{
    internal static class Program
    {
        static void Main()
        {
            TodoList todoList = new TodoList();

            while (true)
            {
                PrintHelper.PrintMenu();
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        TodoItem todoItem = ReadHelper.GetTodoInput();
                        todoList.AddTodo(todoItem.Description, todoItem.CreatedOn, todoItem.IsCompleted);
                        break;

                    case 2:
                        Console.WriteLine("1. ... Show All Todos");
                        Console.WriteLine("2. ... Show Completed Todos");
                        Console.WriteLine("3. ... Show Not Completed Todos");
                        Console.WriteLine("4. Go Back");
                        Console.Write(">> ");
                        int filterChoise = int.Parse(Console.ReadLine());

                        switch (filterChoise)
                        {
                            case 1:
                                Console.WriteLine("\n-----------------");
                                todoList.DisplayAllTodos();
                                Console.WriteLine("-----------------\n");
                                break;

                            case 2:
                                Console.WriteLine("\n-----------------");
                                todoList.DisplayCompletedTodos();
                                Console.WriteLine("-----------------\n");
                                break;

                            case 3:
                                Console.WriteLine("\n-----------------");
                                todoList.DisplayNotCompletedTodos();
                                Console.WriteLine("-----------------\n");
                                break;

                            case 4:
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Invalid input");
                                break;
                        }
                        break;

                    case 3:
                        TodoItem todoUpdateItem = ReadHelper.GetTodoUpdateInput();
                        todoList.UpdateTodo(todoUpdateItem.Id, todoUpdateItem.Description, todoUpdateItem.IsCompleted, todoUpdateItem.CreatedOn);
                        break;

                    case 4:
                        Console.Write("Enter the ID you want to delete: ");
                        var idToDelete = int.Parse(Console.ReadLine());
                        todoList.DeleteTodo(idToDelete);
                        break;

                    case 5:
                        return; // EXIT.

                    default:
                        Console.WriteLine("Invalid choise, try again!");
                        break;
                }
            }
        }
    }
}
