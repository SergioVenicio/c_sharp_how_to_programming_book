using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_3_SquareInt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                lblResult.Text += $"The square of {i} is {Math.Pow(i, 2)}\n";
            }
        }
    }
}
