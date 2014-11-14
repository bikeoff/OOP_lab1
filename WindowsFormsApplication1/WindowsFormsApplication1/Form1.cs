using Figures;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeFiguresList();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);

            using (Graphics canvas = Graphics.FromImage(bmp))
            {
                canvas.Clear(Color.White);
                foreach (Figure figure in figuresList)
                    figure.DrawFigure(canvas);
            }

            pictureBox1.Image = bmp;
        }

        private List<Figure> figuresList;

        private void InitializeFiguresList()
        {
            PointStruct point1, point2;

            figuresList = new List<Figure>();
            figuresList.Clear();
            point1.x = 300;
            point1.y = 200;
            point2.x = 230;
            point2.y = 350;
            figuresList.Add(new Rectangles.Rectangle(point1, point2));
/*            figuresList.Add(new Square(point1, point2));
            figuresList.Add(new Ellipse(point1, point2));
            figuresList.Add(new Circle(point1, point2));
            figuresList.Add(new Line(point1, point2));
*/        }
    }
}
