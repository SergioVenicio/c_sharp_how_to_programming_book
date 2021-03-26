using System;

namespace _3_19_Comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("N1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("N2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine($"{n1} == {n2}");
            }

            if (n1 != n2)
            {
                Console.WriteLine($"{n1} != {n2}");
            }

            if (n1 < n2)
            {
                Console.WriteLine($"{n1} < {n2}");
            }

            if (n1 > n2)
            {
                Console.WriteLine($"{n1} > {n2}");
            }

            Console.ReadKey();
        }
    }
}
