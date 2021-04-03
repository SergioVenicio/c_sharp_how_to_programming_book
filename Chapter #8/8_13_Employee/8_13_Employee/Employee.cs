using System;

namespace _8_13_Employee
{
    class Employee
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public static int Count { get; private set; }

        public Employee(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
            Count++;
        }


        ~Employee()
        {
            Console.WriteLine($"Destroing ${firstName}...");
            Count--;
        }
    }
}
