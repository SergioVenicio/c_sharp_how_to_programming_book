namespace _10_4_Shape.Models
{
    public abstract class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
        public virtual double Volume()
        {
            return 0;
        }
        public abstract string Name
        {
            get;
        }

    }
}
