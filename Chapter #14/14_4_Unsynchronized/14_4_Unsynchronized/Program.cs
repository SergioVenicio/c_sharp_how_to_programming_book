using System;
using System.Threading;

namespace _14_4_Unsynchronized
{
    class Program
    {
        static void Main(string[] args)
        {
            HoldIntegerUnsyncrhonized holdInteger = new HoldIntegerUnsyncrhonized();
            Random random = new Random();

            Producer producer = new Producer(holdInteger, random);
            Consumer consumer = new Consumer(holdInteger, random);

            Thread producerThread = new Thread(new ThreadStart(producer.Produce));
            Thread consumerThread = new Thread(new ThreadStart(consumer.Consume));

            producerThread.Name = "Producer";
            consumerThread.Name = "Consumer";

            producerThread.Start();
            consumerThread.Start();

            Console.ReadLine();
        }
    }
}
