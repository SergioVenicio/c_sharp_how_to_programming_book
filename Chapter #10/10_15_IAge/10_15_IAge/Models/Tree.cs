using System;

namespace _10_15_IAge.Models
{
    class Tree: IAge
    {
        private int rings;

        public Tree(int yearPlanted)
        {
            rings = DateTime.Now.Year - yearPlanted;
        }

        public int Age => rings;

        public string Name => "Tree";

        public void AddRing()
        {
            rings++;
        }
    }
}
