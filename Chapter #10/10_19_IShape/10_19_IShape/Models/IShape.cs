namespace _10_19_IShape.Models
{
    interface IShape
    {
        double Area();
        double Volume();
        string Name { get; }
    }
}
