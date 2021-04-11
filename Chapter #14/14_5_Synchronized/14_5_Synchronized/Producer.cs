using System;
using System.Threading;

namespace _14_5_Synchronized
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
            for (int count = 1; count <= 4; count++)
            {
                Thread.Sleep(randomSleepTime.Next(1, 3000));
                sharedLocation.Buffer = count;
            }

            string Name = Thread.CurrentThread.Name;
            Console.WriteLine(
                $"{Name} done producing.\nTerminating {Name}\n");
        }
    }
}
