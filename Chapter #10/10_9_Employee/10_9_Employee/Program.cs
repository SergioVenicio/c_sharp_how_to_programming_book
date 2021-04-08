using _10_9_Employee.Models;
using System;

namespace _10_9_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss("John", "Smith", 800);
            CommisionWorker commisionWorker = new CommisionWorker("Sue", "Jones", 400, 3, 150);
            PieceWorker pieceWorker = new PieceWorker("Bob", "Lewis", (decimal)2.5, 200);
            HourlyWorker hourlyWorker = new HourlyWorker("Karen", "Priece", (decimal)13.75, 50);
            Employee[] workers = { boss, commisionWorker, pieceWorker, hourlyWorker };

            foreach (Employee worker in workers)
            {
                Console.WriteLine($"{worker}.\nEarned: {worker.Earnings().ToString("C")}");
            }
        }
    }
}
