using System;
using System.Threading;

namespace _14_6_CircularBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            HoldIntegerSynchronized sharedLocation = new HoldIntegerSynchronized();
            Random random = new Random();

            Producer producer = new Producer(sharedLocation, random);
            Consumer consumer = new Consumer(sharedLocation, random);

            Thread thProducer = new Thread(new ThreadStart(producer.Produce));
            Thread thConsumer = new Thread(new ThreadStart(consumer.Consume));
            thProducer.Name = "Producer";
            thConsumer.Name = "Consumer";

            thProducer.Start();
            thConsumer.Start();

            Console.ReadLine();
        }
    }
}
