using System;

namespace _10_4_Shape.Models
{
    class Circle: Point
    {
        public double radius { get; private set; }

        public Circle()
        {}

        public Circle(int xValue, int yValue, double radiusValue): base(xValue, yValue)
        {
            radius = radiusValue;
        }

        public double Diameter()
        {
            return radius * 2;
        }

        public double Circumference()
        {
            return Math.PI * Diameter();
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"Center = {base.ToString()}; Radius = {radius};";
        }

        public override string Name
        {
            get
            {
                return "Circle";
            }
        }
    }
}
