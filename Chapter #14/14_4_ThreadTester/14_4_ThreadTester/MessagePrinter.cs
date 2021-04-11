using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _14_4_ThreadTester
{
    class MessagePrinter
    {
        private int sleepTime;
        private static Random random = new Random();

        public MessagePrinter()
        {
            sleepTime = random.Next(5001);
        }

        public void Print()
        {
            Thread current = Thread.CurrentThread;
            Console.WriteLine($"{current.Name} going to sleep for {sleepTime}");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"{current.Name} done sleeping");
        }
    }
}
