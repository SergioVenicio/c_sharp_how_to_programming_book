using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _14_4_Unsynchronized
{
    class Consumer
    {
        private HoldIntegerUnsyncrhonized sharedLocation;
        private Random randomSleepTime;

        public Consumer(
            HoldIntegerUnsyncrhonized shared, Random random)
        {
            sharedLocation = shared;
            randomSleepTime = random;
        }

        public void Consume()
        {
            int sum = 0;

            for (int count = 1; count <= 4; count++)
            {
                Thread.Sleep(randomSleepTime.Next(1, 3000));
                sum += sharedLocation.Buffer;
            }

            string Name = Thread.CurrentThread.Name;
            Console.WriteLine($"{Name} read values totaling: {sum}");
        }
    }
}
