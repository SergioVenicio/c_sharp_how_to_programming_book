using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_4_MaximumValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            var Numbers = new List<double>() {
                Convert.ToDouble(txbFirstNumber.Text),
                Convert.ToDouble(txbSecondNumber.Text),
                Convert.ToDouble(txbThirdNumber.Text)
            };

            lblResult.Text += Convert.ToString(Numbers.Max());
        }
    }
}
