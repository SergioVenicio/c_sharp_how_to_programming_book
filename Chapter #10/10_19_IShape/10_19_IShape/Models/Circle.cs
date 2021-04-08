using System;

namespace _10_19_IShape.Models
{
    class Circle: Point
    {
        public double Radius { get; private set; }

        public Circle()
        {}

        public Circle(int x, int y, double radius): base(x, y)
        {
            Radius = radius;
        }

        public double Diameter() => Radius * 2;

        public double Circumference() => Math.PI * Diameter();

        public override double Area() => Math.PI * Math.Pow(Radius, 2);

        public override string ToString()
        {
            return $"Center = {base.ToString()}; Radius = {Radius}";
        }

        public override string Name => "Circle";
    }
}
