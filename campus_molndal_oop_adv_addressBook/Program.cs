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
                        var (name, phone, email) = ReadHelper.GetContactDetails();
                        addressBook.AddContact(name, phone, email);
                        break;

                    case 2:
                        addressBook.DisplayContacts();
                        break;

                    case 3:
                        var (updateId, newName, newPhone, newEmail) = ReadHelper.GetUpdateContactDetails();
                        addressBook.UpdateContact(updateId, newName, newPhone, newEmail);
                        break;

                    case 4:
                        Console.Write("Ange kontakt-ID: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        addressBook.DeleteContact(deleteId);
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
