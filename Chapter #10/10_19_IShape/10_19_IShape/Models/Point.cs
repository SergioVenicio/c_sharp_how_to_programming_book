namespace _10_19_IShape.Models
{
    class Point: IShape
    {
        private int X, Y;

        public Point()
        {}

        public Point(int xValue, int yValue)
        {
            X = xValue;
            Y = yValue;
        }

        public virtual string Name => "Point";

        public virtual double Area() => 0;

        public virtual double Volume() => 0;

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
    }
}
