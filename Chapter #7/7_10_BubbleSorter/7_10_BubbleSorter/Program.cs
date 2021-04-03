using System;

namespace _7_10_BubbleSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 6, 4, 8, 10, 12, 89, 68, 45, 37 };
            BubbleSort(array);
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }

        static void BubbleSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j);
                    }
                }
            }
        }

        static void Swap(int[] array, int start)
        {
            var hold = array[start];
            array[start] = array[start + 1];
            array[start + 1] = hold;
        }
    }
}
