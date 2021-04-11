using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_14_LinesRectanglesOvals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Blue);
            Pen pen = new Pen(Color.AliceBlue);

            graphics.FillRectangle(brush, 90, 30, 150, 90);

            graphics.DrawLine(pen, 90, 30, 110, 40);
            graphics.DrawLine(pen, 90, 120, 110, 130);
            graphics.DrawLine(pen, 240, 30, 260, 40);
            graphics.DrawLine(pen, 240, 120, 260, 130);

            graphics.DrawRectangle(pen, 110, 40, 150, 90);

            brush.Color = Color.Red;
            graphics.FillEllipse(brush, 280, 75, 100, 50);

            graphics.DrawLine(pen, 380, 55, 380, 100);
            graphics.DrawLine(pen, 280, 55, 280, 100);
        }
    }
}
