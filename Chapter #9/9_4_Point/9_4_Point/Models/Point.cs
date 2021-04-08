using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_Point
{
    class Point
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public Point() { }
        public Point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }

        public override string ToString()
        {
            return $"[{x}, {y}]";
        }
    }
}
