using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_16_Indexer
{
    class Box
    {
        private string[] names = { "length", "width", "height" };
        private double[] dimensions = new double[3];

        public Box(double length, double width, double heigth)
        {
            dimensions[0] = length;
            dimensions[1] = width;
            dimensions[2] = heigth;
        }

        public double this[int index]
        {
            get
            {
                return (index < 0 || index >= dimensions.Length) ? -1 : dimensions[index];
            }
            set
            {
                if (index < 0 || index >= dimensions.Length)
                {
                    return;
                }
                
                dimensions[index] = value;
            }
        }

        public double this[string name]
        {
            get
            {
                int i = 0;
                while (i < names.Length && name.ToLower() != names[i])
                {
                    i++;
                }

                return (i == names.Length) ? -1 : dimensions[i];
            }
            set
            {
                int i = 0;
                while (i < names.Length && name.ToLower() != names[i])
                {
                    i++;
                }

                if (i != names.Length)
                {
                    dimensions[i] = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{dimensions[0]} {dimensions[1]} {dimensions[2]}";
        }

    }
}
