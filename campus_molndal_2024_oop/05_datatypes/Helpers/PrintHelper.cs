using System;

namespace campus_molndal_2024_oop._05_datatypes
{
    public static class PrintHelper
    {
        public static void PrintArray(int[] arr)
        {
            Console.Write("[ ");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("]");
        }
    }
}
