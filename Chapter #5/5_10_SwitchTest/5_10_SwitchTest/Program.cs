using System;
using System.Collections.Generic;

namespace _5_10_SwitchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a letter grade: ");
                var grade = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (grade)
                {
                    case 'A':
                        a++;
                        break;
                    case 'B':
                        b++;
                        break;
                    case 'C':
                        c++;
                        break;
                    case 'D':
                        d++;
                        break;
                    case 'E':
                        e++;
                        break;
                    case 'F':
                        f++;
                        break;
                    default:
                        Console.WriteLine("Incorrect letter grade!");
                        break;
                }
            }

            Console.WriteLine(
                $"\nTotals for each letter grade are:\n" +
                $"A: {a}\nB: {b}\nC: {c}\nD: {d}\nE: {e}\nF: {f}"
            );
            Console.ReadKey();
        }
    }
}
