using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5_StudentPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] frequency = new int[11];
            int[] responses =
            {
                1, 2, 6, 4, 8, 5, 9, 7, 8, 10,
                1, 6, 3, 8, 6, 10, 3, 8, 2, 7,
                6, 5, 7, 6, 8, 6, 7, 5, 6, 6,
                5, 6, 7, 5, 6, 4, 8, 6, 8, 10
            };

            foreach (int answer in responses)
            {
                frequency[answer]++;
            }

            Console.WriteLine("Rating\tFrequency");
            for (int rating = 1; rating < frequency.Length; rating++)
            {
                Console.WriteLine($"{rating}\t{frequency[rating]}");
            }

            Console.ReadLine();
        }
    }
}
