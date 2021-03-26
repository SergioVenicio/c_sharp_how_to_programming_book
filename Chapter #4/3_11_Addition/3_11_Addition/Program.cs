using System;

namespace _3_11_Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.ReadKey();
        }
    }
}
