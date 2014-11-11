using System;
using System.Drawing;
using System.Windows.Forms;
using Figures;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangles.Rectangle rect;
            Ellipses.Ellipse elps;
            Lines.Line line;
            var bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);

            using (Graphics canvas = Graphics.FromImage(bmp))
            {
                canvas.Clear(Color.White);
                foreach (Figure figure in Program.list)
                {
                    if (figure is Rectangles.Rectangle)
                    {
                        rect = figure as Rectangles.Rectangle;
                        canvas.DrawRectangle(Pens.Black, rect.xLeft, rect.yTop, rect.xRight - rect.xLeft, rect.yBottom - rect.yTop);
                    }
                    else if (figure is Ellipses.Ellipse)
                    {
                        elps = figure as Ellipses.Ellipse;
                        canvas.DrawEllipse(Pens.Black, elps.xCenter - elps.halfWidth, elps.yCenter - elps.halfHeight, elps.halfWidth * 2, elps.halfHeight * 2);
                    }
                    else if (figure is Lines.Line)
                    {
                        line = figure as Lines.Line;
                        canvas.DrawLine(Pens.Black, line.xStart, line.yStart, line.xEnd, line.yEnd);
                    }
                }                
            }

            pictureBox1.Image = bmp;
        }
    }
}
