using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_19_IShape.Models
{
    class Cylinder: Circle
    {
        public double Height { get; private set; }

        public Cylinder()
        {}

        public Cylinder(int x, int y, double radius, double height): base(x, y, radius)
        {
            Height = height;
        }

        public override string Name => "Cylinder";

        public override double Area() => 2 * base.Area() + base.Circumference() * Height;

        public override double Volume() => base.Area() * Height;

        public override string ToString()
        {
            return $"Center = {base.ToString()}; Height = {Height}";
        }
    }
}
