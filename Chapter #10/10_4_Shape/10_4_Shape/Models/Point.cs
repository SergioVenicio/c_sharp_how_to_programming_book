namespace _10_4_Shape.Models
{
    public class Point: Shape
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public Point()
        {}

        public Point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }

        public override string ToString()
        {
            return $"[{x}, {y}]";
        }

        public override string Name
        { 
            get
            {
                return "Point";
            }
        }

    }
}
