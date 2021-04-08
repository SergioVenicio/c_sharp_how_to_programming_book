using _10_19_IShape.Models;
using System;

namespace _10_19_IShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(7, 11);
            Circle circle = new Circle(22, 8, 3.5);
            Cylinder cylinder = new Cylinder(10, 10, 3.3, 10);
            IShape[] arrayOfShapes = { point, circle, cylinder };

            foreach(IShape shape in arrayOfShapes)
            {
                Console.WriteLine($"{shape.Name}:\n\tArea = {shape.Area()}\n\tVolume = {shape.Volume()}");
            }

            Console.ReadLine();
        }
    }
}
