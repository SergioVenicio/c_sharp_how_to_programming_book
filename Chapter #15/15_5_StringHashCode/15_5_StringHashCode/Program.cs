using System;

namespace _15_5_StringHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "hello";
            string string2 = "Hello";

            Console.WriteLine($"The hash code for {string1} is {string1.GetHashCode()}");
            Console.WriteLine($"The hash code for {string2} is {string2.GetHashCode()}");
            Console.ReadLine();
        }
    }
}
