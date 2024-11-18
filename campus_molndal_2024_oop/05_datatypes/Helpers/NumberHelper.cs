namespace campus_molndal_2024_oop._05_datatypes
{
    public static class NumberHelper
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
    }
}
