using System;

namespace _8_16_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(0.0, 0.0, 0.0);
            Box box2 = new Box(0.0, 0.0, 0.0);
            box["length"] = 10.0;
            box["width"] = 10.0;
            box["height"] = 10.0;

            box2[0] = 20;
            box2[1] = 20;
            box2[2] = 20;

            Console.WriteLine(box);
            Console.WriteLine(box2);

            Console.ReadLine();
        }
    }
}
