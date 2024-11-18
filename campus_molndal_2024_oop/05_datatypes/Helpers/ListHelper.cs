using System;
using System.Collections.Generic;
using System.Linq;

namespace campus_molndal_2024_oop._05_datatypes
{
    public static class ListHelper
    {
        public static int GetBiggestIntInList(List<int> numbers)
        {
            if (numbers.Count > 0)
            {
                var biggestNumber = numbers[0];
                foreach (var number in numbers)
                {
                    if (number > biggestNumber)
                        biggestNumber = number;
                }

                return biggestNumber;
            }

            throw new ArgumentException("List is empty");
        }

        public static int GetSmallestIntInList(List<int> numbers)
        {
            if (numbers == null || numbers.Count <= 0)
                throw new ArgumentException("The list is empty or null");

            return numbers.Min();
        }

        public static int LinearSearch(List<int> list, int key)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i] == key) return i;

            return -1;
        }
    }
}