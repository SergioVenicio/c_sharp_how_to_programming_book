using System;

namespace _8_13_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Suzan", "Baker");
            Employee employee2 = new Employee("Bob", "Jones");
            Employee[] employees = { employee1, employee2 };

            Console.WriteLine($"Employees after instantiation: {Employee.Count}");

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.firstName} {employee.lastName}");
            }

            employees = null;
            employee1 = null;
            employee2 = null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            Console.WriteLine($"Employees after GC: {Employee.Count}");
        }
    }
}
