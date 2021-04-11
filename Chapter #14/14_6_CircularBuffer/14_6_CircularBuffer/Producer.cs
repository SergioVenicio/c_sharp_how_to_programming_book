using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _14_6_CircularBuffer
{
    class Producer
    {
        private HoldIntegerSynchronized sharedLocation;
        private Random randomSleepTime;

        public Producer(
            HoldIntegerSynchronized shared, Random random)
        {
            sharedLocation = shared;
            randomSleepTime = random;
        }

        public void Produce()
        {
            for (int count = 11; count < 20; count++)
            {
                Thread.Sleep(randomSleepTime.Next(1, 3));
                sharedLocation.Buffer = count;
            }

            string Name = Thread.CurrentThread.Name;
            Console.WriteLine($"{Name} done producing.\n{Name} terminated");
        }
    }
}
