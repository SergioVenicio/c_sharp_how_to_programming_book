using System;
using System.Windows.Forms;

namespace _11_1_DivideByZero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            try
            {
                int numerator = Convert.ToInt32(txtNumerator.Text);
                int denominator = Convert.ToInt32(txtDenominator.Text);
                lblResult.Text = Convert.ToString(numerator / denominator);
            } catch(FormatException)
            {
                MessageBox.Show(
                    "You must enter two integers",
                    "Invalid Number Format",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } catch (DivideByZeroException exeption)
            {
                MessageBox.Show(
                    exeption.Message,
                    "Attempet to divide by zero",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
