using _10_15_IAge.Models;
using System;

namespace _10_15_IAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree(1978);
            Person person = new Person("Bob", "Jones", 1971);
            IAge[] iageArray = { tree, person };

            foreach(IAge ageReference in iageArray)
            {
                Console.WriteLine($"{ageReference.Name}: Age is {ageReference.Age}");
            }
            Console.ReadLine();
        }
    }
}
