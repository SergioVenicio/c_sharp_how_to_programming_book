using System;
using System.Threading;

namespace _14_4_ThreadTester
{
    class Program
    {
        static void Main(string[] args)
        {
            MessagePrinter printer1 = new MessagePrinter();
            MessagePrinter printer3 = new MessagePrinter();
            MessagePrinter printer2 = new MessagePrinter();

            Thread thread1 = new Thread(new ThreadStart(printer1.Print));
            Thread thread2 = new Thread(new ThreadStart(printer2.Print));
            Thread thread3 = new Thread(new ThreadStart(printer3.Print));

            thread1.Name = "Thread1";
            thread2.Name = "Thread2";
            thread3.Name = "Thread3";

            Console.WriteLine("Threads started");
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.WriteLine("Threads done");
            Console.ReadLine();
        }
    }
}
