using System;
using System.Threading;

namespace _14_5_Synchronized
{
    class Program
    {
        static void Main(string[] args)
        {
            HoldIntegerSynchronized holdInteger = new HoldIntegerSynchronized();
            Random random = new Random();

            Producer producer = new Producer(holdInteger, random);
            Consumer consumer = new Consumer(holdInteger, random);

            holdInteger.DisplayState("Inital State");

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
