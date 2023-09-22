using System;

class Program
{
    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            if (array[middle] == target)
                return middle;

            if (array[middle] < target)
                left = middle + 1;
            else
                right = middle - 1;
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int target = 9;

        int index = BinarySearch(array, target);

        if (index != -1)
            Console.WriteLine(Искомый элемент найден на позиции {0}, index);
        else
            Console.WriteLine(Искомый элемент не найден);
    }
}