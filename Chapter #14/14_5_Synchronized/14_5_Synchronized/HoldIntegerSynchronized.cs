using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _14_5_Synchronized
{
    class HoldIntegerSynchronized
    {
        private int buffer = -1;
        private int occupiedBufferCount = 0;

        public int Buffer
        {
            get
            {
                Monitor.Enter(this);

                if (occupiedBufferCount == 0)
                {
                    Console.WriteLine(
                        $"{Thread.CurrentThread.Name} tries to read.");
                    DisplayState(
                        $"Buffer Empty.\n{Thread.CurrentThread.Name} waits.");
                    Monitor.Wait(this);
                }

                --occupiedBufferCount;

                DisplayState(
                    $"{Thread.CurrentThread.Name} reads {buffer}");

                Monitor.Pulse(this);
                int bufferCopy = buffer;
                Monitor.Exit(this);

                return bufferCopy;
            }
            set
            {
                Monitor.Enter(this);

                if (occupiedBufferCount == 1)
                {
                    Console.WriteLine(
                        $"{Thread.CurrentThread.Name} tries to write.");
                    DisplayState(
                        $"Buffer full.\n {Thread.CurrentThread.Name} waits.");
                    Monitor.Wait(this);
                }

                buffer = value;

                ++occupiedBufferCount;
                DisplayState(
                    $"{Thread.CurrentThread.Name} writes {buffer}");

                Monitor.Pulse(this);
                Monitor.Exit(this);
            }
        }

        public void DisplayState(string operation)
        {
            Console.WriteLine("{0, -35}{1, -9}{2}\n", operation, buffer, occupiedBufferCount);
        }
    }
}
