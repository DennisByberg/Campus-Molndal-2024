using System;

namespace campus_molndal_oop_adv_addressBook.Helpers
{
    internal static class PrintHelper
    {
        internal static void PrintMenu()
        {
            Console.WriteLine("Adressbok 1.0\n");
            Console.WriteLine("1. Lägg till kontakt");
            Console.WriteLine("2. Visa kontakter");
            Console.WriteLine("5. Avsluta");
            Console.Write("Välj ett alternativ: ");
        }
    }
}
