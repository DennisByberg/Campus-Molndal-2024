using campus_molndal_oop_adv_addressBook.Helpers;
using System;

namespace campus_molndal_oop_adv_addressBook
{
    internal static class Program
    {
        static void Main()
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                PrintHelper.PrintMenu();

                int choice = int.Parse(Console.ReadLine() ?? "0");

                switch (choice)
                {
                    case 1:
                        Console.Write("Ange namn: ");
                        string name = Console.ReadLine();
                        Console.Write("Ange telefon: ");
                        string phone = Console.ReadLine();
                        Console.Write("Ange e-post: ");
                        string email = Console.ReadLine();
                        addressBook.AddContact(name, phone, email);
                        break;

                    case 2:
                        addressBook.DisplayContacts();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }
}
