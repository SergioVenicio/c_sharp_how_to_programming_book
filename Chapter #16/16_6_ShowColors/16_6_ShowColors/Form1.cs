using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_6_ShowColors
{
    public partial class Form1 : Form
    {
        private Color behindColor = Color.Wheat;
        private Color frontColor = Color.FromArgb(100, 0, 0, 255);

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            SolidBrush textBrush = new SolidBrush(Color.Black);
            SolidBrush brush = new SolidBrush(Color.White);

            graphics.FillRectangle(brush, 4, 4, 275, 180);
            graphics.DrawString(behindColor.Name, this.Font, textBrush, 40, 5);

            brush.Color = behindColor;
            graphics.FillRectangle(brush, 45, 20, 150, 120);

            string colorText = $"Alpha: {frontColor.A}, Red: {frontColor.R}, Green: {frontColor.G}, Blue: {frontColor.B}";
            graphics.DrawString(colorText, this.Font, textBrush, 55, 165);

            brush.Color = frontColor;
            graphics.FillRectangle(brush, 65, 35, 170, 130);
        }

        private void btnSetColorValue_Click(object sender, EventArgs e)
        {
            frontColor = Color.FromArgb(
                Convert.ToInt32(txtAlpha.Text),
                Convert.ToInt32(txtRed.Text),
                Convert.ToInt32(txtGreen.Text),
                Convert.ToInt32(txtBlue.Text)
            );

            Invalidate();
        }

        private void btnSetColorName_Click(object sender, EventArgs e)
        {
            behindColor = Color.FromName(txtColorName.Text);
            Invalidate();
        }
    }
}
