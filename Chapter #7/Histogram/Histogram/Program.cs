using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 19, 3, 15, 7, 11, 9, 13, 5, 17, 1 };

            Console.WriteLine("Element\tValue\tHistogram");
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write($"\n{i}\t{n[i]}\t");
                for (int j = 1; j <= n[i]; j++)
                {
                    Console.Write("*");
                }
            }

            Console.ReadLine();
        }
    }
}
