using System;
using System.Threading;

namespace _14_4_Unsynchronized
{
    class HoldIntegerUnsyncrhonized
    {

        private int buffer = -1;

        public int Buffer
        {
            get
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} reads {buffer}...");
                return buffer;
            }
            set
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} writes {value}...");
                buffer = value;
            }
        }
    }
}
