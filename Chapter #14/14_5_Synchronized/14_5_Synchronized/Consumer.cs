using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _14_5_Synchronized
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

            Thread current = Thread.CurrentThread;

            for (int count = 1; count <= 4; count++)
            {
                Thread.Sleep(randomSleepTime.Next(1, 3000));
                sum += sharedLocation.Buffer;
            }

            Console.WriteLine(
                $"{current.Name} read values totaling: {sum}\nTerminating {current.Name}");
        }
    }
}
