using System;
using System.Collections.Generic;
using System.Threading;

namespace _14_6_CircularBuffer
{
    class HoldIntegerSynchronized
    {
        private List<int> buffers = new List<int>();

        public int Buffer
        {
            get
            {
                lock (this)
                {
                    if (buffers.Count == 0)
                    {
                        Console.WriteLine("Empty buffer");
                        Monitor.Wait(this);
                    }

                    int readValue = buffers[0];
                    buffers.RemoveAt(0);
                    Console.WriteLine(
                        $"{Thread.CurrentThread.Name} Get {readValue}");

                    Monitor.Pulse(this);
                    return readValue;
                }
            }
            set
            {
                lock (this)
                {
                    buffers.Add(value);

                    Console.WriteLine(
                    $"{Thread.CurrentThread.Name} Write {value}");
                    Monitor.Pulse(this);
                }
            }
        }
    }
}
