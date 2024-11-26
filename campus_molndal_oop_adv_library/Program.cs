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
                Console.WriteLine("3. Add Loan");
                Console.WriteLine("4. Update Loan");
                Console.WriteLine("5. Display Books");
                Console.WriteLine("6. Display Borrowers");
                Console.WriteLine("7. Exit");
                Console.Write(">> ");

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

                    // Add Loan
                    case 3:
                        Console.Write("Enter Book Id: ");
                        if (!int.TryParse(Console.ReadLine(), out int bookId))
                        {
                            Console.WriteLine("Invalid Input");
                            continue;
                        }

                        Console.Write("Enter Borrower Id: ");
                        if (!int.TryParse(Console.ReadLine(), out int borrowerId))
                        {
                            Console.WriteLine("Invalid Input");
                            continue;
                        }

                        library.BorrowBook(bookId, borrowerId, DateTime.UtcNow);
                        break;

                    // Update Loan
                    case 4:
                        Console.Write("Enter Loan Id To Return: ");
                        if (!int.TryParse(Console.ReadLine(), out int loanId))
                        {
                            Console.WriteLine("Invalid input");
                            continue;
                        }

                        library.ReturnBook(loanId, DateTime.Now);
                        break;

                    // Display Books
                    case 5:
                        Console.WriteLine("\n-");
                        library.DisplayBooks();
                        Console.WriteLine("-\n");
                        break;

                    // Display Borrowers
                    case 6:
                        Console.WriteLine("\n-");
                        library.DisplayBorrowers();
                        Console.WriteLine("-\n");
                        break;

                    // Exit
                    case 7:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }
            }
        }
    }
}
