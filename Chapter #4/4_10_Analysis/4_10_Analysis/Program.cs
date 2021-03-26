using System;
using System.Collections.Generic;

namespace _4_10_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Results = new List<double>();

            while (Results.Count < 10)
            {
                Console.Write("Result (1-Pass, 2-Fail): ");
                var result = Convert.ToInt32(Console.ReadLine());
                Results.Add(result);
            }

            int paissed = Results.FindAll(r => r == 1).Count;
            int failed = Results.FindAll(r => r != 1).Count;

            Console.WriteLine($"Paissed: {paissed}");
            Console.WriteLine($"Failed: {failed}");

            if (paissed > 8)
            {
                Console.WriteLine("Raise Tuition");
            }

            Console.ReadKey();
        }
    }
}
