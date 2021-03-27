using System;

namespace _6_15_Factorial
{
    class Program
    {
        private static long factorial(int n)
        {
            return n <= 1 ? 1: n * factorial(n -1);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                long fat = factorial(i);
                Console.WriteLine($"{i}! = {fat}");
            }
            Console.ReadLine();
        }
    }
}
