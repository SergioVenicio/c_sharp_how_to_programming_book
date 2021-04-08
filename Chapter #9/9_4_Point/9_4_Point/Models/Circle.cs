using System;

namespace _9_4_Point
{
    class Circle: Point
    {
        public double radius { get; private set; }

        public Circle(): base()
        {}

        public Circle(int xValue, int yValue, double radiusValue) : base(xValue, yValue)
        {
            radius = radiusValue;
        }

        virtual public double Diameter()
        {
            return radius * 2;
        }

        public double Circumference()
        { 
            return Math.PI * Diameter();
        }

        virtual public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"Center = {base.ToString()}; Radius = {radius}";
        }

    }
}
