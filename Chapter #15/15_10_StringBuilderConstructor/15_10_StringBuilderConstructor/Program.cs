using System;
using System.Text;

namespace _15_10_StringBuilderConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder buffer1, buffer2, buffer3;
            string output;

            buffer1 = new StringBuilder();
            buffer2 = new StringBuilder(10);
            buffer3 = new StringBuilder("hello");

            Console.WriteLine($"buffer1 = {buffer1.ToString()}");
            Console.WriteLine($"buffer2 = {buffer2.ToString()}");
            Console.WriteLine($"buffer3 = {buffer3.ToString()}");

            buffer3.Append(" ");
            buffer3.Append("world!");

            Console.WriteLine($"buffer3 = {buffer3.ToString()}");

            Console.ReadLine();
        }
    }
}
