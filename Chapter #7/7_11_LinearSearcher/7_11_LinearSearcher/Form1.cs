using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_11_LinearSearcher
{
    public partial class Form1 : Form
    {
        private int[] a =
        {
            2, 4, 6, 8, 10, 12, 14, 16, 18,
            20, 22, 24, 26, 28, 30, 32, 34,
            36, 38, 40, 42, 44, 46, 48, 50
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchKey = Convert.ToInt32(txtSearchText.Text);
            int elementIndex = LinearSearch(a, searchKey);

            if(elementIndex != -1)
            {
                lblResult.Text = $"Found value at {elementIndex}";
            } else
            {
                lblResult.Text = $"Element not found!";
            }
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            int searchKey = Convert.ToInt32(txtSearchText.Text);
            int elementIndex = BinarySearch(a, searchKey);

            if (elementIndex != -1)
            {
                lblResult.Text = $"Found value at {elementIndex}";
            }
            else
            {
                lblResult.Text = $"Element not found!";
            }
        }

        static int LinearSearch(int[] array, int key, int index = 0)
        {
            if (array[index] == key)
            {
                return index;
            }

            return index >= array.Length - 1 ? -1 : LinearSearch(array, key, ++index);
        }

        static int BinarySearch(int[] array, int key, int low = 0, int high = 0)
        {
            high = high != 0 ? high : array.Length - 1;
            int middle = (low + high) / 2;


            if (key == array[middle])
            {
                return middle;
            } else if (low == middle)
            {
                return -1;
            } else if (key < array[middle])
            {
                return BinarySearch(array, key, low, middle);
            } else
            {
                return BinarySearch(array, key, middle, high);
            }
        }
    }
}
