namespace campus_molndal_2024_oop._05_datatypes
{
    public static class ArrayHelper
    {
        public static int GetBiggestNumberInArray(int[] arr)
        {
            var biggestNumber = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > biggestNumber)
                    biggestNumber = arr[i];
            }

            return biggestNumber;
        }

        public static int GetSmallestNumberInArray(int[] arr)
        {
            var smallestNumber = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallestNumber)
                    smallestNumber = arr[i];
            }

            return smallestNumber;
        }

        public static int[] ReverseArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int index = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newArr[index] = arr[i];
                index++;
            }

            return newArr;
        }

        public static int SumArray(int[] numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
                sum += number;

            return sum;
        }

        public static int EvenNumberCounter(int[] numbers)
        {
            var evenNumberCounter = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumberCounter++;
                }
            }

            return evenNumberCounter;
        }

        public static int CountOccurrences(int[] arr, int target)
        {
            int count = 0;
            foreach (var num in arr)
            {
                if (num == target)
                {
                    count++;
                }
            }
            return count;
        }
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
