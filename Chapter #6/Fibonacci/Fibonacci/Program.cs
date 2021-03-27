using System;


namespace Fibonacci
{
    class Program
    {
        static long fibonacci(long n)
        {
            return n == 0 || n == 1 ? n : fibonacci(n - 1) + fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; i++)
            {
                Console.WriteLine($"fibo({i}) = {fibonacci(i)}");
            }
            Console.ReadLine();
        }
    }
}
