using System;

namespace campus_molndal_oop_adv_library
{
    internal static class Program
    {
        static void Main()
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Borrower");
                Console.WriteLine("3. Display Books");
                Console.WriteLine("4. Display Borrowers");
                Console.WriteLine("5. Exit");
                Console.Write(">> ");

                // Kontrollera om inmatningen är en giltig siffra
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                switch (choice)
                {
                    // Add Book
                    case 1:
                        Console.Write("Enter Title: ");
                        var title = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        var author = Console.ReadLine();

                        Console.Write("Enter Publication Year: ");
                        if (!int.TryParse(Console.ReadLine(), out int publicationYear))
                        {
                            Console.WriteLine("Invalid input for Publication Year. Please try again.");
                            continue;
                        }

                        library.AddBook(title, author, publicationYear);
                        break;

                    // Add Borrower
                    case 2:
                        Console.Write("Enter Name: ");
                        var name = Console.ReadLine();

                        Console.Write("Enter Email: ");
                        var email = Console.ReadLine();

                        library.AddBorrower(name, email);
                        break;

                    // Display Books
                    case 3:
                        Console.WriteLine("\n-");
                        library.DisplayBooks();
                        Console.WriteLine("-\n");
                        break;

                    // Display Borrowerss
                    case 4:
                        Console.WriteLine("\n-");
                        library.DisplayBorrowers();
                        Console.WriteLine("-\n");
                        break;

                    // Exit.
                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }
            }
        }
    }
}
