using System;

namespace campus_molndal_oop_adv_addressBook.Helpers
{
    internal static class ReadHelper
    {
        public static (string name, string phone, string email) GetContactDetails()
        {
            Console.Write("Ange namn: ");
            string name = Console.ReadLine();
            Console.Write("Ange telefon: ");
            string phone = Console.ReadLine();
            Console.Write("Ange e-post: ");
            string email = Console.ReadLine();

            return (name, phone, email);
        }

        public static (int Id, string Name, string Phone, string Email) GetUpdateContactDetails()
        {
            Console.Write("Ange kontakt-ID: ");
            int updateId = int.Parse(Console.ReadLine());
            Console.Write("Ange nytt namn: ");
            string newName = Console.ReadLine();
            Console.Write("Ange ny telefon: ");
            string newPhone = Console.ReadLine();
            Console.Write("Ange ny e-post: ");
            string newEmail = Console.ReadLine();

            return (updateId, newName, newPhone, newEmail);
        }
    }
}
