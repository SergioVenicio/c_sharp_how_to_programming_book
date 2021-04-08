using System;

namespace _10_24_DelegateBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elementArray = new int[10];

            Random randomNumber = new Random();
            for (int i = 0; i < elementArray.Length; i++)
            {
                elementArray[i] = randomNumber.Next(100);
            }

            Console.WriteLine("Unsorted");
            foreach (int element in elementArray)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Sorted Asc");
            DelegateBubbleSort.SortArray(
                elementArray,
                new DelegateBubbleSort.Comparator((int el, int el2) => el > el2)
            );
            foreach (int element in elementArray)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Sored Desc");
            DelegateBubbleSort.SortArray(
                elementArray,
                new DelegateBubbleSort.Comparator((int el, int el2) => el < el2)
            );
            foreach (int element in elementArray)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
