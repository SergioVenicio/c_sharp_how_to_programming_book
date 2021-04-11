using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_16_CharMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyzeChar_Click(object sender, EventArgs e)
        {
            char newChar;

            try
            {
                newChar = Convert.ToChar(txtChar.Text);
            } catch (FormatException)
            {
                return;
            }
            

            txtChar.Text = "";
            WriteItems(newChar);
        }

        public void WriteItems(char newChar)
        {
            ltbResult.Items.Clear();
            ltbResult.Items.Add($"{newChar} is digit: {Char.IsDigit(newChar)}");
            ltbResult.Items.Add($"{newChar} is letter: {Char.IsLetter(newChar)}\n");
            ltbResult.Items.Add($"{newChar} is letter or digit: {Char.IsLetterOrDigit(newChar)}\n");
            ltbResult.Items.Add($"{newChar} is lower case: {Char.IsLower(newChar)}\n");
            ltbResult.Items.Add($"{newChar} is lower case: {Char.IsUpper(newChar)}\n");
            ltbResult.Items.Add($"{newChar} to upper case: {Char.ToUpper(newChar)}\n");
            ltbResult.Items.Add($"{newChar} to lower case: {Char.ToLower(newChar)}\n");
            ltbResult.Items.Add($"{newChar} is punctuation case: {Char.IsPunctuation(newChar)}\n");
            ltbResult.Items.Add($"{newChar} is symbol case: {Char.IsSymbol(newChar)}\n");
        }
    }
}
