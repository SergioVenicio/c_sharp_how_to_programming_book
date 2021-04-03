using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_9_ArrayReferenceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 3 };
            int[] fisrtArrayCopy = firstArray;
            int[] secondArray = { 1, 2, 3 };
            int[] secondArrayCopy = secondArray;

            Console.WriteLine("Test passing firstArray reference by value");
            Console.WriteLine("Contents of firstArray");
            foreach (int element in firstArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine("");

            FirstDouble(firstArray);
            Console.WriteLine("Contents of firstArray before FirstDouble");
            foreach (int element in firstArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine("");

            Console.WriteLine("Contents of secondArray");
            foreach (int element in secondArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine("");

            SecondDouble(ref secondArray);
            Console.WriteLine("Contents of secondArray before SecondDouble");
            foreach (int element in secondArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine("");

            Console.ReadLine();
        }

        static void FirstDouble(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
            array = new int[] { 11, 12, 13 };
        }

        static void SecondDouble(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
            array = new int[] { 11, 12, 13 };
        }
    }
}
