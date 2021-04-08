using _10_4_Shape.Models;
using System;

namespace _10_4_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(7, 11);
            Circle circle = new Circle(22, 8, 3.5);
            Cylinder cylinder = new Cylinder(10, 10, 3.3, 10);
            Shape[] arrayOfShapes = { point, circle, cylinder };

            foreach(Shape shape in arrayOfShapes)
            {
                Console.WriteLine($"{shape.Name}: {shape}.\nArea: {shape.Area()}.\nVolume: {shape.Volume()}");
            }
        }
    }
}
