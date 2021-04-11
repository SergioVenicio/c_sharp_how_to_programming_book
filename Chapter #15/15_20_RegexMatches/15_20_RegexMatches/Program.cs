using System;
using System.Text.RegularExpressions;

namespace _15_20_RegexMatches
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex expression = new Regex(@"J.*\d[0-35-9]-\d\d-\d\d");
            string string1 = "Jane`s birthday is 05-12-75\n" +
                "Dave`s birthday is 11-04-68\n" +
                "John`s birthday is 04-28-73\n" +
                "Joe`s birthday is 12-17-77";
            
            foreach (Match match in expression.Matches(string1))
            {
                Console.WriteLine($"{match.ToString()}");
            }

            Console.ReadLine();
        }
    }
}
