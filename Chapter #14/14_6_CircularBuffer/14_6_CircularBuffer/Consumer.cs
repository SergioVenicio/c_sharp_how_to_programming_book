using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _14_6_CircularBuffer
{
    class Consumer
    {
        private HoldIntegerSynchronized sharedLocation;
        private Random randomSleepTime;

        public Consumer(
            HoldIntegerSynchronized shared, Random random)
        {
            sharedLocation = shared;
            randomSleepTime = random;
        }

        public void Consume()
        {
            int sum = 0;
            string Name = Thread.CurrentThread.Name;

            for (int count = 1; count <= 10; count++)
            {
                Thread.Sleep(randomSleepTime.Next(1, 3));
                sum += sharedLocation.Buffer;
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
