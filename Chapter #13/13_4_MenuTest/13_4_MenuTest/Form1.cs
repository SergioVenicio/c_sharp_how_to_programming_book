using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_4_MenuTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This is an example\nof using menus.",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearColor()
        {
            tsMenuItemBlackColor.Checked = false;
            tsMenuItemBlueColor.Checked = false;
            tsMenuItemGreenColor.Checked = false;
            tsMenuItemRedColor.Checked = false;
        }

        private void ClearFont()
        {
            tsMenuItemTimesNewRomanFont.Checked = false;
            tsMenuItemCourierFont.Checked = false;
            tsMenuItemComicSansFont.Checked = false;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            lblDisplay.ForeColor = Color.Black;
            tsMenuItemBlackColor.Checked = true;
        }

        private void tsMenuItemBlueColor_Click(object sender, EventArgs e)
        {

            ClearColor();
            lblDisplay.ForeColor = Color.Blue;
            tsMenuItemBlueColor.Checked = true;

        }

        private void tsMenuItemRedColor_Click(object sender, EventArgs e)
        {
            ClearColor();
            lblDisplay.ForeColor = Color.Red;
            tsMenuItemRedColor.Checked = true;
        }

        private void tsMenuItemGreenColor_Click(object sender, EventArgs e)
        {
            ClearColor();
            lblDisplay.ForeColor = Color.Green;
            tsMenuItemGreenColor.Checked = true;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            tsMenuItemTimesNewRomanFont.Checked = true;
            lblDisplay.Font = new Font(
                "Times New Roman", lblDisplay.Font.Size, lblDisplay.Font.Style
            );
        }

        private void tsMenuItemCourierFont_Click(object sender, EventArgs e)
        {
            ClearFont();
            tsMenuItemCourierFont.Checked = true;
            lblDisplay.Font = new Font(
                "Courier New", lblDisplay.Font.Size, lblDisplay.Font.Style
            );
        }

        private void tsMenuItemComicSansFont_Click(object sender, EventArgs e)
        {
            ClearFont();
            tsMenuItemComicSansFont.Checked = true;
            lblDisplay.Font = new Font(
                "Comic Sans MS", lblDisplay.Font.Size, lblDisplay.Font.Style
            );
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsMenuItemBoldText.Checked = !tsMenuItemBoldText.Checked;
            lblDisplay.Font = new Font(
                lblDisplay.Font.FontFamily,
                lblDisplay.Font.Size,
                lblDisplay.Font.Style ^ FontStyle.Bold
            );
        }

        private void tsMenuItemItalicText_Click(object sender, EventArgs e)
        {
            tsMenuItemItalicText.Checked = !tsMenuItemItalicText.Checked;
            lblDisplay.Font = new Font(
                lblDisplay.Font.FontFamily,
                lblDisplay.Font.Size,
                lblDisplay.Font.Style ^ FontStyle.Italic
            );
        }
    }
}
