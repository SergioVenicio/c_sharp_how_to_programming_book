namespace _9_4_Point
{
    class Cylinder: Circle
    {
        public double height { get; private set; }

        public Cylinder(): base()
        {}
        public Cylinder(int xValue, int yValue, double radiusValue, double heightValue) : base(xValue, yValue, radiusValue)
        {
            height = heightValue;
        }

        public override double Area()
        {
            return 2 * base.Area() + base.Circumference() * height;
        }

        public double Volume()
        {
            return base.Area() * height;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Height = {height}";
        }
    }
}
